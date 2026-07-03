using BE;
using BLL;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Helpers;

namespace UI
{
    public partial class GestionUsuarios : Form, IObserverIdioma
    {
        UsuarioConexionBLL usuarioBLL = new UsuarioConexionBLL();
        private Usuario usuarioSeleccionado;
        BitacoraBLL bitacoraBLL = new BitacoraBLL();
        private Traductor traductor = new Traductor();
        public GestionUsuarios()
        {
            InitializeComponent();
            ConfigurarVista();

            bitacoraBLL.InsertarBitacora(SessionManagerService.GetInstance.Usuario, "Ingreso al módulo Gestion de Usuarios", "INFO");

            dgvUsuarios.DataSource = usuarioBLL.ObtenerUsuarios();
            dgvUsuarios.Columns["Id"].Visible = false;
            dgvUsuarios.Columns["PasswordHash"].Visible = false;

            dgvUsuarios.Columns["Username"].HeaderText = "Usuario";
            dgvUsuarios.Columns["Email"].HeaderText = "Email";
            dgvUsuarios.Columns["Telefono"].HeaderText = "Teléfono";
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GestorIdiomaService.Instancia.Agregar(this);

        }
        private void ConfigurarVista()
        {
            EstilosUI.ConfigurarFormulario(this);

            this.Size = new Size(1000, 700);

            this.BackgroundImageLayout = ImageLayout.Stretch;

            EstilosUI.ConfigurarLabel(lblUsername);
            EstilosUI.ConfigurarLabel(lblEmail);
            EstilosUI.ConfigurarLabel(lblTelefono);
            EstilosUI.ConfigurarLabel(lblPassword);

            EstilosUI.ConfigurarBotonModificar(btnModificar);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            usuarioSeleccionado = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;

            if (usuarioSeleccionado == null)
                return;

            txtUsername.Text = usuarioSeleccionado.Username;
            txtEmail.Text = usuarioSeleccionado.Email;
            txtTelefono.Text = usuarioSeleccionado.Telefono;
            txtPassword.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario.");

                return;
            }

            usuarioBLL.ModificarUsuario(usuarioSeleccionado.Id,txtUsername.Text,txtPassword.Text,txtEmail.Text,txtTelefono.Text,SessionManagerService.GetInstance.Usuario.Username);

            MessageBox.Show("Usuario modificado correctamente.");

            dgvUsuarios.DataSource = usuarioBLL.ObtenerUsuarios();
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
    }
}
