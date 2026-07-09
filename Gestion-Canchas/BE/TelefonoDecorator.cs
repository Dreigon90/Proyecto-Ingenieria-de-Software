using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TelefonoDecorator : UsuarioDecorator
    {

        private Usuario usuarioReal;

            public TelefonoDecorator(Usuario usuario)
                : base(usuario)
            {
                usuarioReal = usuario;
            }

            public override string MostrarInformacion()
            {
                return base.MostrarInformacion()
                    + " - Teléfono: " + usuarioReal.Telefono;
            }
        }
    }
}
