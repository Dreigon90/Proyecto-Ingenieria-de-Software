using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Permiso: Componente
    {
        // Permisos individuales
        public override IList<Componente> ListaHijos
        {
            get
            {
                return new List<Componente>();
            }
        }
        public override void AgregarHijo(Componente c)
        {

        }
        public override void VaciarHijos()
        {

        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
