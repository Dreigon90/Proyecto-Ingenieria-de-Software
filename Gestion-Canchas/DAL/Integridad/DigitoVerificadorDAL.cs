using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL.Integridad
{
    public class DigitoVerificadorDAL
    {
        DAO dao = new DAO();

        public void ActualizarDVHUsuario(int idUsuario, string dvh)
        {
            try
            {
                string commandText = "Usuario_ActualizarDVH";

                var parametros = new Dictionary<string, object>()
                {
                    { "@IdUsuario", idUsuario },
                    { "@DVH", dvh }
                };

                dao.EjecutarNonQuery(commandText, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ObtenerDVV(string nombreTabla)
        {
            try
            {
                string commandText = "DVV_ObtenerPorTabla";

                var parametros = new Dictionary<string, object>()
                {
                    { "@NombreTabla", nombreTabla }
                };

                return dao.EjecutarScalarString(commandText, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarDVV(string nombreTabla, string dvv)
        {
            try
            {
                string commandText = "DVV_ActualizarPorTabla";

                var parametros = new Dictionary<string, object>()
                {
                    { "@NombreTabla", nombreTabla },
                    { "@DVV", dvv }
                };

                dao.EjecutarNonQuery(commandText, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> ObtenerDVHUsuarios()
        {
            try
            {
                List<string> lista = new List<string>();

                string commandText = "Usuario_ObtenerDVH";

                DataSet ds = dao.EjecutarDataSet(commandText);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        lista.Add(fila["DVH"].ToString());
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> ObtenerUsuariosParaCalcularDVH()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();

                string commandText = "Usuario_ObtenerDatosParaDVH";

                DataSet ds = dao.EjecutarDataSet(commandText);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        Usuario usuario = new Usuario();

                        usuario.Id = Convert.ToInt32(fila["id_usuario"]);
                        usuario.Username = fila["username"].ToString();
                        usuario.PasswordHash = fila["password"].ToString();
                        usuario.Telefono = fila["Telefono"].ToString();
                        usuario.Email = fila["Email"].ToString();
                        usuario.IdIdioma = Convert.ToInt32(fila["IdIdioma"]);

                        lista.Add(usuario);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> ObtenerUsuariosConDVH()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();

                string commandText = "Usuario_ObtenerDatosConDVH";

                DataSet ds = dao.EjecutarDataSet(commandText);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        Usuario usuario = new Usuario();

                        usuario.Id = Convert.ToInt32(fila["id_usuario"]);
                        usuario.Username = fila["username"].ToString();
                        usuario.PasswordHash = fila["password"].ToString();
                        usuario.Telefono = fila["Telefono"].ToString();
                        usuario.Email = fila["Email"].ToString();
                        usuario.IdIdioma = Convert.ToInt32(fila["IdIdioma"]);
                        usuario.DVH = fila["DVH"].ToString();

                        lista.Add(usuario);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
