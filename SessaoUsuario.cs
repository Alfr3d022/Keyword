using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyword
{
    internal class SessaoUsuario
    {
        public static string Usuario { get; private set; }
        public static string idUsuario { get; private set; }

        public static void IniciarSessao(string nomeUsuario, string id_usuario)
        {
            if (Usuario != null)
            {
                EncerrarSessao();
            }
            Usuario = nomeUsuario;
            idUsuario = id_usuario;
        }

        public static void EncerrarSessao()
        {
            Usuario = null;
            idUsuario = null;
        }       

    }
}
