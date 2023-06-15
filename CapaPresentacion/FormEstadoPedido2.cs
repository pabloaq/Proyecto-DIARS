using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace CapaPresentacion
{
    public partial class FormEstadoPedido2 : Form
    {
        private LogPedido logPedido;
         //private List<EntPedido> pedidosPagados;

        public FormEstadoPedido2()
        {
            InitializeComponent();
            logPedido = new LogPedido();
          
        }

        private void FormEstadoPedido2_Load_1(object sender, EventArgs e)
        {
            CargarPedidosPagados();
           
        }
        private void CargarPedidosPagados()
        {
            try
            {
                List<EntPedido> pedidosPagados = LogPedido.Instancia.ListarPedidosPagados();
                // Enlazar la lista al DataGridView de pedidos pagados
                dgvPedidosPagados.DataSource = pedidosPagados;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pedidos pagados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvPedidosPagados.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvPedidosPagados.SelectedRows[0];
                    string idPedido = selectedRow.Cells["IdPedido"].Value.ToString();
                    bool actualizado = logPedido.CambiarEstadoPedido(idPedido, "E");
                    if (actualizado)
                    {
                        MessageBox.Show("Estado del pedido actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPedidosPagados();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el estado del pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex){
                    MessageBox.Show("Error al cambiar el estado del pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pedido de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //private void btnPedidosEntregados_Click(object sender, EventArgs e)
        //{
        //    FormPedidosEntregados formPedidosEntregados = new FormPedidosEntregados();
        //    formPedidosEntregados.Show();
        //}       
        /*
        public void MostrarDetallePedido(string idPedido)
        {
            try
            {
                List<EntDetallePedido> detallePedido = LogDetallePedido.Instancia.BuscarDetallePedidoID(idPedido); // Obtener el detalle del pedido
                FormDetallePedidoCocina formDetallePedidoCocina = new FormDetallePedidoCocina();
                formDetallePedidoCocina.Show();
                // Asignar el detalle al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle del pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
        
        private void dgvDetallePedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        public void dgvPedidosPagados_SelectionChanged(object sender, EventArgs e)
        {
            /*
                if (dgvPedidosPagados.SelectedRows.Count > 0) // Verificar si se ha seleccionado un pedido
                {
                    string idPedido = dgvPedidosPagados.SelectedRows[0].Cells["idPedido"].Value.ToString();
                  
                    MostrarDetallePedido(idPedido); // Mostrar el detalle del pedido seleccionado
                }
            */

        }

        private void btnActualizarPedido_Click(object sender, EventArgs e)
        {
            CargarPedidosPagados();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetallePedidosEntregados_Click(object sender, EventArgs e)
        {
            if (dgvPedidosPagados.SelectedRows.Count > 0)
            {
                // Obtener el pedido seleccionado
                EntPedido pedidoSeleccionado = (EntPedido)dgvPedidosPagados.SelectedRows[0].DataBoundItem;

                // Abrir el formulario de detalle de pedido pasando el pedido seleccionado
                FormDetallePedidoCocina formDetallePedidoCocina = new FormDetallePedidoCocina(pedidoSeleccionado);
                formDetallePedidoCocina.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un pedido de la lista.");
            }
        }
    }

}
