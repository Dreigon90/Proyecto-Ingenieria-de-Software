using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        DAO dAO = new DAO();
        public void GuardarUsuario(string usuario, string password)
        {
            try
            {
                string commandText = "GuardarUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@nombre", usuario },
                    { "@password", password }
                };
                dAO.EjecutarNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public List<string> ObtenerPermisos(string username)
        //{
        // SELECT permisos
        //}

        public void ActualizarIntentos(Usuario user)
        {
            // UPDATE intentos
        }

        public void BloquearUsuario(string username)
        {
            // UPDATE bloqueado = 1
        }

        public Usuario ValidarUsuario(string usuario)
        {
            try
            {
                string commandText = "BuscarUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@nombre", usuario }
                };
                DataSet ds = dAO.EjecutarDataSet(commandText, parametros);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    Usuario usu = new Usuario();
                    usu.Username = row["username"].ToString();
                    usu.PasswordHash = row["password"].ToString();
                    usu.Id = Convert.ToInt32(row["id_usuario"]);
                    //usuario.IntentosFallidos = Convert.ToInt32(row["IntentosFallidos"]);
                    //bool bloqueado = Convert.ToBoolean(row["Bloqueado"]);
                    //if (bloqueado)
                    //{
                    //    MessageBox.Show("Usuario bloqueado por intentos fallidos. Por favor contacte al administrador");
                    //    return null;
                    //}
                    //permisoDAL.FillUserComponents(usu);
                    return usu;
                }
                else
                {
                    throw new Exception("Usuario no encontrado");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
