using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BE.Composite;

namespace Services
{
    public class SessionManagerService
    {
        private Usuario usuario;
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private static SessionManagerService _session;
        private static Object _lock = new object();
        private SessionManagerService() { }

        public static SessionManagerService GetInstance
        {
            get
            {
                lock (_lock)
                {
                    if (_session == null)
                        _session = new SessionManagerService();
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
                session.usuario = null;
            }
            else
            {
                throw new Exception("Sesión no iniciada");
            }
        }


        // Validación de permisos
        public bool TienePermiso(TipoPermiso permisoBuscado)
        {
            if (usuario == null)
                return false;

            foreach (Componente componente in usuario.Permisos)
            {
                if (TienePermisoRecursivo(componente, permisoBuscado))
                    return true;
            }

            return false;
        }

        // Validación de recursividad
        private bool TienePermisoRecursivo(Componente componente, TipoPermiso permisoBuscado)
        {
            if (componente.Permiso == permisoBuscado)
                return true;

            foreach (Componente hijo in componente.ListaHijos)
            {
                if (TienePermisoRecursivo(hijo, permisoBuscado)) // Recursividad
                    return true;
            }

            return false;
        }

    }
}
