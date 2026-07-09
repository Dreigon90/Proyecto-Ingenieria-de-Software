using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IdiomaDAL
    {
        DAO dao = new DAO();

        public List<Idioma> ObtenerIdiomas()
        {
            string command = "ObtenerIdiomas";

            DataSet ds = dao.EjecutarDataSet(command);

            List<Idioma> lista = new List<Idioma>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lista.Add(new Idioma()
                {
                    Id = Convert.ToInt32(row["IdIdioma"]),
                    Nombre = row["Nombre"].ToString()
                });
            }

            return lista;
        }

        public List<Traduccion> ObtenerTraducciones(int idIdioma)
        {
            string command = "ObtenerTraducciones";

            var parametros = new Dictionary<string, object>()
            {
                {"@IdIdioma",idIdioma}
            };

            DataSet ds = dao.EjecutarDataSet(command, parametros);

            List<Traduccion> lista = new List<Traduccion>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lista.Add(new Traduccion()
                {
                    Clave = row["Clave"].ToString(),
                    Texto = row["Texto"].ToString()
                });
            }

            return lista;
        }
        public void InsertarIdioma(string nombre)
        {
            string command = "InsertarIdioma";

            var parametros = new Dictionary<string, object>()
            {
                { "@Nombre", nombre }
            };

            dao.EjecutarNonQuery(command, parametros);
        }
        public void EliminarIdioma(int idIdioma)
        {
            string command = "EliminarIdioma";

            var parametros = new Dictionary<string, object>()
            {
                { "@IdIdioma", idIdioma }
            };

            dao.EjecutarNonQuery(command, parametros);
        }

    }
}
