using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ItemPaquete
    {
        private string descripcion;
        private decimal peso;
        private bool fragil;
        private decimal costo;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public bool Fragil
        {
            get { return fragil; }
            set { fragil = value; }
        }

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }


    }
}
