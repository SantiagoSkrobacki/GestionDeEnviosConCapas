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
        }
        public override bool Validar()
        {

            bool ok = base.Validar();

            if (ok)
            {
                int numero;
                ok = int.TryParse(this.Texto, out numero);
                if (!ok)
                {

                    this.SetearColor(System.Drawing.Color.Red);
                }
                else { this.SetearColor(System.Drawing.Color.Black); }
            }

            return ok;
        }


        private void MiControlNumerico_Load(object sender, EventArgs e)
        {

        }
    }
}
