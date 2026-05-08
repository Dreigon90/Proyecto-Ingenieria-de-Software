using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class UsuarioConexionBLL
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();

        public Usuario ValidarUsuario(string username, string password)
        {
            Usuario usuario = usuarioDAL.ValidarUsuario(username);

            if (usuario == null)
            {
                throw new Exception("Usuario inexistente");
            }

            if (usuario.PasswordHash != password)
            {
                throw new Exception("Contraseña incorrecta");
            }

            return usuario;
        }
     }

    
}
