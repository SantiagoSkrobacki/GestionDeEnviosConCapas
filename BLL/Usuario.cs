using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario : IBll<BE.Usuario>
    {

        DAL.MpUsuario mapper = new DAL.MpUsuario();

   
        public int Agregar(BE.Usuario usuario)
        {
            usuario.Password = Cripto.ComputeSha256Hash(usuario.Password);
            return mapper.Agregar(usuario);
        }

        public int Editar(BE.Usuario usuario)
        {
            return mapper.Editar(usuario);
        }

        public int Eliminar(BE.Usuario usuario)
        {
            return mapper.Eliminar(usuario);
        }

        public BE.Usuario Login (string email, string passwordIngresada)
        {
            // busco si existe usuario con ese mail 
            BE.Usuario usuarioEncontrado = mapper.ObtenerUsuarioPorMail(email);
            if (usuarioEncontrado == null) return null; // Email no existe

            string hashCalculado = Cripto.ComputeSha256Hash(passwordIngresada);

            if (usuarioEncontrado.Password == hashCalculado)
            {
                return usuarioEncontrado; 
            }
            else
            {
                return null; 
            }
        }
    }

}
