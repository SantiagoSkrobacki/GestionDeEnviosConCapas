using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class MpDestinatario : IMappers<BE.Destinatario>
    {
        Acceso acc = new Acceso();
        public int Agregar(Destinatario destinatario)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[10];
            parametros[0] = new SqlParameter("Email", destinatario.Email);
            parametros[1] = new SqlParameter("Password", destinatario.Password);
            parametros[2] = new SqlParameter("Nombre", destinatario.Nombre);
            parametros[3] = new SqlParameter("Activo", destinatario.Activo);
            parametros[4] = new SqlParameter("Telefono", destinatario.Telefono);
            parametros[5] = new SqlParameter("Domicilio", destinatario.Domicilio);
            parametros[6] = new SqlParameter("Localidad", destinatario.Localidad);
            parametros[7] = new SqlParameter("Provincia", destinatario.Provincia);
            parametros[8] = new SqlParameter("CodigoPostal", destinatario.CodigoPostal);
            parametros[9] = new SqlParameter("Documento", destinatario.Documento);
            fa = acc.Escribir("AgregarDestinatario", parametros);
            return fa;
        }

        public int Editar(Destinatario destinatario)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[11];
            parametros[0] = new SqlParameter("Id", destinatario.Id);
            parametros[1] = new SqlParameter("Email", destinatario.Email);
            parametros[2] = new SqlParameter("Password", destinatario.Password);
            parametros[3] = new SqlParameter("Nombre", destinatario.Nombre);
            parametros[4] = new SqlParameter("Activo", destinatario.Activo);
            parametros[5] = new SqlParameter("Telefono", destinatario.Telefono);
            parametros[6] = new SqlParameter("Domicilio", destinatario.Domicilio);
            parametros[7] = new SqlParameter("Localidad", destinatario.Localidad);
            parametros[8] = new SqlParameter("Provincia", destinatario.Provincia);
            parametros[9] = new SqlParameter("CodigoPostal", destinatario.CodigoPostal);
            parametros[10] = new SqlParameter("Documento", destinatario.Documento);

            fa = acc.Escribir("ModificarDestinatario", parametros);
            return fa;
        }

        public int Eliminar(Destinatario destinatario)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];

            parametro[0] = new SqlParameter("Id", destinatario.Id);

            fa = acc.Escribir("EliminarDestinatario", parametro);
            return fa;
        }
    }
}
