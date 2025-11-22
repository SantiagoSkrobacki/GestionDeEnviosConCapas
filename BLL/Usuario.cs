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
    }

}
