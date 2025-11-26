using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private int id;
        private string email;
        private string password;
        private string nombre;
        private bool activo;
        private string telefono;
        private string domicilio;
        private string localidad;
        private string provincia;
        private string codigoPostal;
        private string documento;
        private string tipoUsuario;

        public Usuario() { }

       
        public Usuario(string email, string password, string nombre, bool activo, 
                       string telefono, string domicilio, string localidad, string provincia,
                       string codigoPostal, string documento, string tipoUsuario)
        {
            this.Email = email;
            this.Password = password;
            this.Nombre = nombre;
            this.Activo = activo;
            this.Telefono = telefono;
            this.Domicilio = domicilio;
            this.Localidad = localidad;
            this.Provincia = provincia;
            this.CodigoPostal = codigoPostal;
            this.Documento = documento;
            this.TipoUsuario = tipoUsuario;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
    }
}
