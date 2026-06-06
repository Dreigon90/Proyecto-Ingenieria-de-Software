using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Services;

namespace BLL
{
    public class SessionManagerBLL
    {

        private Usuario usuario;
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private static SessionManagerBLL _session;

        private static Object _lock = new object();
        private SessionManagerBLL() { }

        public static SessionManagerBLL GetInstance
        {
            get
            {
                lock (_lock)
                {
                    if (_session == null)
                        _session = new SessionManagerBLL();
                }

                return _session;
            }
        }
        public static void Login(Usuario usuario)
        {
            var session = GetInstance;
            if (session.usuario == null)
            {
                session.usuario = usuario;
            }
            else
            {
                throw new Exception("Ya hay una sesión iniciada");
            }
        }

        public static void Logout()
        {
            var session = GetInstance;
            if (session.usuario != null)
            {
                session = null;
            }
            else
            {
                throw new Exception("Sesión no iniciada");
            }
        }

    }
}
