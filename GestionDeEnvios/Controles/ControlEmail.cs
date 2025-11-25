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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeEnvios.Controles
{
    public partial class ControlEmail : MiControl
    {
        public ControlEmail()
        {
            InitializeComponent();
            patronRegex = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"; //Formato estándar de correo (ej. usuario@dominio.com).
        }


        private void ControlId_Load(object sender, EventArgs e)
        {

        }


    }
}
