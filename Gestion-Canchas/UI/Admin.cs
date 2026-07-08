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
using FontAwesome.Sharp;
using UI.GestionPermisos;
using BE.Composite;

namespace UI
{
    public partial class Admin : Form, IObserverIdioma
    {
        BitacoraBLL bitacoraBLL = new BitacoraBLL();
        private Traductor traductor = new Traductor();

        public bool IntegridadCorrecta { get; set; } = true; // Atributo para validación de integridad

        public Admin()
        {
            InitializeComponent();
            ConfigurarVista();
            GestorIdiomaService.Instancia.Agregar(this);

            ValidarMenus();
        }
        private void ConfigurarVista()
        {
            EstilosUI.ConfigurarFormulario(this);
            EstilosUI.ConfigurarMenu(menuStrip1);         

            this.Size = new Size(1000, 700);

            this.BackgroundImageLayout = ImageLayout.Stretch;
            Usuario usuario = SessionManagerService.GetInstance.Usuario;
            IconMenuItem usuarioMenu = new IconMenuItem();
            usuarioMenu.Text = usuario.Username;
            usuarioMenu.IconChar = IconChar.CircleUser;
            usuarioMenu.IconColor = Color.White;
            usuarioMenu.IconFont = IconFont.Auto;
            usuarioMenu.Alignment = ToolStripItemAlignment.Right;

            IconMenuItem logout = new IconMenuItem();
            logout.Text = "Cerrar sesión";
            logout.IconChar = IconChar.RightFromBracket;
            logout.IconColor = Color.Black;
            logout.IconFont = IconFont.Auto;
            logout.Click += btnLogout_Click;
            logout.Tag = "menuLogout";

            usuarioMenu.DropDownItems.Add(logout);
            menuStrip1.Items.Add(usuarioMenu);

            GestorIdiomaService.Instancia.Agregar(this);

        }

        private void canchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pantalla para gestionar canchas.");
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pantalla para gestionar reservas.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            bitacoraBLL.InsertarBitacora(SessionManagerService.GetInstance.Usuario, "Cierre de sesión", "INFO");
            
            SessionManagerService.Logout();

            //MessageBox.Show("Sesión cerrada");

            Form1 login = new Form1();

            login.Show();

            this.Close();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora form = new Bitacora();
            form.MdiParent = this; // Vincula el form como hijo del contenedor
            form.Show();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auditoria auditoria = new Auditoria(this);
            auditoria.MdiParent = this; // Vincula el form como hijo del contenedor
            auditoria.Show();
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

        private void permisosYFamiliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPermisosFamilias formPermisosFamilias = new FormPermisosFamilias(this);
            formPermisosFamilias.Show();
            this.Hide();
        }

        private void rolesYUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuariosRoles formUsuariosRoles = new FormUsuariosRoles(this);
            formUsuariosRoles.Show();
            this.Hide();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUsuarios form = new GestionUsuarios();

            form.MdiParent = this;

            form.WindowState = FormWindowState.Maximized;

            form.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            btnRecalcularDV.Visible = false;

            if (!IntegridadCorrecta)
            {
                if (SessionManagerService.GetInstance.TienePermiso(TipoPermiso.RecalcularDV))
                {
                    btnRecalcularDV.Visible = true;

                    MessageBox.Show(
                        "Se detectó una alteración en la integridad de la tabla Usuario.\nComo administrador puede recalcular los dígitos verificadores.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    btnRecalcularDV.Visible = false;

                    MessageBox.Show(
                        "Se detectó una alteración en la integridad de la tabla Usuario.\nComunicarse con un administrador.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void ValidarMenus()
        {
            //// Validacion de todos los menus
            //foreach (ToolStripItem item in menuStrip1.Items)
            //{
            //    if (item is ToolStripMenuItem menu)
            //    {
            //        ValidarMenuPorItem(menu);
            //    }
            //}

            // Validacion de menus controlada
            MenuItemsEnDisabled(menuGestionUsuarios);
            ValidarMenuPorItem(menuGestionUsuarios);
        }

        public void MenuItemsEnDisabled(ToolStripMenuItem menuitem)
        {
            foreach (ToolStripDropDownItem menudownitem in menuitem.DropDownItems)
            {
                menudownitem.Enabled = false;
            }
        }

        // Validación de permisos del usuario vs permiso del menu-AccessibleName
        private void ValidarMenuPorItem(ToolStripMenuItem menu)
        {
            if (!string.IsNullOrWhiteSpace(menu.AccessibleName))
            {
                TipoPermiso permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso),menu.AccessibleName);

                menu.Enabled = SessionManagerService.GetInstance.TienePermiso(permiso);
            }

            foreach (ToolStripItem item in menu.DropDownItems)
            {
                if (item is ToolStripMenuItem submenu)
                {
                    ValidarMenuPorItem(submenu); // Recursividad
                }
            }
        }

        private void btnRecalcularDV_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Integridad.DigitoVerificadorBLL bll = new BLL.Integridad.DigitoVerificadorBLL();

                bll.RecalcularIntegridad();

                MessageBox.Show("Los dígitos verificadores fueron recalculados correctamente.", "Integridad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnRecalcularDV.Visible = false;

                IntegridadCorrecta = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
