using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BitacoraBLL
    {
        BitacoraDAL BitacoraDAL = new BitacoraDAL();

        public void InsertarBitacora(Usuario usu, string mensaje, string estado)
        {
            BitacoraDAL.InsertarBitacora(usu, mensaje, estado);
        }
        public DataTable ObtenerBitacora(DateTime? desde,DateTime? hasta)
        {
            return BitacoraDAL.ObtenerBitacora(desde,hasta);
        }

    }


}
