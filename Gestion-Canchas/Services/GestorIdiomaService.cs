using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Services
{
    public class GestorIdiomaService : ISubjectIdioma
    {
        private static GestorIdiomaService instancia;

        private static readonly object padlock = new object();

        private readonly List<IObserverIdioma> observers = new List<IObserverIdioma>();
        
        public Idioma IdiomaActual { get; private set; }

        private GestorIdiomaService()
        {

        }

        public static GestorIdiomaService Instancia
        {
            get
            {
                lock (padlock)
                {
                    if (instancia == null)
                        instancia = new GestorIdiomaService();

                    return instancia;
                }
            }
        }

        public void Agregar(IObserverIdioma observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            if (IdiomaActual != null)
            {
                observer.Actualizar(IdiomaActual);
            }
        }

        public void Quitar(IObserverIdioma observer)
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }

        public void CambiarIdioma(Idioma idioma)
        {
            IdiomaActual = idioma;
            Notificar();
        }

        public void Notificar()
        {
            foreach (IObserverIdioma observer in observers)
            {
                observer.Actualizar(IdiomaActual);
            }
        }

    }
}
