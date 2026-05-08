using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BitacoraBLL
    {
        BitacoraDAL BitacoraDAL = new BitacoraDAL();

        public void InsertarBitacora(Usuario usu, string mensaje)
        {
            BitacoraDAL.InsertarBitacora(usu, mensaje);
        }

    }


}
