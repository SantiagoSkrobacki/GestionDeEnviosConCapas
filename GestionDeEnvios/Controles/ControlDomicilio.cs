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
    public partial class ControlDomicilio : MiControl
    {
        public ControlDomicilio()
        {
            InitializeComponent();
        }

        private void ControlDomicilio_Load(object sender, EventArgs e)
        {

        }
        string patron = "^[a-zA-Z0-9ñÑáéíóúÁÉÍÓÚ\\s\\.,#-]+$"; // Letras, números, espacios, puntos, comas, guiones y #.
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
