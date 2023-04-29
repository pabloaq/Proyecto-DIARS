using CapaEntidad;
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
        private int cantidadMaxProducto = 15;
        private int cantidadMinProducto = 1;
        private int cantidadProducto = 1;

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
            try
            {
                if (txtNombreClientePedido.Text != "" && cmbTipoPedido.SelectedIndex != -1)
                {
                    EntPedido pedido = new EntPedido();

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
    }
}
