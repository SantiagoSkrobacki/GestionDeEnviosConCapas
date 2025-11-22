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
        }

        string patron = "^[0-9\\+\\-\\s]{8,20}$"; // Acepta números, espacios, guiones y el símbolo + al inicio.

        private void ControlTelefono_Load(object sender, EventArgs e)
        {

        }

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
                errorLBL.Text = "Formato incorrecto";
                return false;
            }
        }
    }
}
