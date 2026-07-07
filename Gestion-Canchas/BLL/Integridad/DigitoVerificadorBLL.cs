using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL.Integridad;
using Services;

namespace BLL.Integridad
{
    public class DigitoVerificadorBLL
    {
        private DigitoVerificadorDAL digitoVerificadorDAL = new DigitoVerificadorDAL();

        // Métodos de cálculo de dígito verificador
        public void ActualizarDVHUsuarios()
        {
            try
            {
                List<Usuario> usuarios = digitoVerificadorDAL.ObtenerUsuariosParaCalcularDVH();

                foreach (Usuario usuario in usuarios)
                {
                    string dvh = DigitoVerificadorService.CalcularDVH(usuario);

                    digitoVerificadorDAL.ActualizarDVHUsuario(usuario.Id, dvh);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarDVV()
        {
            try
            {
                List<string> listaDVH = digitoVerificadorDAL.ObtenerDVHUsuarios();

                string dvv = DigitoVerificadorService.CalcularDVV(listaDVH);

                digitoVerificadorDAL.ActualizarDVV("Usuario", dvv);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RecalcularIntegridad()
        {
            try
            {
                ActualizarDVHUsuarios();

                ActualizarDVV();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Métodos de verificación
        public bool VerificarDVHUsuarios()
        {
            try
            {
                List<Usuario> usuarios = digitoVerificadorDAL.ObtenerUsuariosConDVH();

                foreach (Usuario usuario in usuarios)
                {
                    string dvhCalculado = DigitoVerificadorService.CalcularDVH(usuario);

                    if (dvhCalculado != usuario.DVH)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
