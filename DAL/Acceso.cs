using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlTransaction TR = null;


        public void Conectar()
        {
            cn.ConnectionString = @"Data Source=.;Initial Catalog=SGE;Integrated Security=True";
            cn.Open();
        }

        public void Desconectar()
        {
            cmd.Parameters.Clear();
            cn.Close();
            cn.Dispose();
        }

        public int Escribir(string sp, SqlParameter[] parametro)
        {
            int fa = 0;
            try
            {

                Conectar();

                TR = cn.BeginTransaction();


                cmd.Connection = cn;
                cmd.Transaction = TR;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                if (parametro != null && parametro.Length > 0)
                {
                    cmd.Parameters.AddRange(parametro);
                }
                fa = cmd.ExecuteNonQuery();

                TR.Commit();

            }
            catch
            {
                TR.Rollback();
                throw new Exception("Rollback en transaccion");
            }
            finally
            {
                Desconectar();
            }

            return fa;

        }

        public DataTable Leer(string sp, SqlParameter[] parametro)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter();
                Conectar();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;

                if (parametro != null && parametro.Length > 0)
                {
                    cmd.Parameters.AddRange(parametro);
                }


                adaptador.SelectCommand = cmd;
                adaptador.Fill(dt);
            }
            finally
            {
                Desconectar();
            }

            return dt;
        }

        public object ObtenerDato(string sp, SqlParameter[] parametro)
        {
            object result = null;
            try
            {
                Conectar();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;

                if (parametro != null && parametro.Length > 0)
                    cmd.Parameters.AddRange(parametro);

                result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    result = null;
            }
            finally
            {
                Desconectar();
            }

            return result;
        }


    }
}
