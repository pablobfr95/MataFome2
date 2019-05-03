using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MataFome2.Cache
{
   public static class VendaCache
    {
        private static int _idvenda;

        public static int Idvenda { get => _idvenda; set => _idvenda = value; }
    }
}
