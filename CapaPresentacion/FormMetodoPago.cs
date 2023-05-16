//using CapaEntidad;
//using CapaLogica;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMetodoPago : Form
    {
        private List<EntCategoriaMetodoPago> catMetodoPago = LogCategoriaMetodoPago.Instancia.ListarCategoriaMetodoPago();

        public FormMetodoPago()
        {
            InitializeComponent();
            ListarMetodoPago();
            ListarComboBoxCategoriaMetodoPago();
            CambiarEncabezados();
        }

        private void ListarComboBoxCategoriaMetodoPago()
        {
            cbCategoriaMetodoPago.DataSource = LogCategoriaMetodoPago.Instancia.ListarCategoriaMetodoPago();
            cbCategoriaMetodoPago.ValueMember = "IdCategoriaMetodoPago";
            cbCategoriaMetodoPago.DisplayMember = "Nombre";
        }

        private void LimpiarVariables()
        {
            txtIdMetodoPago.Text = string.Empty;
            cbCategoriaMetodoPago.SelectedIndex = -1;
            txtNombreMetodoPago.Text = string.Empty;
        }

        private void CambiarEncabezados()
        {
            dgvMetodoPago.Columns[0].HeaderText = "Codigo";
            dgvMetodoPago.Columns[1].HeaderText = "Nombre Categoria";
            dgvMetodoPago.Columns[2].Visible = false;
            dgvMetodoPago.Columns[3].HeaderText = "Nombre";
        }

        private void ListarMetodoPago()
        {
            dgvMetodoPago.DataSource = LogMetodoPago.Instancia.ListarMetodoPago();
        }

        private void dgvMetodoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMetodoPago.Rows[e.RowIndex];

            txtIdMetodoPago.Text = filaActual.Cells[0].Value.ToString();
            cbCategoriaMetodoPago.Text = filaActual.Cells[1].Value.ToString();
            txtNombreMetodoPago.Text = filaActual.Cells[3].Value.ToString();
        }

        private void dgvMetodoPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaActual = dgvMetodoPago.Rows[e.RowIndex];


            EntMetodoPago metodoPago = new EntMetodoPago();
            metodoPago.idMetodoPago = filaActual.Cells[0].Value.ToString();

            LogMetodoPago.Instancia.EliminarMetodoPago(metodoPago);


            ListarMetodoPago();
        }

        private void btnAgregarMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                EntMetodoPago entMetodoPago = new EntMetodoPago();

                if(txtNombreMetodoPago.Text != "" && txtIdMetodoPago.Text != "" && cbCategoriaMetodoPago.SelectedIndex != -1)
                {
                    foreach(EntCategoriaMetodoPago cateMetodoPago in catMetodoPago)
                    {
                        if(cateMetodoPago.Nombre == cbCategoriaMetodoPago.Text)
                        {
                            entMetodoPago.idCategoriaMetodoPago = cateMetodoPago.IdCategoriaMetodoPago;
                        }
                    }

                    entMetodoPago.idMetodoPago = txtIdMetodoPago.Text;
                    entMetodoPago.nombre = txtNombreMetodoPago.Text;

                    LogMetodoPago.Instancia.InsertarMetodoPago(entMetodoPago);
                    
                }
                else
                {
                    MessageBox.Show("Casillas vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }


            LimpiarVariables();
            ListarMetodoPago();
        }

        private void btnModificarMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                EntMetodoPago entMetodoPago = new EntMetodoPago();

                if (txtNombreMetodoPago.Text != "" && txtIdMetodoPago.Text != "" && cbCategoriaMetodoPago.SelectedIndex != -1)
                {
                    foreach (EntCategoriaMetodoPago cateMetodoPago in catMetodoPago)
                    {
                        if (cateMetodoPago.Nombre == cbCategoriaMetodoPago.Text)
                        {
                            entMetodoPago.idCategoriaMetodoPago = cateMetodoPago.IdCategoriaMetodoPago;
                        }
                    }

                    entMetodoPago.idMetodoPago = txtIdMetodoPago.Text;
                    entMetodoPago.nombre = txtNombreMetodoPago.Text;

                    LogMetodoPago.Instancia.ModificarMetodoPago(entMetodoPago);

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


            LimpiarVariables();
            ListarMetodoPago();
        }

        private void btn_EliminarMetodoPago_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btn_EliminarMetodoPago_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
