using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPedido : Form
    {
        private List<EntTipoPedido> listaTipoPedido = LogTipoPedido.Instancia.ListarTipoPedido();
        
        private List<EntProducto> listaProducto = LogProducto.Instancia.ListarProducto();
        
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
            activarPanelPedido();
        }

        private void limpiarEntradasPedido()
        {
            cmbTipoPedido.SelectedIndex = -1;
            txtNombreClientePedido.Text = "";
            txtDireccionPedido.Text = "";
            txtNombreClienteDP.Text = "";
        }

        private void limpiarEntradasDetPedido()
        {
            cmbProducto.SelectedIndex = -1;
            cantidadProducto = 1;
            lbCantidadProducto.Text = "1";
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

        private void activarPanelPedido()
        {
            panelPedido.Enabled = true;
            panelDetallePedido.Enabled = false;
        }

        private void activarPanelDetallePedido()
        {
            panelPedido.Enabled = false;
            panelDetallePedido.Enabled = true;
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
                    if (txtDireccionPedido.Visible)
                        pedido.direccion = txtDireccionPedido.Text;
                    else
                        pedido.direccion = "null";

                    LogPedido.Instancia.InsertarPedido(pedido);

                    txtNombreClienteDP.Text = pedido.nombreCliente;
                    panelDetallePedido.Enabled = true;
                    activarPanelDetallePedido();
                }
                else
                    MessageBox.Show("Casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void cmbTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPedido.Text == "Delivery")
            {
                lbDireccion.Visible = true;
                txtDireccionPedido.Visible = true;
            }
            else
            {
                lbDireccion.Visible = false;
                txtDireccionPedido.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int celda = dgvDetPedido.Rows.Add();
            List<EntPedido> listaPedido = LogPedido.Instancia.ListarPedido();

            dgvDetPedido.Rows[celda].Cells[0].Value = listaPedido[listaPedido.Count-1].idPedido.ToString();
            if (cmbProducto.SelectedIndex != -1)
            {
                foreach (EntProducto producto in listaProducto)
                {
                    if (producto.Nombre.Equals(cmbProducto.Text))
                    {
                        dgvDetPedido.Rows[celda].Cells[1].Value = producto.IdProducto.ToString();
                        dgvDetPedido.Rows[celda].Cells[2].Value = producto.Nombre.ToString();
                    }
                }
            }
            dgvDetPedido.Rows[celda].Cells[3].Value = cantidadProducto.ToString();
            limpiarEntradasDetPedido();
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
                cantidadProducto = int.Parse(dgvDetPedido.Rows[index].Cells[3].Value.ToString());
                lbCantidadProducto.Text = cantidadProducto.ToString(); //actualizando el valor del label
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                dgvDetPedido.Rows.RemoveAt(index);
 
            }
            limpiarEntradasDetPedido();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                foreach (EntProducto producto in listaProducto)
                {
                    if (producto.Nombre.Equals(cmbProducto.Text))
                    {
                        dgvDetPedido.Rows[index].Cells[1].Value = producto.IdProducto.ToString();
                        dgvDetPedido.Rows[index].Cells[2].Value = producto.Nombre.ToString();
                    }
                    dgvDetPedido.Rows[index].Cells[3].Value = cantidadProducto.ToString();
                }

            }
            limpiarEntradasDetPedido();
        }

        private void btnRegistrarDP_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvDetPedido.Rows)
            {
                EntDetallePedido detPedido = new EntDetallePedido();
                detPedido.idPedido = Convert.ToString(fila.Cells[0].Value);
                detPedido.idProducto = Convert.ToString(fila.Cells[1].Value);
                detPedido.cantidad = Convert.ToInt32(fila.Cells[3].Value);

                LogDetallePedido.Instancia.InsertarDetallePedido(detPedido);
            } 
            limpiarEntradasDetPedido();
            limpiarEntradasPedido();
            dgvDetPedido.Rows.Clear();//elimina las filas de la coleccion
            activarPanelPedido();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
