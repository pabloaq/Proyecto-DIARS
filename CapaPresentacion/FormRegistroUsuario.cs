using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FormRegistroUsuario : Form
    {
        APIDNI apidni = new APIDNI();
        List<EntRol> listarol = logUser.Instancia.ListarRoles();
        public FormRegistroUsuario()
        {
            
            InitializeComponent();
            listarRoles();
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormRegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            try {
                if (txtDNI.Text.Length == 8)
                {
                    dynamic respuesta = apidni.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDNI.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImtnYXJjaWFtaXJAZ21haWwuY29tIn0.DmnmjodKhFK8W0vDUGg6vHgpgqDK1Qa1hFJZ82k-SCo");
                    string text = respuesta.nombres.ToString()+" "+ respuesta.apellidoPaterno.ToString()+ " "+ respuesta.apellidoMaterno.ToString();
                    MessageBox.Show(text);
                }
                else {
                    string text = "DNI invalido.Ingrese otro DNI";
                    MessageBox.Show(text);
                }
                
            } catch {
                string text = "DNI invalido.Ingrese otro DNI";
                MessageBox.Show(text);
            }
            
        }
        private void listarRoles()
        {
            foreach (EntRol rol in listarol)
            {
                cmbRol.Items.Add(rol.rolname);
            }
        }
        
        private EntRol buscarRolPorNombre(string nombre)
        {
            
            foreach (EntRol rol in listarol)
            {
                if (rol.rolname == nombre)
                    return rol;
            }
            return null;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (txtUsername.Text != "" && txtPassword.Text != "" && txtPassword.Text != "" && txtDNI.Text.Length == 8)
                    {
                        if (txtPassword.Text == txtCONPassword.Text) {
                            EntUsuario user = new EntUsuario();

                            user.username = txtUsername.Text;
                            user.contrasenia = txtPassword.Text;
                            user.dni = txtDNI.Text;
                            user.rol = buscarRolPorNombre(cmbRol.Text).idrol;
                            dynamic respuesta = apidni.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDNI.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImtnYXJjaWFtaXJAZ21haWwuY29tIn0.DmnmjodKhFK8W0vDUGg6vHgpgqDK1Qa1hFJZ82k-SCo");
                            user.apellido = respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();
                            user.nombres = respuesta.nombres;
                            logUser.Instancia.registrarUsuario(user);
                            MessageBox.Show("El usuario se registro correctamente.");
                        }
                        else
                            MessageBox.Show("La contraseña no coincide");
                    }
                    else
                        MessageBox.Show("Casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNI invalido.Ingrese otro DNI");
            }
            //limpiarVariables();
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
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
        private void txtCONPassword_Enter(object sender, EventArgs e)
        {
            if (txtCONPassword.Text == "Confirmación Password")
            {
                txtCONPassword.Text = "";
                txtCONPassword.ForeColor = Color.Silver;
                txtCONPassword.UseSystemPasswordChar = true;
            }
        }
        private void txtCONPassword_Leave(object sender, EventArgs e)
        {
            if (txtCONPassword.Text == "")
            {
                txtCONPassword.Text = "Confirmación Password";
                txtCONPassword.ForeColor = Color.Silver;
                txtCONPassword.UseSystemPasswordChar = false;
            }
        }
        private void txtDNI_Enter(object sender, EventArgs e)
        {
            if (txtDNI.Text == "DNI")
            {
                txtDNI.Text = "";
                txtDNI.ForeColor = Color.Silver;
            }
        }
        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                txtDNI.Text = "DNI";
                txtDNI.ForeColor = Color.Silver;
            }
        }
    }
}
