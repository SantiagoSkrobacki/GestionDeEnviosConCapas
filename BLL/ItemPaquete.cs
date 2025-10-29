using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ItemPaquete : IBll<BE.ItemPaquete>
    {
        DAL.MpItemPaquete mapper = new DAL.MpItemPaquete();

        public int Agregar(BE.ItemPaquete itempaquete)
        {
            return mapper.Agregar(itempaquete);
        }

        public int Editar(BE.ItemPaquete itempaquete)
        {
            return mapper.Editar(itempaquete);
        }

        public int Eliminar(BE.ItemPaquete itempaquete)
        {
            return mapper.Eliminar(itempaquete);
        }
    }
}
