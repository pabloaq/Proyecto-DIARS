using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
namespace CapaPresentacion
{
    public partial class FormTipoPedido : Form
    {
        public FormTipoPedido()
        {
            InitializeComponent();
            ListarTipoPedido();
        }
        public void ListarTipoPedido()
        { 
            // muestro la bd en la dgvTipoPededip
            dgvTipoPedido.DataSource = LogTipoPedido.Instancia.ListarTipoPedido();
        }

        public void LimpiarDatos()
        {
            // Limpia los valores de los controles de texto
            txtIDTipoPedido.Text = "";
            txtNombreTipoPedido.Text = "";
        }
        private void btnEliminarTipoPedido_Click(object sender, EventArgs e)
        {
            if (dgvTipoPedido.SelectedRows.Count > 0)
            {
                int rowIndex = dgvTipoPedido.SelectedRows[0].Index;
                DataGridViewRow row = dgvTipoPedido.Rows[rowIndex];
             
                string idTipoPedido = row.Cells["IdTipoPedido"].Value.ToString();

                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    bool eliminado = LogTipoPedido.Instancia.EliminarTipoPedido(idTipoPedido);
                    if (eliminado)
                    {
                        ListarTipoPedido();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar");
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero Debe seleccionar");
            }
        }
        private void btnAgregarTipoPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIDTipoPedido.Text) || string.IsNullOrEmpty(txtNombreTipoPedido.Text))
                {
                    MessageBox.Show("Debe ingresar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    EntTipoPedido tipoPedido = new EntTipoPedido();
                    tipoPedido.idTipoPedido = txtIDTipoPedido.Text.Trim();
                    tipoPedido.nombreTipoPedido = txtNombreTipoPedido.Text.Trim();


                    bool agregado = LogTipoPedido.Instancia.AgregarTipoPedido(tipoPedido);
                    if (agregado)
                    {
                        //MessageBox.Show("gregado correctamente");
                        LimpiarDatos();
                        ListarTipoPedido();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el Tipo de Pedido");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificarTipoPedido_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDTipoPedido.Text) && !string.IsNullOrEmpty(txtNombreTipoPedido.Text))
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea modificar este Tipo de Pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    EntTipoPedido tp = new EntTipoPedido();
                    tp.idTipoPedido = txtIDTipoPedido.Text.Trim();
                    tp.nombreTipoPedido = txtNombreTipoPedido.Text.Trim();
                    if (LogTipoPedido.Instancia.ModificarTipoPedido(tp) == true)
                    {
 //                       MessageBox.Show("Tipo de Pedido modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                        ListarTipoPedido();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }


        private void lblTipoPedido_Click(object sender, EventArgs e)
        {
            /**/
        }

        private void FormTipoPedido_Load(object sender, EventArgs e)
        {

        }
        private void dgvTipoPedido_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTipoPedido.SelectedRows.Count > 0)
            {
                int rowIndex = dgvTipoPedido.SelectedRows[0].Index;
                DataGridViewRow row = dgvTipoPedido.Rows[rowIndex];

                txtIDTipoPedido.Text = row.Cells["IdTipoPedido"].Value.ToString();
                txtNombreTipoPedido.Text = row.Cells["NombreTipoPedido"].Value.ToString();
            }

        }
        private void dgvTipoPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIDTipoPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreTipoPedido_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
