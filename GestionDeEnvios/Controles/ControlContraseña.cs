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
        }

        private void ControlContraseña_Load(object sender, EventArgs e)
        {

        }
        string patron = "^.{6,20}$"; //Mínimo 6 caracteres, máximo 20. Acepta cualquier caracter.
        public bool ValidarRegex()
        {
            Regex regex = new Regex(patron);
            if (regex.IsMatch(Texto))
            {
                this.textBox1.BackColor = Color.White;
                errorLBL.Visible = false;
                return true;
            }
            else
            {
                textBox1.BackColor = Color.LightPink;
                errorLBL.Text = "Formato incorrecto. Maximo 20 caracteres";
                return false;
            }
        }
    }
}
