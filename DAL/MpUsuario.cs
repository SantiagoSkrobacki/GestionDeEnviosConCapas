using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class MpUsuario : IMappers<Usuario>
    {
        Acceso acc = new Acceso();

        public int Agregar(Usuario parametro)
        {
            throw new NotImplementedException();
        }

        public int Editar(Usuario parametro)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(Usuario parametro)
        {
            throw new NotImplementedException();
        }

        
       /* public BE.Usuario Get(string userName)
        {
            user.userName = userName;
            return user;
        }*/
    }
}
