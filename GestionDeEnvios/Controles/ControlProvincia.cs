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
    public partial class ControlProvincia : MiControl
    {
        public ControlProvincia()
        {
            InitializeComponent();
            patronRegex = "^[a-zA-ZñÑáéíóúÁÉÍÓÚ\\s]+$"; // Solo letras y espacios..
        }

        private void ControlProvincia_Load(object sender, EventArgs e)
        {

        }


    }
}
