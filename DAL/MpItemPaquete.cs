using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
namespace DAL
{
    public class MpItemPaquete : IMappers <BE.ItemPaquete>
    {
        Acceso acc = new Acceso();
        public int Agregar(BE.ItemPaquete itempaquete)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("Descripcion", itempaquete.Descripcion);
            parametros[1] = new SqlParameter("Peso", itempaquete.Peso);
            parametros[2] = new SqlParameter("Fragil", itempaquete.Fragil);
            parametros[3] = new SqlParameter("Costo", itempaquete.Costo);
            parametros[4] = new SqlParameter("EnvioId", itempaquete.IdEnvio);
            fa = acc.Escribir("AgregarItemPaquete", parametros);
            return fa;
        }

        public int Editar(BE.ItemPaquete itempaquete)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("Id", itempaquete.Id);
            parametros[1] = new SqlParameter("Descripcion", itempaquete.Descripcion);
            parametros[2] = new SqlParameter("Peso", itempaquete.Peso);
            parametros[3] = new SqlParameter("Fragil", itempaquete.Fragil);
            parametros[4] = new SqlParameter("Costo", itempaquete.Costo);
            parametros[5] = new SqlParameter("EnvioId", itempaquete.IdEnvio);
            fa = acc.Escribir("ModificarItemPaquete", parametros);
            return fa;
        }

        public int Eliminar(BE.ItemPaquete itempaquete)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("Id", itempaquete.Id);
            fa = acc.Escribir("EliminarItemPaquete", parametro);
            return fa;
        }

        public List<BE.ItemPaquete> ObtenerPaquetesEnvio(int envioId)
        {
            DataTable dataTable = new DataTable();
            List<BE.ItemPaquete> paquetes = new List<BE.ItemPaquete>();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("EnvioId", envioId);

            dataTable = acc.Leer("ObtenerPaquetesEnvio", parametros);

            foreach (DataRow row in dataTable.Rows)
            {
                BE.ItemPaquete paquete = new BE.ItemPaquete();

                paquete.Id = Convert.ToInt32(row["Id"]);
                paquete.IdEnvio = Convert.ToInt32(row["EnvioId"]);
                paquete.Descripcion = row["Descripcion"].ToString();
                paquete.Peso = Convert.ToDecimal(row["Peso"]);
                paquete.Costo = Convert.ToDecimal(row["Costo"]);
                paquete.Fragil = (bool)row["Fragil"];
             

                paquetes.Add(paquete);
            }

            return paquetes;
        }
    }
}
