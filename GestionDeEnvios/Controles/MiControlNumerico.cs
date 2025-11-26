using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeEnvios.Controles
{
    public partial class MiControlNumerico : MiControl
    {
        public MiControlNumerico()
        {
            InitializeComponent();
            patronRegex = "^[0-9]+$"; // Acepta números
        }
      
        private void MiControlNumerico_Load(object sender, EventArgs e)
        {

        }
    }
}
