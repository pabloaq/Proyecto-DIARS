using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace MantenedorProducto
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
            listaProductos();
        }

        private void listaProductos()
        {
            dgv_listaProductos.DataSource = LogProducto.Instancia.ListarProducto();
        }

        private void dgv_listaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgv_listaProductos.Rows[e.RowIndex];

                //cbCategoria.SelectedIndex = int.Parse(filaActual.Cells[1].Value.ToString()) - 1;
                txtIdProducto.Text = filaActual.Cells[0].Value.ToString();
                cbCategoria.Text = filaActual.Cells[1].Value.ToString();
                txtNombre.Text = filaActual.Cells[2].Value.ToString();
                txtStock.Text = filaActual.Cells[3].Value.ToString();
                txtPrecio.Text = filaActual.Cells[4].Value.ToString();
                if (filaActual.Cells[5].Value == null)
                    dt_fechaCaducidad.Value = DateTime.Today;
                else dt_fechaCaducidad.Text = filaActual.Cells[5].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        private void limpiarVariables()
        {
            txtIdProducto.Text = "";
            //cbCategoria.SelectedIndex = 0;
            cbCategoria.Text = "";
            txtNombre.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            dt_fechaCaducidad.Value = DateTime.Today;
            if(!dt_fechaCaducidad.Enabled)
                dt_fechaCaducidad.Enabled = true;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtPrecio.Text != "" && txtStock.Text != "")
                {
                    EntProducto producto = new EntProducto();

                    producto.IdCategoriaProducto = cbCategoria.Text;
                    producto.Nombre = txtNombre.Text;
                    producto.PrecioUnitario = float.Parse(txtPrecio.Text);
                    producto.Stock = int.Parse(txtStock.Text);
                    producto.FechaCaducidad = dt_fechaCaducidad.Value;

                    LogProducto.Instancia.insertarProducto(producto);
                } else
                    MessageBox.Show("Casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listaProductos();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            dt_fechaCaducidad.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtPrecio.Text != "" && txtStock.Text != "")
                {
                    EntProducto producto = new EntProducto();

                    producto.IdProducto = txtIdProducto.Text;
                    producto.IdCategoriaProducto = cbCategoria.Text;
                    producto.Nombre = txtNombre.Text;
                    producto.PrecioUnitario = int.Parse(txtPrecio.Text);
                    producto.Stock = int.Parse(txtStock.Text);
                    producto.FechaCaducidad = dt_fechaCaducidad.Value;

                    LogProducto.Instancia.modificarProducto(producto);
                }
                else
                    MessageBox.Show("Casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listaProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EntProducto producto = new EntProducto();

                producto.IdProducto = txtIdProducto.Text;

                LogProducto.Instancia.eliminarProducto(producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listaProductos();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
        }
    }
}
