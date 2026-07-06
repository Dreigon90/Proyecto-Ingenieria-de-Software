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
using BLL.Composite;
using BLL;
using BE.Composite;

namespace UI.GestionPermisos
{
    public partial class FormUsuariosRoles : Form
    {
        private Admin admin;
        private PermisoBLL permisoBLL;
        private Usuario seleccion;
        private UsuarioConexionBLL usuarioBLL;
        private Usuario tmp;
        private bool isInitializingComboBox = false;

        public FormUsuariosRoles(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            permisoBLL = new PermisoBLL();
            usuarioBLL = new UsuarioConexionBLL();
            this.cboUsuarios.DataSource = usuarioBLL.ObtenerUsuarios();
            this.cboPermisos.DataSource = permisoBLL.GetAllPatentes();
            this.cboFamilias.DataSource = permisoBLL.GetAllFamilias();
        }

        private void FormUsuariosRoles_Load(object sender, EventArgs e)
        {
            btnAgregarFamilia.Enabled = false;
            btnAgregarPermiso.Enabled = false;
            btnGuardarCambios.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Close();
        }

        private void btnConfigurarUsuario_Click(object sender, EventArgs e)
        {
            seleccion = (Usuario)cboUsuarios.SelectedItem;

            if (seleccion != null)
            {
                tmp = new Usuario
                {
                    Id = seleccion.Id,
                    Username = seleccion.Username
                };
                tmp.Permisos.Clear();

                permisoBLL.FillUserComponents(tmp);

                MostrarPermisos(tmp);
                btnAgregarFamilia.Enabled = true;
                btnAgregarPermiso.Enabled = true;
                btnGuardarCambios.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario.");
            }
        }

        void MostrarPermisos(Usuario u)
        {
            this.treeConfigFamilia.Nodes.Clear();
            TreeNode root = new TreeNode(u.Username);

            foreach (var item in u.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.treeConfigFamilia.Nodes.Add(root);
            this.treeConfigFamilia.ExpandAll();
        }

        void LlenarTreeView(TreeNode padre, Componente c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.ListaHijos)
            {
                LlenarTreeView(hijo, item);
            }

        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var patente = (Permiso)cboPermisos.SelectedItem;
                if (patente != null)
                {
                    var esta = false;

                    foreach (var item in tmp.Permisos)
                    {
                        if (permisoBLL.Existe(item, patente.Id))
                        {
                            esta = true;
                            break;
                        }
                    }
                    if (esta)
                        MessageBox.Show("El usuario ya tiene la patente indicada");
                    else
                    {
                        tmp.Permisos.Add(patente);
                        MostrarPermisos(tmp);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una patente.");
                }
            }
            else
            {
                MessageBox.Show("Debe configurar un usuario primero.");
            }
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var flia = (Familia)cboFamilias.SelectedItem;
                if (flia != null)
                {
                    var esta = false;
                    //verifico que ya no tenga el permiso. TODO: Esto debe ser parte de otra capa.
                    foreach (var item in tmp.Permisos)
                    {
                        if (permisoBLL.Existe(item, flia.Id))
                        {
                            esta = true;
                        }
                    }

                    if (esta)
                        MessageBox.Show("El usuario ya tiene la familia indicada");
                    else
                    {
                        {
                            permisoBLL.FillFamilyComponents(flia);
                            tmp.Permisos.Add(flia);
                            MostrarPermisos(tmp);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una familia.");
                }
            }
            else
            {
                MessageBox.Show("Debe configurar un usuario primero.");
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                permisoBLL.GuardarPermisoUsuario(tmp);
                MessageBox.Show("Usuario guardado correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar el usuario");
            }
        }

    }
}
