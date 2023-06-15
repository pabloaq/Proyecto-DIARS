using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormListadoDetallePedido : Form
    {
        public FormListadoDetallePedido()
        {
            InitializeComponent();
            listaDetallePedido();
            cambiarNombreTablas();
        }

        private void listaDetallePedido()
        {
            dgvDetallePedido.DataSource = LogDetallePedido.Instancia.ListarDetallePedido();
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvDetallePedido.DataSource = LogDetallePedido.Instancia.buscarDetallePedido(txtNombreCliente.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporteDetallePedido rpt = new FormReporteDetallePedido();
            rpt.ShowDialog();
        }

        private void cambiarNombreTablas()
        {
            dgvDetallePedido.Columns["idProducto"].HeaderText = "Codigo de Producto";
            dgvDetallePedido.Columns["idPedido"].HeaderText = "Nombre de Cliente";
            dgvDetallePedido.Columns["cantidad"].HeaderText = "Cantidad";
        }
    }
}
