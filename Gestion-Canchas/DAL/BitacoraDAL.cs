using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BitacoraDAL
    {

        DAO dAO = new DAO();

        public void InsertarBitacora(Usuario usu, string mensaje)
        {
            try
            {

                string commandText = "InsertarBitacora";
                var parametros = new Dictionary<string, object>
                {
                    { "@idUsuario", usu.Id },
                    { "@mensaje", mensaje },
                    { "@fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }
                };
                dAO.EjecutarNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
