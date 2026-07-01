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
    public partial class Auditoria : Form
    {
        Admin admin;
        UsuarioConexionBLL conexion = new UsuarioConexionBLL();
        AuditoriaBLL audit = new AuditoriaBLL();
        BitacoraBLL bitacoraBLL = new BitacoraBLL();
        public Auditoria(Admin admin)
        {
            InitializeComponent();
            ConfigurarVista();

            this.admin = admin;
            bitacoraBLL.InsertarBitacora(SessionManagerService.GetInstance.Usuario, "Ingreso al módulo de Auditoría", "INFO");


        }
        private void ConfigurarVista()
        {
            EstilosUI.ConfigurarFormulario(this);

            this.Size = new Size(1000, 700);

            this.BackgroundImageLayout = ImageLayout.Stretch;

            EstilosUI.AplicarTituloBlanco(groupBox1);
            EstilosUI.AplicarTituloBlanco(groupBox2);
            EstilosUI.ConfigurarBoton(btnEstadoAnterior);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Usuario usuario = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;

            if (usuario == null)
                return;

            dgvUsuarioHistorial.DataSource = audit.ObtenerHistorial(usuario.Id);
            ConfigurarGrillaAuditoria();
        }

        private void Auditoria_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnEstadoAnterior_Click(object sender, EventArgs e)
        {
            if (dgvUsuarioHistorial.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un estado.");

                return;
            }

            UsuarioMemento memento =(UsuarioMemento)dgvUsuarioHistorial.SelectedRows[0].DataBoundItem;

            audit.Revertir(memento.IdAuditoria);

            CargarUsuarios();

            dgvUsuarioHistorial.DataSource = audit.ObtenerHistorial(memento.UsuarioId);

            ConfigurarGrillaAuditoria();

            MessageBox.Show("Email restaurado correctamente.");
        }
        private void ConfigurarGrillaUsuarios()
        {
            dgvUsuarios.Columns["Id"].Visible = false;
            dgvUsuarios.Columns["PasswordHash"].Visible = false;
            dgvUsuarios.Columns["Username"].HeaderText = "Usuario";
            dgvUsuarios.Columns["Email"].HeaderText = "Email";
            dgvUsuarios.Columns["Telefono"].HeaderText = "Teléfono";
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigurarGrillaAuditoria()
        {
            dgvUsuarioHistorial.Columns["IdAuditoria"].Visible = false;
            dgvUsuarioHistorial.Columns["UsuarioId"].Visible = false;
            dgvUsuarioHistorial.Columns["Accion"].Visible = false;
            dgvUsuarioHistorial.Columns["EmailAnterior"].HeaderText = "Email anterior";
            dgvUsuarioHistorial.Columns["EmailActual"].HeaderText = "Email actual";
            dgvUsuarioHistorial.Columns["ModificadoPor"].HeaderText = "Modificado por";
            dgvUsuarioHistorial.Columns["Fecha"].HeaderText = "Fecha";


            dgvUsuarioHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = conexion.ObtenerUsuarios();

            ConfigurarGrillaUsuarios();
        }
    }
}
