using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

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
            usuario.Password = Cripto.ComputeSha256Hash(usuario.Password);
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

        public List<BE.Usuario> ObtenerClientesActivos()
        {
            return  mapper.ObtenerClientesActivos();
        }
        public List<BE.Usuario> ObtenerDestinatariosActivos()
        {
            return mapper.ObtenerDestinatariosActivos();
        }



        public List<BE.Usuario> ObtenerTodosLosUsuarios()
        {
            return mapper.ObtenerTodosLosUsuarios();
        }

        public void EscribirUsuariosXML()
        {
            mapper.EscribirXMLUsuarios();
        }
        public List<BE.Usuario> ObtenerRepartidoresActivos()
        {
            return mapper.ObtenerRepartidoresActivos();
        }

    }

}
