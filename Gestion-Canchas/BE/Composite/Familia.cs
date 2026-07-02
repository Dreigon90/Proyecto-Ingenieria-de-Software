using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Familia: Componente
    {
        // Familia de permisos
        private IList<Componente> _hijos;
        public Familia()
        {
            _hijos = new List<Componente>();
        }
        public override IList<Componente> ListaHijos
        {
            get
            {
                return _hijos.ToArray();
            }
        }
        public override void AgregarHijo(Componente c)
        {
            _hijos.Add(c);
        }
        public override void VaciarHijos()
        {
            _hijos.Clear();
        }
    }
}
