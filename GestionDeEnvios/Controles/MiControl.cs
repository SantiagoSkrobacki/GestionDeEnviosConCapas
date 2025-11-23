using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeEnvios
{
    public partial class MiControl : UserControl
    {
        public MiControl()
        {
            InitializeComponent();
        }
        public string Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public string Texto
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }



        protected void SetearColor(Color unColor)
        {
            textBox1.ForeColor = unColor;
        }

        public virtual bool Validar()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                ok = false;
                SetearColor(Color.Red);
                errorLBL.Text = "Formato Incorrecto";
            }
            else
            {
                errorLBL.Visible = false;
                SetearColor(Color.Black);
            }
            return ok;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
