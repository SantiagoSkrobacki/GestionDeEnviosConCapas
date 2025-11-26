using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ItemPaquete : IBll<BE.ItemPaquete>
    {
        private const decimal PRECIO_POR_KILO = 1200;
        private const decimal PRECIO_POR_KILO_FRAGIL = 2000;

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

        public decimal CalcularCosto(BE.ItemPaquete paquete)
        {
            if (paquete.Fragil)
            {
                return paquete.Peso * PRECIO_POR_KILO_FRAGIL;
            }
            else
            {
                return paquete.Peso * PRECIO_POR_KILO;
            }

        }

        public List<BE.ItemPaquete> ObtenerPaquetesEnvio(int envioId)
        {
            return mapper.ObtenerPaquetesEnvio(envioId);
        }
    }
}
