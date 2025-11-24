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
    public class MpUsuario : IMappers<BE.Usuario>
    {
        Acceso acc = new Acceso();

        public int Agregar(Usuario usuario)
        {
            SqlParameter[] parametros = new SqlParameter[12];

            parametros[0] = new SqlParameter("Email", usuario.Email);
            parametros[1] = new SqlParameter("Password", usuario.Password);
            parametros[2] = new SqlParameter("Nombre", usuario.Nombre);
            parametros[3] = new SqlParameter("Activo", usuario.Activo);
            parametros[4] = new SqlParameter("Disponible", usuario.Disponible);
            parametros[5] = new SqlParameter("Telefono", usuario.Telefono);
            parametros[6] = new SqlParameter("Domicilio", usuario.Domicilio);
            parametros[7] = new SqlParameter("Localidad", usuario.Localidad);
            parametros[8] = new SqlParameter("Provincia", usuario.Provincia);
            parametros[9] = new SqlParameter("CodigoPostal", usuario.CodigoPostal);
            parametros[10] = new SqlParameter("Documento", usuario.Documento);
            parametros[11] = new SqlParameter("TipoUsuario", usuario.TipoUsuario);

            return acc.Escribir("AgregarUsuario", parametros);
        }

        public int Editar(Usuario parametro)
        {
            SqlParameter[] parametros = new SqlParameter[13];
            parametros[0] = new SqlParameter("Id", parametro.Id);
            parametros[1] = new SqlParameter("Email", parametro.Email);
            parametros[2] = new SqlParameter("Password", parametro.Password);
            parametros[3] = new SqlParameter("Nombre", parametro.Nombre);
            parametros[4] = new SqlParameter("Activo", parametro.Activo);
            parametros[5] = new SqlParameter("Disponible", parametro.Disponible);
            parametros[6] = new SqlParameter("Telefono", parametro.Telefono);
            parametros[7] = new SqlParameter("Domicilio", parametro.Domicilio);
            parametros[8] = new SqlParameter("Localidad", parametro.Localidad);
            parametros[9] = new SqlParameter("Provincia", parametro.Provincia);
            parametros[10] = new SqlParameter("CodigoPostal", parametro.CodigoPostal);
            parametros[11] = new SqlParameter("Documento", parametro.Documento);
            parametros[12] = new SqlParameter("TipoUsuario", parametro.TipoUsuario);
            return acc.Escribir("ModificarUsuario", parametros);
        }

        public int Eliminar(Usuario parametro)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("Id", parametro.Id);
            return acc.Escribir("EliminarUsuario", parametros);
        }

        public BE.Usuario ObtenerUsuarioPorMail(string email)
        {
            DataTable dataTable = new DataTable();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter ("email", email);
            BE.Usuario usuario = new BE.Usuario();
            dataTable = acc.Leer("ObtenerUsuarioPorMail",parametros);
            foreach(DataRow row in dataTable.Rows)
            {
                usuario.Password = row["Password"].ToString();
                usuario.TipoUsuario = row["TipoUsuario"].ToString();
            }
            return usuario;
        }
    }
}
