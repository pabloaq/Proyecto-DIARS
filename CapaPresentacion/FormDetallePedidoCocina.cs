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
    public partial class FormDetallePedidoCocina : Form
    {
        private EntPedido pedidoSeleccionado;
        private List<EntDetallePedido> detallesPedido;
      


        public FormDetallePedidoCocina(EntPedido pedido)
        {
            InitializeComponent();
            pedidoSeleccionado = pedido;
            detallesPedido = new List<EntDetallePedido>();
            lblPedido.Text = pedidoSeleccionado.idPedido.ToString();
        }

        private void CargarDetallePedido()
        {
            detallesPedido = LogDetallePedido.Instancia.BuscarDetallePedidoID(pedidoSeleccionado.idPedido);
            dgvDetallePedidos.DataSource = detallesPedido;
        }
        private void FormDetallePedidoCocina_Load(object sender, EventArgs e)
        {
            CargarDetallePedido();
        }

       

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPedido_Click(object sender, EventArgs e)
        {

        }
    }
}
