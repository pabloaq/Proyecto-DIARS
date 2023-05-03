using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MantenedorProducto;

namespace CapaPresentacion
{
    public partial class formCajero : Form
    {
        public formCajero()
        {
            InitializeComponent();
        }
        #region Funcionalidades
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible=true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        //Mostrar Formularios dentro de panel escritorio
        private void AbrirForm<Formulario>() where Formulario : Form, new()
        {
            Form formulario;
            formulario = panelEscritorio.Controls.OfType<Formulario>().FirstOrDefault();//Busca el fomulario
            //Busca un formulario inexistente
            if(formulario == null)
            {
                formulario = new Formulario();
                formulario.TopLevel = false;
                panelEscritorio.Controls.Add(formulario);
                //formulario.Dock = DockStyle.Fill;
                panelEscritorio.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //En caso exista lo traemos al frente
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            AbrirForm<FormPedido>();
        }

        private void nameTitulo_Click(object sender, EventArgs e)
        {

        }
        private void btnComprobante_Click(object sender, EventArgs e)
        {
            AbrirForm<formComprobantePago>();
        }

        private void btnTipoPedido_Click(object sender, EventArgs e)
        {
            AbrirForm<FormTipoPedido>();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirForm<FormProducto>();
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            AbrirForm<FormCategoriaMetodoPago>();
        }

        private void btnCategoriaMetPag_Click(object sender, EventArgs e)
        {
            AbrirForm<FormMetodoPago>();
        }
    }
}
