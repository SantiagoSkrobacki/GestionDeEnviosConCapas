using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeEnvios
{
    public partial class VerTodosLosEnvios : FormBase
    {
        public VerTodosLosEnvios()
        {
            InitializeComponent();
        }

        BLL.Envio bllenvio = new BLL.Envio();
        private void VerTodosLosEnvios_Load(object sender, EventArgs e)
        {
            enviosDGV.DataSource = bllenvio.ObtenerTodosLosEnvios();
            enviosDGV.Columns["Cliente"].Visible = false;
            enviosDGV.Columns["Repartidor"].Visible = false;
            enviosDGV.Columns["Destinatario"].Visible = false;
            enviosDGV.Columns["fechaCreacion"].Visible = false;
            enviosDGV.Columns["fechaAsignacion"].Visible = false;
            enviosDGV.Columns["fechaDespacho"].Visible = false;
            enviosDGV.Columns["fechaEntrega"].Visible = false;
            enviosDGV.Columns["fechaCancelacion"].Visible = false;
        }
    }
}
