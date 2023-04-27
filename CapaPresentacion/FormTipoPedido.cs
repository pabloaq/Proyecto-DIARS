using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
namespace CapaPresentacion
{
    public partial class FormTipoPedido : Form
    {
        public FormTipoPedido()
        {
            InitializeComponent();
            ListarTipoPedido();
        }
        public void ListarTipoPedido()
        {
            dgvTipoPedido.DataSource = LogTipoPedido.Instancia.ListarTipoPedido();
        }


        private void btnEliminarTipoPedido_Click(object sender, EventArgs e)
        {

        }

        private void dgvTipoPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIDTipoPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreTipoPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarTipoPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarTipoPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
        private void lblTipoPedido_Click(object sender, EventArgs e)
        {
            /**/
        }

        private void FormTipoPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
