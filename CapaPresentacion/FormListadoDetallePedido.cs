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
    public partial class FormListadoDetallePedido : Form
    {
        public FormListadoDetallePedido()
        {
            InitializeComponent();
            listaDetallePedido();
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
    }
}
