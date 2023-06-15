using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormComprobante : Form
    {
        List<EntPedido> listaPedido = LogPedido.Instancia.ListarRegistrados();
        List<EntMetodoPago> listaMetodoPago = LogMetodoPago.Instancia.ListarMetodoPago();
        public FormComprobante()
        {
            InitializeComponent();
            listarCmbPedido();
            listarCmbMetodoPago();
            MostrarDatosAdicionales();
            cbxIdPedido.DropDownStyle = ComboBoxStyle.DropDownList;//Evita que el usuario pueda modificar el cuadro de texto
            cbxMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;//Evita que el usuario pueda modificar el cuadro de texto
        }

        private void listarCmbPedido()
        {
            foreach (EntPedido pedio in listaPedido)
            {
                cbxIdPedido.Items.Add(pedio.nombreCliente);
            }
        }

        private void listarCmbMetodoPago()
        {
            foreach (EntMetodoPago metodoPago in listaMetodoPago)
            {
                cbxMetodoPago.Items.Add(metodoPago.nombre);
            }
        }

        private EntPedido buscarPedidoPorNombreCliente(string nombre)
        {
            foreach (EntPedido pedido in listaPedido)
            {
                if (pedido.nombreCliente == nombre)
                    return pedido;
            }
            return null;
        }

        private EntMetodoPago buscarMetodoPagoPorNombre(string nombre)
        {
            foreach (EntMetodoPago metodoPago in listaMetodoPago)
            {
                if (metodoPago.nombre == nombre)
                    return metodoPago;
            }
            return null;
        }

        private void MostrarDatosAdicionales()
        {
            lbFechaDePago.Text = DateTime.Today.ToString();
        }

        private void btnRealizarComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                EntComprobante comprobante = new EntComprobante();
                comprobante.PedidoID = buscarPedidoPorNombreCliente(cbxIdPedido.Text).idPedido;
                comprobante.MetodopagoID = buscarMetodoPagoPorNombre(cbxMetodoPago.Text).idMetodoPago;
                comprobante.montoTotal = float.Parse(txtTotal.Text);

                lbMontoTotal.Text = Convert.ToString(LogComprobante.Instancia.VerificarMontoTotal(comprobante));

                if (comprobante.montoTotal ==  LogComprobante.Instancia.VerificarMontoTotal(comprobante))
                {
                    MessageBox.Show("Monto total ha sido verificado correctamente");
                    LogComprobante.Instancia.InsertarDatosComprobante(comprobante);
                    EntPedido pedido = new EntPedido();
                    MessageBox.Show("Comprobante generado correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("El monto ingresado no coincide con el monto de su pedido");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el comprobante" + ex);
            }
        }

        private void cbxIdPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntComprobante comprobante = new EntComprobante();
            comprobante.PedidoID = buscarPedidoPorNombreCliente(cbxIdPedido.Text).idPedido;
            lbMontoTotal.Text = LogComprobante.Instancia.VerificarMontoTotal(comprobante).ToString();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
