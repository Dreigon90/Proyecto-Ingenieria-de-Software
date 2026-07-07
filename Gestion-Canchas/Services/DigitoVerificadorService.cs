using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Services
{
    public class DigitoVerificadorService
    {
        private static string CalcularMD5(string texto)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);

                byte[] hash = md5.ComputeHash(bytes);

                StringBuilder resultado = new StringBuilder();

                foreach (byte b in hash)
                {
                    resultado.Append(b.ToString("x2"));
                }

                return resultado.ToString();
            }
        }

        public static string CalcularDVH(Usuario usuario)
        {
            // Valido si algún campo llega con null
            string cadena =
                usuario.Id +
                (usuario.Username ?? "") +
                (usuario.PasswordHash ?? "") +
                (usuario.Telefono ?? "") +
                (usuario.Email ?? "") +
                usuario.IdIdioma;

            //Opcion con delimitadores
            //string cadena =
            //    usuario.Id + "|" +
            //    (usuario.Username ?? "") + "|" +
            //    (usuario.PasswordHash ?? "") + "|" +
            //    (usuario.Telefono ?? "") + "|" +
            //    (usuario.Email ?? "") + "|" +
            //    usuario.IdIdioma;

            return CalcularMD5(cadena);
        }

        public static string CalcularDVV(List<string> listaDVH)
        {
            StringBuilder cadena = new StringBuilder();

            foreach (string dvh in listaDVH)
            {
                cadena.Append(dvh);
            }

            return CalcularMD5(cadena.ToString());
        }
    }
}
