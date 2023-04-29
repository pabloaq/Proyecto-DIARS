using CapaEntidad;
using CapaLogica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FormPedido : Form
    {
        private int cantidadMaxProducto = 15;
        private int cantidadMinProducto = 1;
        private int cantidadProducto = 1;

        public FormPedido()
        {
            InitializeComponent();
            listarComboBoxTipoPedido();       
            listarComboBoxProducto();
            panelDetallePedido.Enabled = false;
        }

        private void listarComboBoxTipoPedido()
        {
            List<EntTipoPedido> lista = LogTipoPedido.Instancia.ListarTipoPedido();

            foreach(EntTipoPedido tipoPedido in lista)
            {
                cmbTipoPedido.Items.Add(tipoPedido.nombreTipoPedido);
            }
        }

        private void listarComboBoxProducto()
        {
            List<EntProducto> lista = LogProducto.Instancia.ListarProducto();

            foreach (EntProducto producto in lista)
            {
                cmbProducto.Items.Add(producto.Nombre);
            }
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            if (cantidadProducto < cantidadMaxProducto)
            {
                cantidadProducto++;
                lbCantidadProducto.Text = cantidadProducto.ToString();
            }
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            if (cantidadProducto > cantidadMinProducto)
            {
                cantidadProducto--;
                lbCantidadProducto.Text = cantidadProducto.ToString();
            }
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {

            panelDetallePedido.Enabled = true;
            panelPedido.Enabled = false;
        }

        private void cmbTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPedido.Text == "delivery")
            {
                txtDireccionPedido.Enabled = true;
            } else txtDireccionPedido.Enabled = false;
        }
    }
}
