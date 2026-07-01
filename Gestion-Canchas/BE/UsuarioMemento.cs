using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    
    public class UsuarioMemento
    {
        public int IdAuditoria { get; set; }
        public int UsuarioId { get; set; }
        public string EmailAnterior { get; set; }
        public string EmailActual { get; set; }
        public DateTime Fecha { get; set; }
        public string ModificadoPor { get; set; }
        public string Accion { get; set; } // "Creación", "Edición", "Bloqueo"

        public UsuarioMemento()
        {
        }
        public UsuarioMemento(Usuario usuario,string emailNuevo,string modificadoPor,string accion)
        {
            UsuarioId = usuario.Id;

            EmailAnterior = usuario.Email;

            EmailActual = emailNuevo;

            Fecha = DateTime.Now;

            ModificadoPor = modificadoPor;

            Accion = accion;
        }

    }
}
