using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeEnvios.Controles
{
    public partial class ControlNombre : MiControl
    {
        public ControlNombre()
        {
            InitializeComponent();
            patronRegex = "^[a-zA-ZñÑáéíóúÁÉÍÓÚ\\s]+$"; //Solo letras (incluye tildes y ñ) y espacios. Sin números ni símbolos.
        }

        private void ControlNombre_Load(object sender, EventArgs e)
        {

        }

    }
}
