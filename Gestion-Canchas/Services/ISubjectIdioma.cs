using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISubjectIdioma
    {
        void Agregar(IObserverIdioma observer);
        void Quitar(IObserverIdioma observer);
        void Notificar();
    }
}
