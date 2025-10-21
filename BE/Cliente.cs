using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente : Usuario
    {
        private string telefono;
        private string domicilio;
        private string localidad;
        private string provincia;
        private string codigoPostal;
        private string documento;

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



    }
}
