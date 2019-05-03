using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MataFome2.Controller
{
    public class UsuarioController
    {
        public Usuario Login(Usuario usu)
        {
            using (var repo = new LanchoneteEntityContainer())
            {
                return repo.Usuarios.FirstOrDefault(u => u.Login == usu.Login && u.Senha == usu.Senha);
            }
        }

        public bool Cadastrar(Usuario usu)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                var existe = db.Usuarios.FirstOrDefault(i => i.Login == usu.Login);
                if (existe == null)
                {
                    db.Usuarios.Add(usu);
                    db.SaveChanges();
                    return true;
                }
                return false;

            }
        }


    }
}
