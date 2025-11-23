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
        }

        private void ControlProvincia_Load(object sender, EventArgs e)
        {

        }

        string patron = "^[a-zA-ZñÑáéíóúÁÉÍÓÚ\\s]+$"; // Solo letras y espacios..
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
