//using CapaEntidad;
//using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMetodoPago : Form
    {
        public FormMetodoPago()
        {
            InitializeComponent();
        }



        private void btnAgregarMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNombreMetodoPago.Text != "" && txtIdMetodoPago.Text != "" && cbCategoriaMetodoPago.SelectedIndex != -1)
                {
                    
                    
                }
                else
                {
                    MessageBox.Show("Casillas vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            
        }

        private void btnModificarMetodoPago_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarMetodoPago_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvMetodoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
