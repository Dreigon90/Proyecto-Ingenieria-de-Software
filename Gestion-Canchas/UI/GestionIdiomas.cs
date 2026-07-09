using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class GestionIdiomas : Form
    {
        IdiomaBLL idiomaBLL = new IdiomaBLL();
        TraduccionBLL traduccionBLL = new TraduccionBLL();
        Admin admin;
        public GestionIdiomas(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();

            CargarIdiomas();
        }
        private void CargarIdiomas()
        {
            dgvIdiomas.DataSource = null;

            dgvIdiomas.DataSource = idiomaBLL.ObtenerIdiomas();

            dgvIdiomas.Columns["Id"].Visible = false;

            dgvIdiomas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdioma.Text))
            {
                MessageBox.Show("Ingrese un nombre.");

                return;
            }

            idiomaBLL.InsertarIdioma(txtIdioma.Text);

            txtIdioma.Clear();

            CargarIdiomas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvIdiomas.SelectedRows.Count == 0)
                return;

            Idioma idioma = (Idioma)dgvIdiomas.SelectedRows[0].DataBoundItem;

            idiomaBLL.EliminarIdioma(idioma.Id);

            CargarIdiomas();
        }
        private void ConfigurarGrillaTraducciones()
        {
            dgvTraducciones.Columns["IdEtiqueta"].Visible = false;

            dgvTraducciones.Columns["Clave"].HeaderText = "Etiqueta";

            dgvTraducciones.Columns["Texto"].HeaderText = "Traducción";
            
            dgvTraducciones.Columns["Clave"].ReadOnly = true;

            dgvTraducciones.Columns["Texto"].ReadOnly = false;

            dgvTraducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvIdiomas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Idioma idioma = dgvIdiomas.Rows[e.RowIndex].DataBoundItem as Idioma;

            if (idioma == null)
                return;

            dgvTraducciones.DataSource = traduccionBLL.ObtenerPorIdioma(idioma.Id);
            ConfigurarGrillaTraducciones();
        }
        private void ConfigurarGrillaIdiomas()
        {
            dgvIdiomas.Columns["Id"].Visible = false;

            dgvIdiomas.Columns["Nombre"].HeaderText = "Idioma";

            dgvIdiomas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GestionIdiomas_Load(object sender, EventArgs e)
        {
            dgvIdiomas.DataSource = idiomaBLL.ObtenerIdiomas();

            ConfigurarGrillaIdiomas();
        }

        private void btnGuardarTraducciones_Click(object sender, EventArgs e)
        {
            if (dgvIdiomas.CurrentRow == null)
                return;

            Idioma idioma = dgvIdiomas.CurrentRow.DataBoundItem as Idioma;

            foreach (DataGridViewRow fila in dgvTraducciones.Rows)
            {
                TraduccionDTO t = fila.DataBoundItem as TraduccionDTO;

                traduccionBLL.GuardarTraduccion(idioma.Id,t.IdEtiqueta,t.Texto);
            }

            MessageBox.Show("Traducciones guardadas correctamente.");
        }
    }
}
