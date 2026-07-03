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
                    usu.Email = row["Email"].ToString();
                    usu.Telefono = row["Telefono"].ToString();
                    usu.Id = Convert.ToInt32(row["id_usuario"]);
                    usu.IdIdioma = Convert.ToInt32(row["IdIdioma"]);

                    return usu;
                }
                else
                {
                    throw new Exception("Usuario y/o contraseña incorrectos");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            try
            {
                List<Usuario> listUsuarios = new List<Usuario>();
                string commandText = "ObtenerUsuarios";
                DataSet ds = dAO.EjecutarDataSet(commandText);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Usuario usu = new Usuario();
                        usu.Username = row["username"].ToString();
                        usu.Id = Convert.ToInt32(row["id_usuario"]);
                        usu.PasswordHash = Convert.ToString(row["password"]);
                        usu.Email = row["email"].ToString();
                        usu.Telefono = row["telefono"].ToString();
                        usu.IdIdioma = Convert.ToInt32(row["IdIdioma"]);
                        listUsuarios.Add(usu);
                    }
                }
                return listUsuarios;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Actualizar(Usuario usuario)
        {
            string commandText = "ActualizarUsuario";

            var parametros = new Dictionary<string, object>
            {
                {"@Id", usuario.Id},
                {"@Username", usuario.Username},
                {"@PasswordHash", usuario.PasswordHash},
                {"@Email", usuario.Email},
                {"@Telefono", usuario.Telefono}
            };

            dAO.EjecutarNonQuery(commandText, parametros);
        }
        public Usuario ObtenerUsuarioPorId(int id)
        {
            string commandText = "Usuario_ObtenerPorId";

            var parametros = new Dictionary<string, object>
            {
                { "@Id", id }
            };

            DataSet ds = dAO.EjecutarDataSet(commandText, parametros);

            if (ds.Tables[0].Rows.Count == 0)
                return null;

            DataRow row = ds.Tables[0].Rows[0];

            return new Usuario
            {
                Id = Convert.ToInt32(row["id_usuario"]),
                Username = row["username"].ToString(),
                PasswordHash = row["password"].ToString(),
                Email = row["email"].ToString(),
                Telefono = row["telefono"].ToString()
            };
        }
        public void RestaurarEmail(int idUsuario, string email)
        {
            try
            {
                string commandText = "RestaurarEmail";

                var parametros = new Dictionary<string, object>
                {
                    {"@IdUsuario", idUsuario},
                    {"@Email", email}
                };

                dAO.EjecutarNonQuery(commandText, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActualizarIdioma(int idUsuario, int idIdioma)
        {
            string commandText = "Usuario_ActualizarIdioma";

            var parametros = new Dictionary<string, object>()
            {
                {"@IdUsuario", idUsuario},
                {"@IdIdioma", idIdioma}
            };

            dAO.EjecutarNonQuery(commandText, parametros);
        }

    }
}
