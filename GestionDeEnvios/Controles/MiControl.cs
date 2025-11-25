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

namespace GestionDeEnvios
{
    public partial class MiControl : UserControl
    {
        public MiControl()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
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

        protected string patronRegex = null;

        protected void SetearColorTextBox(Color unColor)
        {
            textBox1.StateCommon.Back.Color1 = unColor;
        }

        protected void SetearColorLabel(Color color)
        {
            lblEtiqueta.ForeColor = color;
        }

        protected bool ValidarRegex(string texto)
        {
            if (patronRegex != null)
            {
                Regex regex = new Regex(patronRegex);

                return regex.IsMatch(texto);

            }

            return true;
        }

        public virtual bool Validar()
        {

            
            if (!ValidarRegex(Texto) || string.IsNullOrWhiteSpace(Texto))
            {
                
                SetearColorTextBox(Color.LightCoral);
                SetearColorLabel(Color.Red);
                errorLBL.Text = "Formato Incorrecto";
                return false;
            }
            else
            {
                errorLBL.Visible = false;
                SetearColorTextBox(Color.White);
                SetearColorLabel(Color.Black);
                return true;
            }
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
