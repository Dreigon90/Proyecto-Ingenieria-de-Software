using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TraduccionDAL
    {
        DAO dao = new DAO();

        public List<TraduccionDTO> ObtenerPorIdioma(int idIdioma)
        {
            string procedimiento = "Traduccion_ObtenerPorIdioma";

            var parametros = new Dictionary<string, object>
            {
                { "@IdIdioma", idIdioma }
            };

            DataSet ds = dao.EjecutarDataSet(procedimiento, parametros);

            List<TraduccionDTO> lista = new List<TraduccionDTO>();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                lista.Add(new TraduccionDTO()
                {
                    IdEtiqueta = Convert.ToInt32(fila["IdEtiqueta"]),
                    Clave = fila["Clave"].ToString(),
                    Texto = fila["Texto"].ToString()
                });
            }

            return lista;
        }
        public void GuardarTraduccion(int idIdioma,
                              int idEtiqueta,
                              string texto)
        {
            string procedimiento = "Traduccion_Guardar";

            var parametros = new Dictionary<string, object>()
            {
                { "@IdIdioma", idIdioma },
                { "@IdEtiqueta", idEtiqueta },
                { "@Texto", texto }
            };

            dao.EjecutarNonQuery(procedimiento, parametros);
        }
    }
}
