//using CapaEntidad;
//using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPedido : Form
    {
        public FormPedido()
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FormDetallePedido detpe = new FormDetallePedido();
            Hide();
            detpe.ShowDialog();
            Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormLogin inicio = new FormLogin();
            Hide();
            inicio.ShowDialog();
            Close();
        }
    }
}
