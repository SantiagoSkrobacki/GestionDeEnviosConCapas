using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Administrador : IBll<BE.Administrador>
    {
        DAL.MpAdministrador mapper = new DAL.MpAdministrador();
        public int Agregar(BE.Administrador administrador)
        {
            return mapper.Agregar(administrador);
        }

        public int Editar(BE.Administrador administrador)
        {
            return mapper.Editar(administrador);
        }

        public int Eliminar(BE.Administrador administrador)
        {
            return mapper.Eliminar(administrador);
        }
    }
}
