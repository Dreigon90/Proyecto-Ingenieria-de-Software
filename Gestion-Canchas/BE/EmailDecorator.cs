using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EmailDecorator : UsuarioDecorator
    {
        private Usuario usuarioReal;

        public EmailDecorator(Usuario usuario) : base(usuario)
        {
            usuarioReal = usuario;
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion()
                   + " - Email: " + usuarioReal.Email;
        }
    }
}
