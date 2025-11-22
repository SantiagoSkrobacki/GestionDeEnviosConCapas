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
    public partial class ControlDocumento : MiControl
    {
        public ControlDocumento()
        {
            InitializeComponent();
        }

        private void ControlDocumento_Load(object sender, EventArgs e)
        {

        }

        string patron = "^[0-9]{7,11}$"; // Solo números. Longitud de 7 a 11 (sirve para DNI, CUIT o Pasaporte).
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
