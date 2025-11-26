using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BE;

namespace DAL
{
    public class MpUsuario : IMappers<BE.Usuario>
    {
        Acceso acc = new Acceso();

        public int Agregar(Usuario usuario)
        {
            SqlParameter[] parametros = new SqlParameter[11];

            parametros[0] = new SqlParameter("Email", usuario.Email);
            parametros[1] = new SqlParameter("Password", usuario.Password);
            parametros[2] = new SqlParameter("Nombre", usuario.Nombre);
            parametros[3] = new SqlParameter("Activo", usuario.Activo);
            parametros[4] = new SqlParameter("Telefono", usuario.Telefono);
            parametros[5] = new SqlParameter("Domicilio", usuario.Domicilio);
            parametros[6] = new SqlParameter("Localidad", usuario.Localidad);
            parametros[7] = new SqlParameter("Provincia", usuario.Provincia);
            parametros[8] = new SqlParameter("CodigoPostal", usuario.CodigoPostal);
            parametros[9] = new SqlParameter("Documento", usuario.Documento);
            parametros[10] = new SqlParameter("TipoUsuario", usuario.TipoUsuario);

            return acc.Escribir("AgregarUsuario", parametros);
        }

        public int Editar(Usuario parametro)
        {
            SqlParameter[] parametros = new SqlParameter[12];
            parametros[0] = new SqlParameter("Id", parametro.Id);
            parametros[1] = new SqlParameter("Email", parametro.Email);
            parametros[2] = new SqlParameter("Password", parametro.Password);
            parametros[3] = new SqlParameter("Nombre", parametro.Nombre);
            parametros[4] = new SqlParameter("Activo", parametro.Activo);
            parametros[5] = new SqlParameter("Telefono", parametro.Telefono);
            parametros[6] = new SqlParameter("Domicilio", parametro.Domicilio);
            parametros[7] = new SqlParameter("Localidad", parametro.Localidad);
            parametros[8] = new SqlParameter("Provincia", parametro.Provincia);
            parametros[9] = new SqlParameter("CodigoPostal", parametro.CodigoPostal);
            parametros[10] = new SqlParameter("Documento", parametro.Documento);
            parametros[11] = new SqlParameter("TipoUsuario", parametro.TipoUsuario);
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
            parametros[0] = new SqlParameter("email", email);
            BE.Usuario usuario = new BE.Usuario();
            dataTable = acc.Leer("ObtenerUsuarioPorMail", parametros);
            foreach (DataRow row in dataTable.Rows)
            {
                usuario.Password = row["Password"].ToString();
                usuario.TipoUsuario = row["TipoUsuario"].ToString();
                usuario.Id = Convert.ToInt32(row["Id"]);
            }
            return usuario;

        }
        public List<BE.Usuario>  ObtenerClientesActivos()
        {
            DataTable dataTable = new DataTable();
            List<BE.Usuario> usuarios = new List<BE.Usuario>();
            dataTable = acc.Leer("ObtenerClientesActivos", null);

            foreach (DataRow row in dataTable.Rows)
            {
                BE.Usuario usuario = new BE.Usuario();
                usuario.Id = Convert.ToInt32(row["Id"]);
                usuario.Email = row["Email"].ToString();
                usuario.Password = row["Password"].ToString();
                usuario.Nombre = row["Nombre"].ToString();
                usuario.Activo = Convert.ToBoolean(row["Activo"]);
                usuario.Telefono = row["Telefono"].ToString();
                usuario.Domicilio = row["Domicilio"].ToString();
                usuario.Localidad = row["Localidad"].ToString();
                usuario.Provincia = row["Provincia"].ToString();
                usuario.CodigoPostal = row["CodigoPostal"].ToString();
                usuario.Documento = row["Documento"].ToString();
                usuario.TipoUsuario = row["TipoUsuario"].ToString();
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public List<BE.Usuario> ObtenerDestinatariosActivos()
        {
            DataTable dataTable = new DataTable();
            List<BE.Usuario> usuarios = new List<BE.Usuario>();
            dataTable = acc.Leer("ObtenerDestinatariosActivos", null);

            foreach (DataRow row in dataTable.Rows)
            {
                BE.Usuario usuario = new BE.Usuario();
                usuario.Id = Convert.ToInt32(row["Id"]);
                usuario.Email = row["Email"].ToString();
                usuario.Password = row["Password"].ToString();
                usuario.Nombre = row["Nombre"].ToString();
                usuario.Activo = Convert.ToBoolean(row["Activo"]);
                usuario.Telefono = row["Telefono"].ToString();
                usuario.Domicilio = row["Domicilio"].ToString();
                usuario.Localidad = row["Localidad"].ToString();
                usuario.Provincia = row["Provincia"].ToString();
                usuario.CodigoPostal = row["CodigoPostal"].ToString();
                usuario.Documento = row["Documento"].ToString();
                usuario.TipoUsuario = row["TipoUsuario"].ToString();
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public BE.Usuario ObtenerUsuarioPorId(int id)
        {
            DataTable dataTable = new DataTable();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("IdUsuario", id);
            BE.Usuario usuario = new BE.Usuario();
            dataTable = acc.Leer("ObtenerUsuarioPorId", parametros);
            foreach (DataRow row in dataTable.Rows)
            {
                usuario.Password = row["Password"].ToString();
                usuario.TipoUsuario = row["TipoUsuario"].ToString();
                usuario.Id = Convert.ToInt32(row["Id"]);
                usuario.Email = row["Email"].ToString();
                usuario.Domicilio = row["Domicilio"].ToString();
                usuario.Documento = row["Documento"].ToString();
                usuario.Provincia = row["Provincia"].ToString();
                usuario.Localidad = row["Localidad"].ToString();
                usuario.Telefono = row["Telefono"].ToString();
                usuario.Nombre = row["Nombre"].ToString();
                usuario.CodigoPostal = row["CodigoPostal"].ToString();
            }
            return usuario;
        }

        

        public List<BE.Usuario> ObtenerTodosLosUsuarios()
        {
            List<BE.Usuario> usuarios = new List<BE.Usuario>();
            DataTable dataTable = new DataTable();
            dataTable = acc.Leer("ObtenerTodosLosUsuarios", null);
            foreach (DataRow row in dataTable.Rows)
            {
                BE.Usuario usuario = new BE.Usuario();
                usuario.Id = Convert.ToInt32(row["Id"]);    
                usuario.Email = row["Email"].ToString();
                usuario.Password = row["Password"].ToString();
                usuario.TipoUsuario = row["TipoUsuario"].ToString();
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public List<BE.Usuario> ObtenerRepartidoresActivos()
        {
            List<BE.Usuario> usuarios = new List<BE.Usuario>();
            DataTable dataTable = new DataTable();
            dataTable = acc.Leer("ObtenerRepartidoresActivos", null);
            foreach (DataRow row in dataTable.Rows)
            {
                BE.Usuario usuario = new BE.Usuario();
                usuario.Id = Convert.ToInt32(row["Id"]);
                usuario.Nombre = row["Nombre"].ToString();
                usuario.Telefono = row["Telefono"].ToString();
                usuario.Email = row["Email"].ToString();
                usuario.TipoUsuario = row["TipoUsuario"].ToString();
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public void EscribirXMLUsuarios()
        {
            DataTable dt = new DataTable();
            dt =  acc.Leer("ObtenerTodosLosUsuarios", null);
            acc.EscribirUsuariosEnXML(dt);
        }

        }
    }

