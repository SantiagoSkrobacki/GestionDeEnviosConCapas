using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Repartidor : Usuario
    {
        private string legajo;
        private string telefono;
        private bool disponible;

        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public bool Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }


    }
}
