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
    public partial class ControlCodigoPostal : MiControl
    {
        public ControlCodigoPostal()
        {
            InitializeComponent();
        }

        private void ControlCodigoPostal_Load(object sender, EventArgs e)
        {

        }
        string patron = "^[a-zA-Z0-9]{4,8}$"; // Alfanumérico de 4 a 8 caracteres (sirve para CP viejo de 4 números o el nuevo CPA con letras)...
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
