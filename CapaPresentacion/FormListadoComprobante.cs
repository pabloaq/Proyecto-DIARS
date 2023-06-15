using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormListadoComprobante : Form
    {
        public FormListadoComprobante()
        {
            InitializeComponent();
            listaComprobante();
            cambiarNombresTabla();
        }



        private void listaComprobante()
        {
            dgvComprobante.DataSource = LogComprobante.Instancia.ListarComprobante();
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvComprobante.DataSource = LogComprobante.Instancia.buscarComprobante(txtNombreCliente.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporteComprobante rpt = new FormReporteComprobante();
            rpt.ShowDialog();
        }

        private void cambiarNombresTabla()
        {
            dgvComprobante.Columns["IdComprobante"].HeaderText = "Codigo Comprobante";
            dgvComprobante.Columns["PedidoID"].HeaderText = "Nombre de Cliente";
            dgvComprobante.Columns["MetodopagoID"].HeaderText = "Metodo de pago";
            dgvComprobante.Columns["montoTotal"].HeaderText = "Monto Total";
            dgvComprobante.Columns["FechaRegistro"].HeaderText = "Fecha de Registro";
        }
    }
}
