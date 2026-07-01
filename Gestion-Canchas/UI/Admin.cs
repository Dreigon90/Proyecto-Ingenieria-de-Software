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

namespace UI
{
    public partial class Admin : Form
    {
        BitacoraBLL bitacoraBLL = new BitacoraBLL();

        public Admin()
        {
            InitializeComponent();
            ConfigurarVista();
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

            usuarioMenu.DropDownItems.Add(logout);
            menuStrip1.Items.Add(usuarioMenu);


        }

        private void menuGestionUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuarios form = new GestionUsuarios();

            form.MdiParent = this;

            form.WindowState = FormWindowState.Maximized;

            form.Show();
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

            MessageBox.Show("Sesión cerrada");

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
    }
}
