using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MataFome2.Controller
{
   public  class ClienteController
    {
       public bool procurarCliente(int telefone)
       {
            using (var db = new LanchoneteEntityContainer())
            {
                var existe = db.Clientes.FirstOrDefault(u => u.Telefone == telefone);
                if (existe != null)
                {
                    return true;
                }
                return false;
            }
       }
        



    }

}
