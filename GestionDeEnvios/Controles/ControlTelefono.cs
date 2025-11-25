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
    public partial class ControlTelefono : MiControl
    {
        public ControlTelefono()
        {
            InitializeComponent();
            patronRegex = "^[0-9\\+\\-\\s]{8,20}$"; // Acepta números, espacios, guiones y el símbolo + al inicio.
        }


    }
}
