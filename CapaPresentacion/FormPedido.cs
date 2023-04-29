﻿using CapaEntidad;
using CapaLogica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FormPedido : Form
    {
        private List<EntTipoPedido> listaTipoPedido = LogTipoPedido.Instancia.ListarTipoPedido();
        private List<EntProducto> listaProducto = LogProducto.Instancia.ListarProducto();
        private List<EntPedido> listaPedido = LogPedido.Instancia.ListarPedido();
        private int cantidadMaxProducto = 15;
        private int cantidadMinProducto = 1;
        private int cantidadProducto = 1;
        int index = 0;

        public FormPedido()
        {
            InitializeComponent();
            listarComboBoxTipoPedido();       
            listarComboBoxProducto();
            cmbTipoPedido.DropDownStyle = ComboBoxStyle.DropDownList;//Evita que el usuario pueda modificar el cuadro de texto
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            //panelDetallePedido.Enabled = false;
        }

        private void listarComboBoxTipoPedido()
        {
            foreach(EntTipoPedido tipoPedido in listaTipoPedido)
            {
                cmbTipoPedido.Items.Add(tipoPedido.nombreTipoPedido);
            }
        }

        private void listarComboBoxProducto()
        {
            foreach (EntProducto producto in listaProducto)
            {
                cmbProducto.Items.Add(producto.Nombre);
            }
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            if (cantidadProducto < cantidadMaxProducto)
            {
                cantidadProducto++;
                lbCantidadProducto.Text = cantidadProducto.ToString();
            }
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            if (cantidadProducto > cantidadMinProducto)
            {
                cantidadProducto--;
                lbCantidadProducto.Text = cantidadProducto.ToString();
            }
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            EntPedido pedido = new EntPedido();
            try
            {
                if (txtNombreClientePedido.Text != "" && cmbTipoPedido.SelectedIndex != -1)
                {
                    foreach(EntTipoPedido tipoPedido in listaTipoPedido)//recupera el id del tipoPedido de la lista tipoPedido
                    {
                        if (tipoPedido.nombreTipoPedido == cmbTipoPedido.Text)
                            pedido.idTipoPedido = tipoPedido.idTipoPedido;
                    }
                    pedido.nombreCliente = txtNombreClientePedido.Text;
                    if (txtDireccionPedido.Enabled)
                        pedido.direccion = txtDireccionPedido.Text;
                    else pedido.direccion = "null";

                    LogPedido.Instancia.InsertarPedido(pedido);
                }
                else
                    MessageBox.Show("Casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            txtNombreClienteDP.Text = pedido.nombreCliente;
            panelDetallePedido.Enabled = true;
            //panelPedido.Enabled = false;
        }

        private void cmbTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPedido.Text == "delivery")
            {
                txtDireccionPedido.Enabled = true;
            } else txtDireccionPedido.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int celda = dgvDetPedido.Rows.Add();

            EntPedido ultimoDato = listaPedido[listaPedido.Count-1];//acomodar el indice del ultimo registro

            dgvDetPedido.Rows[celda].Cells[0].Value = ultimoDato.idPedido.ToString();
            if (cmbProducto.SelectedIndex != -1)
            {
                foreach (EntProducto producto in listaProducto)
                {
                    if (producto.Nombre.Equals(cmbProducto.Text))
                        dgvDetPedido.Rows[celda].Cells[1].Value = producto.IdProducto.ToString();
                }
            }
            dgvDetPedido.Rows[celda].Cells[2].Value = cantidadProducto.ToString();

        }

        private void dgvDetPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            
            if (index != -1)
            {
                foreach (EntProducto producto in listaProducto)
                {
                    if (producto.IdProducto.Equals(dgvDetPedido.Rows[index].Cells[1].Value))
                        cmbProducto.Text = producto.Nombre.ToString();
                }
                cantidadProducto = int.Parse(dgvDetPedido.Rows[index].Cells[2].Value.ToString());
                lbCantidadProducto.Text = cantidadProducto.ToString(); //actualizando el valor del label
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                dgvDetPedido.Rows.RemoveAt(index);
 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                foreach (EntProducto producto in listaProducto)
                {
                    if (producto.Nombre.Equals(cmbProducto.Text))
                        dgvDetPedido.Rows[index].Cells[1].Value = producto.IdProducto.ToString();
                    dgvDetPedido.Rows[index].Cells[2].Value = cantidadProducto.ToString();
                }

            }
        }

        private void btnRegistrarDP_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvDetPedido.Rows)
            {
                EntDetallePedido detPedido = new EntDetallePedido();
                detPedido.idPedido = Convert.ToString(fila.Cells[0].Value);
                detPedido.idProducto = Convert.ToString(fila.Cells[1].Value);
                detPedido.cantidad = Convert.ToInt32(fila.Cells[2].Value);

                LogDetallePedido.Instancia.InsertarDetallePedido(detPedido);
            }
        }
    }
}
