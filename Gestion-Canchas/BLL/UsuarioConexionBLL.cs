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
        private AuditoriaBLL auditoriaBLL = new AuditoriaBLL();
        BitacoraBLL bitacoraBLL = new BitacoraBLL();

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

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarioDAL.ObtenerUsuarios();
        }

        public void ModificarUsuario(int id,string username,string password,string email,string telefono,string modificadoPor)
        {
            Usuario usuario = usuarioDAL.ObtenerUsuarioPorId(id);

            if (usuario == null)
                throw new Exception("Usuario no encontrado.");

            // Si cambió el email, guardar el estado anterior
            if (usuario.Email != email)
            {
                auditoriaBLL.GuardarEstado(usuario, email, modificadoPor, "Modificación Email");
            }

            usuario.Username = username;
            usuario.Email = email;
            usuario.Telefono = telefono;

            if (!string.IsNullOrWhiteSpace(password))
            {
                usuario.PasswordHash = Encriptacion.Hash(password);
            }

            usuarioDAL.Actualizar(usuario);

            bitacoraBLL.InsertarBitacora(
                SessionManagerService.GetInstance.Usuario,
                $"Modificó el usuario '{username}'",
                "INFO");
        }
        public void ActualizarIdioma(int idUsuario, int idIdioma)
        {
            usuarioDAL.ActualizarIdioma(idUsuario, idIdioma);
        }

    }

    
}
