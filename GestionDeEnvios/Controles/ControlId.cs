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
            patronRegex = "^[1-9][0-9]*$"; // Mayor a 1
        }

        private void ControlId_Load(object sender, EventArgs e)
        {

        }


    }
}
