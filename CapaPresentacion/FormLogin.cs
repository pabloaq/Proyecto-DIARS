using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
            panel1.Controls.Add(logo);
            logo.Location = new Point(2, 62);
            logo.BackColor = Color.Transparent;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                txtUsername.ForeColor = Color.Silver;
                txtUsername.Text = "Username";
            }   
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                EntUsuario user = new EntUsuario();
                user.username = this.txtUsername.Text.Trim();
                user.contrasenia = this.txtPassword.Text.Trim();
                
                if (logUser.Instancia.validarContrasenia(user.username, user.contrasenia) )
                {
                    switch (logUser.Instancia.obtenerrol(user.username))
                    {
                        case 1:
                            this.Hide();
                            formAdministrador paneladmin = new formAdministrador();
                            paneladmin.ShowDialog();
                            Close();
                            break;
                        case 4:
                            this.Hide();
                            formCajero panelcajero = new formCajero();
                            panelcajero.ShowDialog();
                            Close();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                e.Handled = true;
                btnLogin.PerformClick();
            }
        }
    }
}
