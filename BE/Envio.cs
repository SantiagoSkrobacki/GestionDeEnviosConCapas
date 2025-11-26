using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Envio
    {
        private List<ItemPaquete> paquetes;
        private int codigoSeguimiento;
        private EnumEstados estado;
        private DateTime fechaCreacion;
        private DateTime fechaAsignacion;
        private DateTime fechaDespacho;
        private DateTime fechaEntrega;
        private DateTime fechaCancelacion;
        private Usuario cliente = new Usuario();
        private Usuario repartidor = new Usuario();
        private Usuario destinatario = new Usuario();
        private string documentoDestinatario;
        private string telefonoDestinatario;
        private string nombreDestinatario;
        private string domicilioDestinatario;
        private string codigoPostal;
        private decimal costo;

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public string DocumentoDestinatario
        {
            get { return destinatario.Documento; }
            set { destinatario.Documento = value; }
        }

        public string TelefonoDestinatario
        {
            get { return destinatario.Telefono; }
            set { destinatario.Telefono = value; }
        }

        public string NombreDestinatario
        {
            get { return destinatario.Nombre; }
            set { destinatario.Nombre = value; }
        }

        public string DomicilioDestinatario
        {
            get { return destinatario.Domicilio; }
            set { destinatario.Domicilio = value; }
        }

        public string CodigoPostal
        {
            get { return destinatario.CodigoPostal; }
            set { destinatario.CodigoPostal = value; }
        }
        public List<ItemPaquete> Paquetes
        {
            get { return paquetes; }
            set { paquetes = value; }
        }


        public int CodigoSeguimiento
        {
            get { return codigoSeguimiento; }
            set { codigoSeguimiento = value; }
        }
     

        public EnumEstados Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

        public DateTime FechaAsignacion
        {
            get { return fechaAsignacion; }
            set { fechaAsignacion = value; }
        }

        public DateTime FechaDespacho
        {
            get { return fechaDespacho; }
            set { fechaDespacho = value; }
        }

        public DateTime FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }
        public DateTime FechaCancelacion
        {
            get { return fechaCancelacion; }
            set { fechaCancelacion = value; }
        }
        public Usuario Cliente 
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Usuario Repartidor
        {
            get { return repartidor; }
            set { repartidor = value; }
        }

        public Usuario Destinatario
        {
            get { return destinatario; }
            set { destinatario = value; }
        }

      
    }
}
