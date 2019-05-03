using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MataFome2.Cache
{
   public static class OperadorCache
    {
        private static int _operador;
        private static string _nome;
        private static double _venda;
        private static string _dataCaixa;
        private static int _usuarioId;
        private static int _devolucao;

        public static int Operador { get => _operador; set => _operador = value; }
        public static string Nome { get => _nome; set => _nome = value; }
        public static double Venda { get => _venda; set => _venda = value; }
        public static string DataCaixa { get => _dataCaixa; set => _dataCaixa = value; }
        public static int UsuarioId { get => _usuarioId; set => _usuarioId = value; }
        public static int Devolucao { get => _devolucao; set => _devolucao = value; }
    }
}
