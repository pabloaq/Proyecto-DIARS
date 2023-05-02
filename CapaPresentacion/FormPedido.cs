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
    public partial class FormPedido : Form
    {
        private int cantidadMaxProducto = 15;
        private int cantidadMinProducto = 1;
        private int cantidadProducto = 1;

        public FormPedido()
        {
            InitializeComponent();
            panelDetallePedido.Enabled = false;
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
