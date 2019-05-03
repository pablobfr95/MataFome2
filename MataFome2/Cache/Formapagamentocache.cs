using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MataFome2.Cache
{
   public class Formapagamentocache
    {
        private static string _forma1;
        private static string _forma2;

        public static string Forma1 { get => _forma1; set => _forma1 = value; }
        public static string Forma2 { get => _forma2; set => _forma2 = value; }
    }
}
