using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Services;
using UI.Helpers;

namespace UI
{
    public partial class Form1 : Form
    {
        UsuarioConexionBLL usuarioConexionBLL = new UsuarioConexionBLL();
        BitacoraBLL bitacoraBLL = new BitacoraBLL();
        public string usuario;
        public string password;
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            this.AcceptButton = btnLogin;
            EstilosUI.ConfigurarFormulario(this);

            EstilosUI.ConfigurarTextBox(txtUsuario);
            EstilosUI.ConfigurarTextBox(txtPassword);

            EstilosUI.ConfigurarBoton(btnLogin);

            EstilosUI.ConfigurarLabel(lblUsuario);
            EstilosUI.ConfigurarLabel(lblPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            try { 
                if (ValidarIngresoDeCampos()) {
                    usuario = txtUsuario.Text;
                    password = txtPassword.Text;

                    Usuario usu = usuarioConexionBLL.ValidarUsuario(usuario, password);

                    if (usu != null) {
                        MessageBox.Show("Bienvenido");

                        SessionManagerBLL.Login(usu);

                        bitacoraBLL.InsertarBitacora(SessionManagerBLL.GetInstance.Usuario,"Ingreso de usuario");

                        //new Admin(this).Show();
                        this.Hide();
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private bool ValidarIngresoDeCampos() {
            usuario = txtUsuario.Text.Trim();
            password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Debe completar usuario y contraseña.");
                return false;
            }

            return true;
        }

    }
}
