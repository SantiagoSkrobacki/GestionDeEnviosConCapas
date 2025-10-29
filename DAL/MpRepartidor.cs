using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpRepartidor : IMappers <BE.Repartidor>
    {
        Acceso acc = new Acceso();
        public int Agregar(BE.Repartidor repartidor)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("Email", repartidor.Email);
            parametros[1] = new SqlParameter("Password", repartidor.Password);
            parametros[2] = new SqlParameter("Nombre", repartidor.Nombre);
            parametros[3] = new SqlParameter("Activo", repartidor.Activo);
            parametros[4] = new SqlParameter("Telefono", repartidor.Telefono);
            parametros[5] = new SqlParameter("Disponible", repartidor.Disponible);
            fa = acc.Escribir("AgregarRepartidor", parametros);
            return fa;
        }

        public int Editar(BE.Repartidor repartidor)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[7];
            parametros[0] = new SqlParameter("Id", repartidor.Id);
            parametros[1] = new SqlParameter("Email", repartidor.Email);
            parametros[2] = new SqlParameter("Password", repartidor.Password);
            parametros[3] = new SqlParameter("Nombre", repartidor.Nombre);
            parametros[4] = new SqlParameter("Activo", repartidor.Activo);
            parametros[5] = new SqlParameter("Telefono", repartidor.Telefono);
            parametros[6] = new SqlParameter("Disponible", repartidor.Disponible);
            fa = acc.Escribir("ModificarRepartidor", parametros);
            return fa;
        }

        public int Eliminar(BE.Repartidor repartidor)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("Id", repartidor.Id);
            fa = acc.Escribir("EliminarRepartidor", parametro);
            return fa;
        }
    }
}
