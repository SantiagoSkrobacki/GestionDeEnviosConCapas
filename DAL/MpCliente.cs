using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class MpCliente : IMappers <BE.Cliente>
    {
        Acceso acc = new Acceso();
        public int Agregar(BE.Cliente cliente)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[10];
            parametros[0] = new SqlParameter("Email", cliente.Email);
            parametros[1] = new SqlParameter("Password", cliente.Password);
            parametros[2] = new SqlParameter("Nombre", cliente.Nombre);
            parametros[3] = new SqlParameter("Activo", cliente.Activo);
            parametros[4] = new SqlParameter("Telefono", cliente.Telefono);
            parametros[5] = new SqlParameter("Domicilio", cliente.Domicilio);
            parametros[6] = new SqlParameter("Localidad", cliente.Localidad);
            parametros[7] = new SqlParameter("Provincia", cliente.Provincia);
            parametros[8] = new SqlParameter("CodigoPostal", cliente.CodigoPostal);
            parametros[9] = new SqlParameter("Documento", cliente.Documento);
            fa = acc.Escribir("AgregarCliente", parametros);
            return fa;
        }

        public int Editar(BE.Cliente cliente)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[11];
            parametros[0] = new SqlParameter("Id", cliente.Id);
            parametros[1] = new SqlParameter("Email", cliente.Email);
            parametros[2] = new SqlParameter("Password", cliente.Password);
            parametros[3] = new SqlParameter("Nombre", cliente.Nombre);
            parametros[4] = new SqlParameter("Activo", cliente.Activo);
            parametros[5] = new SqlParameter("Telefono", cliente.Telefono);
            parametros[6] = new SqlParameter("Domicilio", cliente.Domicilio);
            parametros[7] = new SqlParameter("Localidad", cliente.Localidad);
            parametros[8] = new SqlParameter("Provincia", cliente.Provincia);
            parametros[9] = new SqlParameter("CodigoPostal", cliente.CodigoPostal);
            parametros[10] = new SqlParameter("Documento", cliente.Documento);

            fa = acc.Escribir("ModificarCliente", parametros);
            return fa;
        }

        public int Eliminar(BE.Cliente cliente)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];

            parametro[0] = new SqlParameter("Id", cliente.Id);

            fa = acc.Escribir("EliminarCliente", parametro);
            return fa;
        }
    }
}
