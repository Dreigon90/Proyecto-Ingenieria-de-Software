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
            EstilosUI.ConfigurarBotonLogout(btnLogout);
            EstilosUI.ConfigurarTituloBienvenida(lblBienvenida);            

            this.Size = new Size(1000, 700);

            this.BackgroundImageLayout = ImageLayout.Stretch;

            EstilosUI.ConfigurarLabel(lblBienvenida);

            EstilosUI.ConfigurarBoton(btnLogout);

            Usuario usuario = SessionManagerService.GetInstance.Usuario;

            lblBienvenida.Text = $"Bienvenido {usuario.Username}";
        }

        private void menuGestionUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pantalla para gestionar usuarios.");
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
    }
}
