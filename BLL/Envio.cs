using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Envio : IBll<BE.Envio>
    {
       DAL.MpEnvio mapper = new DAL.MpEnvio();
        public int Agregar(BE.Envio envio)
        {
            return mapper.Agregar(envio);
        }

        public void CambiarEstado(int codigoSeguimiento, EnumEstados nuevoEstado)
        {
            mapper.CambiarEstado(codigoSeguimiento, (int)nuevoEstado);
        }

        public int Editar(BE.Envio envio)
        {
            return mapper.Editar(envio);
        }

        public int Eliminar(BE.Envio envio)
        {
            return mapper.Eliminar(envio);
        }
    }

}
