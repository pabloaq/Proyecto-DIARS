//using CapaEntidad;
//using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormDetallePedido : Form
    {
        public FormDetallePedido()
        {

        }

        private void dgvDetPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void limpiarVariables()
        {
            cmbPedidoId.SelectedIndex = 0;
            cmbProductoId.SelectedIndex = 0;
            nudCantidad.Value = 1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPedido pedido = new FormPedido();
            Hide();
            pedido.ShowDialog();
            Close();
        }
    }
}
