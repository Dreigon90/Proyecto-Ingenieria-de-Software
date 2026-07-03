using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE.Composite;
using BLL.Composite;

namespace UI.GestionPermisos
{
    public partial class FormPermisosFamilias : Form
    {
        Admin admin;
        PermisoBLL permisoBLL;
        Familia seleccion;
        public FormPermisosFamilias(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            permisoBLL = new PermisoBLL();
            this.cboPatentes.DataSource = permisoBLL.GetAllPermission();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Close();
        }

        private void FormPermisosFamilias_Load(object sender, EventArgs e)
        {
            LlenarPatentesFamilias();

        }
        private void LlenarPatentesFamilias()
        {
            this.cboPatentes.DataSource = permisoBLL.GetAllPatentes();
            this.cboFamilias.DataSource = permisoBLL.GetAllFamilias();
        }

        private void btnAgregarPatente_Click(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                var patente = (Permiso)cboPatentes.SelectedItem;
                if (patente != null)
                {
                    var esta = permisoBLL.Existe(seleccion, patente.Id);
                    if (esta)
                        MessageBox.Show("ya exsite la patente indicada");
                    else
                    {
                        seleccion.AgregarHijo(patente);
                        MostrarFamilia(false);
                    }
                }
            }
        }

        void MostrarFamilia(bool init)
        {
            if (seleccion == null) return;

            IList<Componente> flia = null;
            if (init)
            {
                //Para traerme las familias
                flia = permisoBLL.GetAll("=" + seleccion.Id);


                foreach (var i in flia)
                    seleccion.AgregarHijo(i);
            }
            else
            {
                flia = seleccion.ListaHijos;
            }

            this.treeConfigFamilia.Nodes.Clear();

            TreeNode root = new TreeNode(seleccion.Nombre);
            root.Tag = seleccion;
            this.treeConfigFamilia.Nodes.Add(root);

            foreach (var item in flia)
            {
                MostrarEnTreeView(root, item);
            }

            treeConfigFamilia.ExpandAll();
        }

        void MostrarEnTreeView(TreeNode tn, Componente c)
        {
            TreeNode n = new TreeNode(c.Nombre);
            tn.Tag = c;
            tn.Nodes.Add(n);
            if (c.ListaHijos != null)
                foreach (var item in c.ListaHijos)
                {
                    MostrarEnTreeView(n, item);
                }
        }

        private void btnGuardarPatente_Click(object sender, EventArgs e)
        {
            Permiso p = new Permiso()
            {
                Nombre = this.txtNombrePatente.Text,
                Permiso = (TipoPermiso)this.cboPermisos.SelectedItem

            };

            permisoBLL.GuardarComponente(p, false);
            LlenarPatentesFamilias();

            MessageBox.Show("Patente guardada correctamente");
        }

        private void btnConfigurarFamilia_Click(object sender, EventArgs e)
        {
            var tmp = (Familia)this.cboFamilias.SelectedItem;
            seleccion = new Familia();
            seleccion.Id = tmp.Id;
            seleccion.Nombre = tmp.Nombre;

            MostrarFamilia(true);
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                var familia = (Familia)cboFamilias.SelectedItem;
                if (familia != null)
                {
                    if (validarRecursividad(familia, seleccion))
                    {
                        var esta = permisoBLL.Existe(seleccion, familia.Id);
                        if (esta)
                            MessageBox.Show("ya exsite la familia indicada");
                        else
                        {
                            permisoBLL.FillFamilyComponents(familia);
                            seleccion.AgregarHijo(familia);
                            MostrarFamilia(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("problemas de recursividad");
                    }
                }
            }
        }

        private bool validarRecursividad(Familia familia, Familia padre)
        {
            permisoBLL.FillFamilyComponents(familia);
            return auxValidarRecursividad(familia, padre);
        }
        private bool auxValidarRecursividad(Familia familia, Familia padre)
        {
            foreach (var item in familia.ListaHijos)
            {
                if (item.Id == padre.Id)
                {
                    return false;
                }
                if (item is Familia childFamilia)
                {
                    if (!auxValidarRecursividad(childFamilia, padre))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnGuardarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                permisoBLL.GuardarFamilia(seleccion);
                MessageBox.Show("Familia guardada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar la familia");
            }
        }

        private void btnGuardarSimple_Click(object sender, EventArgs e)
        {
            Familia p = new Familia()
            {
                Nombre = this.txtNombreFamilia.Text
            };
            permisoBLL.GuardarComponente(p, true);
            LlenarPatentesFamilias();
            MessageBox.Show("Familia guardada correctamente");
        }
    }
}
