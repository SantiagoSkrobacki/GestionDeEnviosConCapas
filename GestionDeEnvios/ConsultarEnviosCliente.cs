using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GestionDeEnvios
{
    public partial class ConsultarEnviosCliente : FormBase
    {

        BE.Usuario usuarioActual = new BE.Usuario();    
        public List<BE.Envio> listaEnvios = new List<BE.Envio>();
        BLL.Usuario bllUsuario = new BLL.Usuario();
        BLL.Envio bllenvio = new BLL.Envio();
        public ConsultarEnviosCliente(BE.Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        private void ConsultarEnviosCliente_Load(object sender, EventArgs e)
        {
            listaEnvios = bllenvio.ObtenerEnviosPorIdCliente(usuarioActual);
            enviosDGV.DataSource = listaEnvios;
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
