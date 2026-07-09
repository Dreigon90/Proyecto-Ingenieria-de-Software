using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TraduccionBLL
    {
        TraduccionDAL traduccionDAL = new TraduccionDAL();

        public List<TraduccionDTO> ObtenerPorIdioma(int idIdioma)
        {
            return traduccionDAL.ObtenerPorIdioma(idIdioma);
        }
        public void GuardarTraduccion(int idIdioma, int idEtiqueta, string texto)
        {
            traduccionDAL.GuardarTraduccion(idIdioma, idEtiqueta, texto);
        }
    }

}
