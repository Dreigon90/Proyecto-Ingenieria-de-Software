using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Composite;

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

        // Integracion de digito verificador
        public string DVH { get; set; } 


        private List<Componente> _permisos;

        public List<Componente> Permisos
        {
            get { return _permisos; }
        }

        public Usuario()
        {
            _permisos = new List<Componente>();
        }

        public override string ToString()
        {
            return Username;
        }



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
