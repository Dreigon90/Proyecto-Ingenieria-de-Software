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
    public partial class Bitacora : Form, IObserverIdioma
    {
        BitacoraBLL bitacoraBLL = new BitacoraBLL();
        private Traductor traductor = new Traductor();
        public Bitacora()
        {
            InitializeComponent();

            ConfigurarVista();

            bitacoraBLL.InsertarBitacora(SessionManagerService.GetInstance.Usuario, "Ingreso al módulo Bitácora", "INFO");

            CargarBitacora();

            ConfigurarFiltros();
            GestorIdiomaService.Instancia.Agregar(this);

        }
        private void ConfigurarVista()
        {
            EstilosUI.ConfigurarFormulario(this);
            EstilosUI.ConfigurarBoton(btnFiltrar);
            EstilosUI.ConfigurarBotonLogout(btnVolver);
            EstilosUI.ConfigurarCheckBox(chkDesde);
            EstilosUI.ConfigurarCheckBox(chkHasta);

            dataGridView1.BackgroundColor =Color.FromArgb(45, 45, 45);

            dataGridView1.ForeColor =Color.Black;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarBitacora()
        {
            dataGridView1.DataSource = bitacoraBLL.ObtenerBitacora(null,null);
            dataGridView1.Columns["fecha"].DefaultCellStyle.Format ="dd/MM/yyyy HH:mm";
            dataGridView1.Columns["id_bitacora"].Visible = false;
        }
        private void ConfigurarFiltros()
        {
            dtpDesde.Enabled = false;

            dtpHasta.Enabled = false;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime? fechaDesde = null;
            DateTime? fechaHasta = null;

            if (chkDesde.Checked)
            {
                fechaDesde = dtpDesde.Value;
            }

            if (chkHasta.Checked)
            {
                fechaHasta = dtpHasta.Value;
            }

            if (fechaDesde.HasValue && fechaHasta.HasValue && fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta.");

                return;
            }


            dataGridView1.DataSource = bitacoraBLL.ObtenerBitacora(fechaDesde,fechaHasta);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkDesde_CheckedChanged(object sender, EventArgs e)
        {
            dtpDesde.Enabled = chkDesde.Checked;
        }

        private void chkHasta_CheckedChanged(object sender, EventArgs e)
        {
            dtpHasta.Enabled = chkHasta.Checked;
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
