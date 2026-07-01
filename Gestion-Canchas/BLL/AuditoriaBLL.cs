using BE;
using DAL;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AuditoriaBLL
    {
        private readonly AuditoriaDAL _repo;
        BitacoraBLL bitacoraBLL = new BitacoraBLL();
        public AuditoriaBLL(AuditoriaDAL repo)
        {
            _repo = repo;
        }
        public AuditoriaBLL()
        {
            _repo = new AuditoriaDAL();
        }
        public void GuardarEstado(Usuario usuario, string emailNuevo, string modificadoPor, string accion)
        {
            string emailActual = usuario.Email;
            UsuarioMemento memento = usuario.CrearMemento(emailNuevo, emailActual, modificadoPor, accion);

            _repo.InsertarAuditoria(memento);
        }

        public List<UsuarioMemento> ObtenerHistorial(int usuarioId)
        {
            return _repo.ObtenerAuditoria(usuarioId);
        }

        public void Revertir(int idAuditoria)
        {
            UsuarioMemento memento = _repo.ObtenerAuditoriaPorId(idAuditoria);

            if (memento == null)
                throw new Exception("No se encontró el estado seleccionado.");

            UsuarioDAL usuarioDAL = new UsuarioDAL();

            usuarioDAL.RestaurarEmail(memento.UsuarioId,memento.EmailAnterior);

            bitacoraBLL.InsertarBitacora(SessionManagerService.GetInstance.Usuario, $"Restauró el email del usuario ID {memento.UsuarioId}", "INFO");
        }

    }
}
