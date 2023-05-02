using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCategoriaMetodoPago : Form
    {
        public FormCategoriaMetodoPago()
        {
            InitializeComponent();
            listarCategoriaMetodoPago();
            dgvCatMetodoPago.Columns["IdCategoriaMetodoPago"].HeaderText = "Codigo";
        }

        public void listarCategoriaMetodoPago()
        {
            dgvCatMetodoPago.DataSource = LogCategoriaMetodoPago.Instancia.ListarCategoriaMetodoPago(); 
        }


        private void dgvCatMetodoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCatMetodoPago.Rows[e.RowIndex];

            txtCodigoCatMetodoPago.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCatMetodoPago.Text = filaActual.Cells[1].Value.ToString();
        }

        private void dgvCatMetodoPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaActual = dgvCatMetodoPago.Rows[e.RowIndex];


            EntCategoriaMetodoPago categoriaMetodoPago = new EntCategoriaMetodoPago();
            categoriaMetodoPago.IdCategoriaMetodoPago = filaActual.Cells[0].Value.ToString();

            LogCategoriaMetodoPago.Instancia.EliminarCategoriaMetodoPago(categoriaMetodoPago);


            listarCategoriaMetodoPago();
        }

        private void limpiarVariables()
        {
            txtCodigoCatMetodoPago.Text = string.Empty;
            txtNombreCatMetodoPago.Text = string.Empty;
        }


        private void btn_AgregarCatMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCodigoCatMetodoPago.Text != "" && txtNombreCatMetodoPago.Text != "")
                {
                    EntCategoriaMetodoPago categoriaMetodoPago = new EntCategoriaMetodoPago();
                    categoriaMetodoPago.IdCategoriaMetodoPago = txtCodigoCatMetodoPago.Text;
                    categoriaMetodoPago.Nombre= txtNombreCatMetodoPago.Text;

                    LogCategoriaMetodoPago.Instancia.InsertarCategoriaMetodoPago(categoriaMetodoPago);
                }
                else
                {
                    MessageBox.Show("Casillas vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            limpiarVariables();
            listarCategoriaMetodoPago();
        }

        

        private void btn_ModificarCatMetodoPago_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtNombreCatMetodoPago.Text != "")
                {
                    EntCategoriaMetodoPago categoriaMetodoPago = new EntCategoriaMetodoPago();
                    categoriaMetodoPago.IdCategoriaMetodoPago = txtCodigoCatMetodoPago.Text;
                    categoriaMetodoPago.Nombre = txtNombreCatMetodoPago.Text;

                    LogCategoriaMetodoPago.Instancia.ModificarCategoriaMetodoPago(categoriaMetodoPago);
                }
                else
                {
                    MessageBox.Show("Casillas vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            limpiarVariables();
            listarCategoriaMetodoPago();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_EliminarCatMetodoPago_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
            btnSalir.Location = new System.Drawing.Point(244, 200);
        }

        private void btn_EliminarCatMetodoPago_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
            btnSalir.Location = new System.Drawing.Point(244, 171);
        }
    }
}
