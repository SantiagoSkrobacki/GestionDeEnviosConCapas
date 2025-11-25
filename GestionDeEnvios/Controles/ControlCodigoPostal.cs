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
            patronRegex = "^[a-zA-Z0-9]{4,8}$"; // Alfanumérico de 4 a 8 caracteres (sirve para CP viejo de 4 números o el nuevo CPA con letras)...
        }

        private void ControlCodigoPostal_Load(object sender, EventArgs e)
        {

        }
    }
 }
