using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpAdministrador : IMappers <BE.Administrador>
    {
        Acceso acc = new Acceso();
        public int Agregar(BE.Administrador admin)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("Email", admin.Email);
            parametros[1] = new SqlParameter("Password",admin.Password);
            parametros[2] = new SqlParameter("Nombre",admin.Nombre);
            parametros[3] = new SqlParameter("Activo",admin.Activo);
            fa = acc.Escribir("AgregarAdministrador",parametros);
            return fa;
        }

        public int Editar(BE.Administrador admin)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("Email", admin.Email);
            parametros[1] = new SqlParameter("Password", admin.Password);
            parametros[2] = new SqlParameter("Nombre", admin.Nombre);
            parametros[3] = new SqlParameter("Activo", admin.Activo);
            fa = acc.Escribir("ModificarAdministrador", parametros);
            return fa;
        }

        public int Eliminar(BE.Administrador admin)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("Id", admin.Id);
            fa = acc.Escribir("EliminarAdministrador", parametro);
            return fa;
        }
    }
}
