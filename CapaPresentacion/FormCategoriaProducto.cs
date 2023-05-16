using CapaEntidad;
using CapaLogica;
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
    public partial class FormCategoriaProducto : Form
    {
        public FormCategoriaProducto()
        {
            InitializeComponent();
            listarCategoriaProducto();
        }

        private void listarCategoriaProducto()
        {
            dgvCategoriaProducto.DataSource = LogCategoriaProducto.Instancia.ListarCategoriaProducto();
        }
        
        private void limpiarEntradas()
        {
            txtIdCateProducto.Text = "";
            txtNombre.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    EntCategoriaProducto catProducto = new EntCategoriaProducto();

                    catProducto.nombre = txtNombre.Text;

                    LogCategoriaProducto.Instancia.insertarCategoriaProducto(catProducto);
                }
                else
                    MessageBox.Show("Casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarEntradas();
            listarCategoriaProducto();
        }

        private void dgvCategoriaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCategoriaProducto.Rows[e.RowIndex];

            txtIdCateProducto.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    EntCategoriaProducto catProducto = new EntCategoriaProducto();

                    catProducto.idCategoriaProducto = txtIdCateProducto.Text;
                    catProducto.nombre = txtNombre.Text;

                    LogCategoriaProducto.Instancia.modificarCategoriaProducto(catProducto);
                }
                else
                    MessageBox.Show("Casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarEntradas();
            listarCategoriaProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCateProducto.Text != "")
                {
                    EntCategoriaProducto catProducto = new EntCategoriaProducto();

                    catProducto.idCategoriaProducto = txtIdCateProducto.Text;
                    catProducto.idCategoriaProducto = txtIdCateProducto.Text;

                    LogCategoriaProducto.Instancia.eliminarCategoriaProducto(catProducto);
                }
                else
                    MessageBox.Show("Casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarEntradas();
            listarCategoriaProducto();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
