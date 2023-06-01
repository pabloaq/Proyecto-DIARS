using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MantenedorProducto;

namespace CapaPresentacion
{
    public partial class formAdministrador : Form
    {
        public formAdministrador()
        {
            InitializeComponent();
        }
        #region FuncionesBarra
        private void ptnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ptnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptnMax.Visible = false;
            ptnMin.Visible = true;
        }

        private void ptnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptnMin.Visible = false;
            ptnMax.Visible = true;
        }
        private void ptnBack_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            Hide();
            form.ShowDialog();
            Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion
        //Mostrar Formularios dentro de panel escritorio
        private void AbrirForm<Formulario>() where Formulario : Form, new()
        {
            Form formulario;
            formulario = panelEscritorio.Controls.OfType<Formulario>().FirstOrDefault();//Busca el fomulario
            //Busca un formulario inexistente
            if (formulario == null)
            {
                formulario = new Formulario();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                panelEscritorio.Controls.Add(formulario);
                formulario.Dock = DockStyle.Fill;
                panelEscritorio.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CerrarForm);
            }
            //En caso exista lo traemos al frente
            else
            {
                formulario.BringToFront();
            }
        }
        //metodo para cuando se cierren los formulario
        private void CerrarForm(object sender, FormClosedEventArgs e)//250; 163; 7
        {
            if (Application.OpenForms["FormRegistroUsuario"] == null)
                btnRegistrar.BackColor = Color.FromArgb(250, 163, 7);
            if (Application.OpenForms["FormCategoriaProducto"] == null)
                btnCatProduct.BackColor = Color.FromArgb(250, 163, 7);
            if (Application.OpenForms["FormProducto"] == null)
                btnProducto.BackColor = Color.FromArgb(250, 163, 7);
            if (Application.OpenForms["FormCategoriaMetodoPago"] == null)
                btnCatMetodo.BackColor = Color.FromArgb(250, 163, 7);
            if (Application.OpenForms["FormMetodoPago"] == null)
                btnMetodo.BackColor = Color.FromArgb(250, 163, 7);
            if (Application.OpenForms["FormListadoComprobante"] == null && Application.OpenForms["FormListadoDetallePedido"] == null)
            {
                btnReportes.BackColor = Color.FromArgb(250, 163, 7);
            }
                
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirForm<FormRegistroUsuario>();
            btnRegistrar.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnCatProduct_Click(object sender, EventArgs e)
        {
            AbrirForm<FormCategoriaProducto>();
            btnCatProduct.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirForm<FormProducto>();
            btnProducto.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnCatMetodo_Click(object sender, EventArgs e)
        {
            AbrirForm<FormCategoriaMetodoPago>();
            btnCatMetodo.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            AbrirForm<FormMetodoPago>();
            btnMetodo.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            subReport.Visible = true;
            btnReportes.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void panelBARRA_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            subReport.Visible = false;
            AbrirForm<FormListadoComprobante>();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            subReport.Visible = false;
            AbrirForm<FormListadoDetallePedido>();
        }
    }

}
