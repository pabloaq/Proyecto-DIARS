//using CapaEntidad;
//using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPagoTrabajador : Form
    {
        public FormPagoTrabajador()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSueldo.Text = "";
            cbIdEmpleado.Text = "";
            dpFechaRegistro.Text = "";
        }

        public void limpiarVariables()
        {
            txtSueldo.Text = "";
            cbIdEmpleado.Text = "";
            dpFechaRegistro.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
