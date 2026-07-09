using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class UsuarioDecorator : Iusuario
    {
        protected Iusuario usuario;

        protected UsuarioDecorator(Iusuario usuario)
        {
            this.usuario = usuario;
        }

        public override string MostrarInformacion()
        {
            return usuario.MostrarInformacion();
        }
    }
}
