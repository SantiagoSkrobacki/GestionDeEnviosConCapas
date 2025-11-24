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
    public partial class ControlId : MiControl
    {
        public ControlId()
        {
            InitializeComponent();
        }
        string patron = "^[1-9][0-9]*$"; // Mayor a 1
        private void ControlId_Load(object sender, EventArgs e)
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
                errorLBL.Text = "El id debe ser mayor a 1";
                return false;
            }
        }
    }
}
