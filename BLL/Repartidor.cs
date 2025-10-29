using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repartidor : IBll <BE.Repartidor>
    {
        DAL.MpRepartidor mapper = new DAL.MpRepartidor();
        public int Agregar(BE.Repartidor repartidor)
        {
            return mapper.Agregar(repartidor);
        }

        public int Editar(BE.Repartidor repartidor)
        {
            return mapper.Editar(repartidor);
        }

        public int Eliminar(BE.Repartidor repartidor)
        {
            return mapper.Eliminar(repartidor);
        }
    }
   
}
