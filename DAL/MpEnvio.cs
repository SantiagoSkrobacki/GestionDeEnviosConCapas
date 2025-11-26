using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpEnvio : IMappers <BE.Envio>
    {
        Acceso acc = new Acceso();
        public int Agregar(BE.Envio envio)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[9];
            parametros[0] = new SqlParameter("Estado", envio.Estado);
            parametros[1] = new SqlParameter("FechaCreacion", envio.FechaCreacion);
            parametros[2] = new SqlParameter("FechaAsignacion", envio.FechaAsignacion);
            parametros[3] = new SqlParameter("FechaDespacho", envio.FechaDespacho);
            parametros[4] = new SqlParameter("FechaEntrega", envio.FechaEntrega);
            parametros[6] = new SqlParameter("ClienteId", envio.Cliente.Id);
            parametros[7] = new SqlParameter("RepartidorId", envio.Repartidor.Id);
            parametros[8] = new SqlParameter("DestinatarioId", envio.Destinatario.Id);
            fa = acc.Escribir("AgregarEnvio", parametros);
            return fa;
        }

        public int Editar(BE.Envio envio)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[9];
            parametros[0] = new SqlParameter("CodigoSeguimiento", envio.CodigoSeguimiento);
            parametros[1] = new SqlParameter("Estado", envio.Estado);
            parametros[2] = new SqlParameter("FechaCreacion", envio.FechaCreacion);
            parametros[3] = new SqlParameter("FechaAsignacion", envio.FechaAsignacion);
            parametros[4] = new SqlParameter("FechaDespacho", envio.FechaDespacho);
            parametros[5] = new SqlParameter("FechaEntrega", envio.FechaEntrega);
            parametros[6] = new SqlParameter("ClienteId", envio.Cliente.Id);
            parametros[7] = new SqlParameter("RepartidorId", envio.Repartidor.Id);
            parametros[8] = new SqlParameter("DestinatarioId", envio.Destinatario.Id);
            fa = acc.Escribir("ModificarEnvio", parametros);
            return fa;
        }

        public int Eliminar(BE.Envio envio)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("CodigoSeguimiento", envio.CodigoSeguimiento);
            fa = acc.Escribir("EliminarEnvio", parametro);
            return fa;
        }

        public void CambiarEstado(int idEnvio, int nuevoEstado)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@Id", idEnvio);
            parametros[1] = new SqlParameter("@NuevoEstado",  nuevoEstado);
            acc.Escribir("CambiarEstadoEnvio", parametros);
        }
    }
}
