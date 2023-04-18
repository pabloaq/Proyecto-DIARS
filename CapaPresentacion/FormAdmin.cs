using MantenedorProducto;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormAdmin : Form
    {

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            formCategoria form = new formCategoria();
            form.TopLevel = false;
            form.Location = new Point((panelPrincipal.Width - form.Width) / 2, (panelPrincipal.Height - form.Height) / 2);
            panelPrincipal.Controls.Add(form);
            form.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormProducto form = new FormProducto();
            form.TopLevel = false;
            form.Location = new Point((panelPrincipal.Width - form.Width) / 2, (panelPrincipal.Height - form.Height) / 2);
            panelPrincipal.Controls.Add(form);
            form.Show();
        }

        private void btnPagoTrabajador_Click(object sender, EventArgs e)
        {
            FormPagoTrabajador form = new FormPagoTrabajador();
            form.TopLevel = false;
            form.Location = new Point((panelPrincipal.Width - form.Width) / 2, (panelPrincipal.Height - form.Height) / 2);
            panelPrincipal.Controls.Add(form);
            form.Show();
        }

        private void btnCategoriaMetodoPago_Click(object sender, EventArgs e)
        {
            FormCategoriaMetodoPago form = new FormCategoriaMetodoPago();
            form.TopLevel = false;
            form.Location = new Point((panelPrincipal.Width - form.Width) / 2, (panelPrincipal.Height - form.Height) / 2);
            panelPrincipal.Controls.Add(form);
            form.Show();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            formComprobantePago form = new formComprobantePago();
            form.TopLevel = false;
            form.Location = new Point((panelPrincipal.Width - form.Width) / 2, (panelPrincipal.Height - form.Height) / 2);
            panelPrincipal.Controls.Add(form);
            form.Show();
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            FormMetodoPago form = new FormMetodoPago();
            form.TopLevel = false;
            form.Location = new Point((panelPrincipal.Width - form.Width) / 2, (panelPrincipal.Height - form.Height) / 2);
            panelPrincipal.Controls.Add(form);
            form.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
