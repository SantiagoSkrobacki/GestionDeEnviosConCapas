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
    public partial class ControlContraseña : MiControl
    {
        public ControlContraseña()
        {
            InitializeComponent();
            patronRegex = "^.{6,20}$"; //Mínimo 6 caracteres, máximo 20. Acepta cualquier caracter.
        }

        private void ControlContraseña_Load(object sender, EventArgs e)
        {

        }


    }
}
