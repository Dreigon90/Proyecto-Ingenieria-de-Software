using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IdiomaBLL
    {
        private readonly IdiomaDAL idiomaDAL = new IdiomaDAL();

        public List<Idioma> ObtenerIdiomas()
        {
            return idiomaDAL.ObtenerIdiomas();
        }

        public List<Traduccion> ObtenerTraducciones(int idIdioma)
        {
            return idiomaDAL.ObtenerTraducciones(idIdioma);
        }
    }
}
