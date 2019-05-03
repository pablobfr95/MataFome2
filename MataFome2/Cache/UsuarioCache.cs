using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MataFome2.Cache
{
   public class UsuarioCache
    {
        private static Int32 _usuarioId;

        private static String _login;

        private static Int32 _nivelUsuario;

        public static Int32 UsuarioId
        {
            get { return UsuarioCache._usuarioId; }
            set { UsuarioCache._usuarioId = value; }
        }

        public static String Login
        {
            get { return UsuarioCache._login; }
            set { UsuarioCache._login = value; }
        }

        public static Int32 NivelUsuario
        {
            get { return UsuarioCache._nivelUsuario; }
            set { UsuarioCache._nivelUsuario = value; }
        }
    }
}
