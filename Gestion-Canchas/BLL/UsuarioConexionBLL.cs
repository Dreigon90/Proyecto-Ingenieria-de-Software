using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Services;

namespace BLL
{
    public class UsuarioConexionBLL
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        EncriptacionService Encriptacion = new EncriptacionService();

        public Usuario ValidarUsuario(string username, string password)
        {
            Usuario usuario = usuarioDAL.ValidarUsuario(username);

            if (usuario == null)
            {
                throw new Exception("Usuario y/o contraseña incorrectos");
            }

            if (!Encriptacion.Verificar(password, usuario.PasswordHash))
            {
                throw new Exception("Usuario y/o contraseña incorrectos");
            }
 
            return usuario;
        }
     }

    
}
