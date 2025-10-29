using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente : IBll <BE.Cliente>
    {
        DAL.MpCliente mapper = new DAL.MpCliente();
        public int Agregar(BE.Cliente cliente)
        {
             return mapper.Agregar(cliente);
        }

        public int Editar(BE.Cliente cliente)
        {
            return mapper.Editar(cliente);
        }

        public int Eliminar(BE.Cliente cliente)
        {
            return mapper.Eliminar(cliente);
        }
    }
  
}
