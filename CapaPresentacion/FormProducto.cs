using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MantenedorProducto
{
    public partial class FormProducto : Form
    {
        List<EntCategoriaProducto> listaCategoriaProducto = LogCategoriaProducto.Instancia.ListarCategoriaProducto();

        public FormProducto()
        {
            InitializeComponent();
            listaProductos();
            listarCategoriaProducto();
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;//Evita que el usuario pueda modificar el cuadro de texto
        }

        private void listaProductos()
        {
            dgv_listaProductos.DataSource = LogProducto.Instancia.ListarProducto();
        }

        private void listarCategoriaProducto()
        {
            foreach (EntCategoriaProducto categoriaProducto in listaCategoriaProducto)
            {
                cmbCategoria.Items.Add(categoriaProducto.nombre);
            }
        }

        private EntCategoriaProducto buscarCategoriaPorNombre(string nombre)
        {
            EntCategoriaProducto valor = new EntCategoriaProducto();
            foreach (EntCategoriaProducto categoria in listaCategoriaProducto)
            {
                if (categoria.nombre == nombre)
                   valor  = categoria;
            }
            return valor;
        }

        private void dgv_listaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgv_listaProductos.Rows[e.RowIndex];

                txtIdProducto.Text = filaActual.Cells[0].Value.ToString();
                foreach (EntCategoriaProducto categoria in listaCategoriaProducto)
                {
                    if (filaActual.Cells[1].Value.ToString() == categoria.idCategoriaProducto)
                        cmbCategoria.Text = categoria.nombre;
                }
                txtNombre.Text = filaActual.Cells[2].Value.ToString();
                txtStock.Text = filaActual.Cells[3].Value.ToString();
                txtPrecio.Text = filaActual.Cells[4].Value.ToString();
                dt_fechaCaducidad.Value = DateTime.Parse(filaActual.Cells[5].Value.ToString());
            }
            catch (System.ArgumentOutOfRangeException) //controla la exepcion de los valores minimos de la fecha de dataTimerPicker
            {
                dt_fechaCaducidad.Value = DateTime.Today;
            }
        }

        private void limpiarVariables()
        {
            txtIdProducto.Text = "";
            cmbCategoria.SelectedIndex = -1;
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

                    //producto.IdCategoriaProducto = cmbCategoria.Text;
                    producto.IdCategoriaProducto = buscarCategoriaPorNombre(cmbCategoria.Text).idCategoriaProducto;
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

                    //producto.IdProducto = txtIdProducto.Text;
                    producto.IdProducto = txtIdProducto.Text;
                    producto.IdCategoriaProducto = buscarCategoriaPorNombre(cmbCategoria.Text).idCategoriaProducto;
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
