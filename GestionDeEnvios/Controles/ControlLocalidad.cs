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
    public partial class ControlLocalidad : MiControl
    {
        public ControlLocalidad()
        {
            InitializeComponent();
            patronRegex = "^[a-zA-ZñÑáéíóúÁÉÍÓÚ\\s\\.]+$"; // Igual que nombre, pero permite puntos (ej. "Av. Yrigoyen").
        }

        private void ControlLocalidad_Load(object sender, EventArgs e)
        {

        }


    }
}
