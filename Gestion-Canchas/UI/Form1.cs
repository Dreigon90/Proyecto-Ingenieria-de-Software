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
using BLL.Integridad;
using Services;
using UI.Helpers;

namespace UI
{
    public partial class Form1 : Form, IObserverIdioma
    {
        UsuarioConexionBLL usuarioConexionBLL = new UsuarioConexionBLL();
        BitacoraBLL bitacoraBLL = new BitacoraBLL();
        IdiomaBLL idiomaBLL = new IdiomaBLL();
        public string usuario;
        public string password;
        private Traductor traductor = new Traductor();
        private bool isInitializingComboBox = false;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(900, 600);
            txtPassword.UseSystemPasswordChar = true;
            this.AcceptButton = btnLogin;
            EstilosUI.ConfigurarFormulario(this);
            EstilosUI.ConfigurarPanel(panelLogin);
            EstilosUI.ConfigurarTextBox(txtUsuario);
            EstilosUI.ConfigurarTextBox(txtPassword);

            EstilosUI.ConfigurarBoton(btnLogin);

            EstilosUI.ConfigurarTitulo(lblTitulo);
            EstilosUI.ConfigurarTitulo(lblLogin);

            EstilosUI.ConfigurarLabel(lblUsuario);
            EstilosUI.ConfigurarLabel(lblPassword);
            EstilosUI.ConfigurarLabel(lblIdioma);

            GestorIdiomaService.Instancia.Agregar(this);
            //GestorIdiomaService.Instancia.CambiarIdioma( new Idioma() {Id = 1,Nombre = "Español" });
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            try { 
                if (ValidarIngresoDeCampos()) {
                    usuario = txtUsuario.Text;
                    password = txtPassword.Text;

                    Usuario usu = usuarioConexionBLL.ValidarUsuario(usuario, password);

                    if (usu != null) {

                        SessionManagerService.Login(usu);
                        
                        Idioma idiomaSeleccionado = (Idioma)cmbIdioma.SelectedItem;
                        usuarioConexionBLL.ActualizarIdioma(usu.Id,idiomaSeleccionado.Id);
                        usu.IdIdioma = idiomaSeleccionado.Id;

                        bitacoraBLL.InsertarBitacora(SessionManagerService.GetInstance.Usuario,"Ingreso de usuario", "INFO");
                        
                        Idioma idioma = idiomaBLL.ObtenerIdiomas().First(i => i.Id == usu.IdIdioma);
                        GestorIdiomaService.Instancia.CambiarIdioma(idioma);
                        cmbIdioma.SelectedValue = usu.IdIdioma;

                        Admin admin = new Admin();
                        admin.Show();
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

        public void Actualizar(Idioma idioma)
        {
            traductor.TraducirFormulario(this, idioma);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            GestorIdiomaService.Instancia.Quitar(this);

            base.OnFormClosed(e);
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdioma.SelectedItem == null)
                return;

            Idioma idioma = (Idioma)cmbIdioma.SelectedItem;

            GestorIdiomaService.Instancia.CambiarIdioma(idioma);
        }
        private void LlenarComboIdiomas()
        {
            isInitializingComboBox = true;

            var idiomas = idiomaBLL.ObtenerIdiomas();
            cmbIdioma.DataSource = idiomas;
            cmbIdioma.DisplayMember = "Nombre";
            cmbIdioma.ValueMember = "Id";
            cmbIdioma.SelectedIndex = 1;

            // Usar idioma actual si está definido
            Idioma idiomaActual = GestorIdiomaService.Instancia.IdiomaActual;

            if (idiomaActual != null)
            {
                cmbIdioma.SelectedItem = idiomas.FirstOrDefault(i => i.Id == idiomaActual.Id);
            }
            else
            {
                var idiomaPorDefecto = idiomas.FirstOrDefault(i => i.Nombre.ToLower() == "español");
                if (idiomaPorDefecto != null)
                {
                    cmbIdioma.SelectedItem = idiomaPorDefecto;
                    GestorIdiomaService.Instancia.CambiarIdioma(idiomaPorDefecto);
                }

                isInitializingComboBox = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarComboIdiomas();

            // PRUEBA CALCULO Y VERIFICACIÓN DIGITO VERIFICADOR
            DigitoVerificadorBLL bll = new DigitoVerificadorBLL();
            bll.RecalcularIntegridad();
            MessageBox.Show("DVH y DVV recalculados correctamente.");
            //bool resultado = bll.VerificarDVHUsuarios();
            //MessageBox.Show(resultado.ToString());

        }
    }
}
