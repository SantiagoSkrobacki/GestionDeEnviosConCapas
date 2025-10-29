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
        private string destino;
        private Cliente cliente;
        private Repartidor repartidor;
        private Destinatario destinatario;

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

        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Repartidor Repartidor
        {
            get { return repartidor; }
            set { repartidor = value; }
        }

        public Destinatario Destinatario
        {
            get { return destinatario; }
            set { destinatario = value; }
        }

    }
}
