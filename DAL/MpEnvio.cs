using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class MpEnvio : IMappers <BE.Envio>
    {
        Acceso acc = new Acceso();
        public int Agregar(BE.Envio envio)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("IdCliente", envio.Cliente.Id);
            parametros[1] = new SqlParameter("IdDestinatario", envio.Destinatario.Id);
            fa = acc.Escribir("AgregarEnvio", parametros);
            return fa;
        }

        public int Editar(BE.Envio envio)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[10];
            parametros[0] = new SqlParameter("@CodigoSeguimiento", envio.CodigoSeguimiento);
            parametros[1] = new SqlParameter("@Estado", envio.Estado);
            parametros[2] = new SqlParameter("@FechaCreacion", envio.FechaCreacion);
            parametros[3] = new SqlParameter("@FechaAsignacion", envio.FechaAsignacion);
            parametros[4] = new SqlParameter("@FechaDespacho", envio.FechaDespacho);
            parametros[5] = new SqlParameter("@FechaEntrega", envio.FechaEntrega);
            parametros[6] = new SqlParameter("@ClienteId", envio.Cliente.Id);
            parametros[7] = new SqlParameter("@RepartidorId", envio.Repartidor.Id);
            parametros[8] = new SqlParameter("@DestinatarioId", envio.Destinatario.Id);
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

        public int Ver(BE.Envio envio)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("CodigoSeguimiento", envio.CodigoSeguimiento);
            fa = acc.Escribir("EliminarEnvio", parametro);
            return fa;
        }

        public List<BE.Envio> ObtenerEnviosCreados()
        {
            DataTable dataTable = new DataTable();
            List<BE.Envio> envios = new List<BE.Envio>();

            dataTable = acc.Leer("ObtenerEnviosCreados", null);

            foreach (DataRow row in dataTable.Rows)
            {
                BE.Envio envio = new BE.Envio();

                envio.CodigoSeguimiento = Convert.ToInt32(row["CodigoSeguimiento"]);
                envio.Estado = (EnumEstados)Convert.ToInt32(row["Estado"]);
                envio.FechaCreacion = Convert.ToDateTime(row["FechaCreacion"]);
                envio.Cliente.Id = Convert.ToInt32(row["IdCliente"]);
                envio.Destinatario.Id = Convert.ToInt32(row["IdDestinatario"]);

         
                if (row.Table.Columns.Contains("costo"))
                    envio.Costo = row["costo"] == DBNull.Value ? 0 : Convert.ToDecimal(row["costo"]);

                envios.Add(envio);
            }

            return envios;
        }

        public List<BE.Envio> ObtenerEnviosConPaquetes()
        {
            DataTable dataTable = new DataTable();
            List<BE.Envio> envios = new List<BE.Envio>();

            dataTable = acc.Leer("ObtenerEnviosConPaquetes", null);

            foreach (DataRow row in dataTable.Rows)
            {
                BE.Envio envio = new BE.Envio();

                envio.CodigoSeguimiento = Convert.ToInt32(row["CodigoSeguimiento"]);
                envio.Estado = (EnumEstados)Convert.ToInt32(row["Estado"]);
                envio.FechaCreacion = Convert.ToDateTime(row["FechaCreacion"]);
                envio.Cliente.Id = Convert.ToInt32(row["IdCliente"]);
                envio.Destinatario.Id = Convert.ToInt32(row["IdDestinatario"]);
            

    
                if (row.Table.Columns.Contains("costo"))
                    envio.Costo = row["costo"] == DBNull.Value ? 0 : Convert.ToDecimal(row["costo"]);

                envios.Add(envio);
            }

            return envios;
        }
        
             public List<BE.Envio> ObtenerEnviosConPaquetesYDestinatario()
            {
                DataTable dataTable = new DataTable();
                List<BE.Envio> envios = new List<BE.Envio>();

                dataTable = acc.Leer("ObtenerEnviosConPaquetesYDestinatario", null);

                foreach (DataRow row in dataTable.Rows)
                {
                    BE.Envio envio = new BE.Envio();

                    envio.CodigoSeguimiento = Convert.ToInt32(row["CodigoSeguimiento"]);
                    envio.Estado = (EnumEstados)Convert.ToInt32(row["Estado"]);
                    envio.FechaCreacion = Convert.ToDateTime(row["FechaCreacion"]);
                    envio.Cliente.Id = Convert.ToInt32(row["IdCliente"]);
                    envio.Destinatario.Id = Convert.ToInt32(row["IdDestinatario"]);
                    envio.DocumentoDestinatario = row["Documento"].ToString();
                    envio.DomicilioDestinatario = row["Domicilio"].ToString();
                    envio.CodigoPostal = row["CodigoPostal"].ToString();

                    // si costo no es null osea recien creado
                    if (row.Table.Columns.Contains("costo"))
                        envio.Costo = row["costo"] == DBNull.Value ? 0 : Convert.ToDecimal(row["costo"]);

                    envios.Add(envio);
                }

            return envios;
            }


      
        public List<BE.Envio> ObtenerEnviosPorIdRepartidor(Usuario usuario)
        {
            DataTable dataTable = new DataTable();
            List<BE.Envio> listaEnvios = new List<BE.Envio>();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("IdRepartidor", usuario.Id);
            dataTable = acc.Leer("ObtenerEnviosPorIdRepartidor", parametros);
            foreach (DataRow row in dataTable.Rows)
            {
                BE.Envio envio = new BE.Envio();                
                envio.Cliente = new BE.Usuario();
                envio.Cliente.Id = Convert.ToInt32(row["ClienteId"]);
                envio.Cliente.Nombre = row["ClienteNombre"].ToString();              
                envio.Destinatario = new BE.Usuario();
                envio.Destinatario.Id = Convert.ToInt32(row["DestinatarioId"]);
                envio.Destinatario.Nombre = row["DestinatarioNombre"].ToString();
                envio.Destinatario.Domicilio = row["DestinatarioDomicilio"].ToString();                               
                envio.Destinatario.Telefono = row["DestinatarioTelefono"].ToString();
                envio.Destinatario.CodigoPostal = row["DestinatarioCodigoPostal"].ToString();
                envio.Destinatario.Documento = row["DestinatarioDNI"].ToString()                                        ;
                listaEnvios.Add(envio);
            }
            return listaEnvios;

        }



         public List<BE.Envio> ObtenerEnviosPorIdDestinatario(Usuario usuario)
        {
            DataTable dataTable = new DataTable();
            List<BE.Envio> listaEnvios = new List<BE.Envio>();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("IdUsuario", usuario.Id);
            dataTable = acc.Leer("ObtenerEnviosPorIdDestinatario", parametros);
            foreach (DataRow row in dataTable.Rows)
            {
                BE.Envio envio = new BE.Envio();
                envio.Cliente = new BE.Usuario();
                envio.Cliente.Id = Convert.ToInt32(row["ClienteId"]);
                envio.Cliente.Nombre = row["ClienteNombre"].ToString();
                envio.Destinatario = new BE.Usuario();
                envio.Destinatario.Id = usuario.Id;
                envio.Destinatario.Nombre = usuario.Nombre;
                envio.Destinatario.Domicilio = usuario.Domicilio;
                envio.Destinatario.Telefono = usuario.Telefono;
                envio.Destinatario.CodigoPostal = usuario.CodigoPostal;
                envio.Destinatario.Documento = usuario.Documento;                                         
                listaEnvios.Add(envio);
            }
            return listaEnvios;

        }

        public List<BE.Envio> ObtenerEnviosPorIdCliente(Usuario usuario)
        {
            DataTable dataTable = new DataTable();
            List<BE.Envio> listaEnvios = new List<BE.Envio>();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("IdUsuario", usuario.Id);
            dataTable = acc.Leer("ObtenerEnviosPorIdCliente", parametros);
            foreach (DataRow row in dataTable.Rows)
            {
                BE.Envio envio = new BE.Envio();
                envio.Cliente = new BE.Usuario();
                envio.Cliente.Id = Convert.ToInt32(row["ClienteId"]);
                envio.Cliente.Nombre = usuario.Nombre;
                envio.Destinatario = new BE.Usuario();
                envio.Destinatario.Id = Convert.ToInt32(row["DestinatarioId"]);
                envio.Destinatario.Nombre = row["DestinatarioNombre"].ToString();
                envio.Destinatario.Domicilio = row["DestinatarioDomicilio"].ToString();
                envio.Destinatario.Telefono = row["DestinatarioTelefono"].ToString();
                envio.Destinatario.CodigoPostal = row["DestinatarioCodigoPostal"].ToString();
                envio.Destinatario.Documento = row["DestinatarioDNI"].ToString();
                listaEnvios.Add(envio);
            }
            return listaEnvios;

        }


        public void CambiarEstado(int idEnvio, int nuevoEstado)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@Id", idEnvio);
            parametros[1] = new SqlParameter("@NuevoEstado",  nuevoEstado);
            acc.Escribir("CambiarEstadoEnvio", parametros);
        }

        public int AsigarRepartidorEnvio(BE.Envio envio)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@CodigoSeguimiento", envio.CodigoSeguimiento);
            parametros[1] = new SqlParameter("@IdRepartidor", envio.Repartidor.Id);
            fa = acc.Escribir("AsigarRepartidorEnvio", parametros);
            return fa;
        }



    }
}
