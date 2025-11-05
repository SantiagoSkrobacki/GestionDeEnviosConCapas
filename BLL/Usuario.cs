using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class Usuario : IBll<Usuario>
    {
        DAL.MpUsuario mpusuario = new DAL.MpUsuario();


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

        public Usuario Get(String userName)
        {
            // El usuario deberia venir de la BD y su password estar hasheada 
            return mpusuario.Get(userName);
        }

        public bool Validar(string username, string password)
        {
            if (username != null && password != null)
            {
                Usuario user = Get(username);
                
                return user.password == Cripto.ComputeSha256Hash(password);
            }
            return false;
        }
    }
    
}
