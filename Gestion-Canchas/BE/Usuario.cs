using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Id { get; set; }
        public int IdIdioma { get; set; }

        public UsuarioMemento CrearMemento(string emailNuevo, string emailActual, string modificadoPor, string accion)
        {
            return new UsuarioMemento
            {
                UsuarioId = Id,
                EmailAnterior = emailActual,
                EmailActual = emailNuevo,
                Fecha = DateTime.Now,
                ModificadoPor = modificadoPor,
                Accion = accion
            };
        }

        public void Restaurar(UsuarioMemento memento)
        {
            if (memento == null)
                throw new ArgumentNullException(nameof(memento));

            Email = memento.EmailAnterior;
        }
    }
}
