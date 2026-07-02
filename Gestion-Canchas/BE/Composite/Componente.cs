using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public abstract class Componente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoPermiso Permiso { get; set; }

        public abstract IList<Componente> ListaHijos { get; }
        public abstract void AgregarHijo(Componente c);
        public abstract void VaciarHijos();

        public override string ToString()
        {
            return Nombre;
        }
    }
}
