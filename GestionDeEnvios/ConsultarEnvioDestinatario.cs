using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace GestionDeEnvios
{
    public partial class ConsultarEnvioDestinatario : Form
    {

        BE.Usuario usuarioActual = new BE.Usuario();
        List<BE.Envio> listaEnvios = new List<BE.Envio>();
        BLL.Usuario bllUsuario = new BLL.Usuario();
        public ConsultarEnvioDestinatario(BE.Usuario usuario)
        {
            usuarioActual = usuario;    
            InitializeComponent();
        }

        private void ConsultarEnvioDestinatario_Load(object sender, EventArgs e)
        {
            listaEnvios = bllUsuario.ObtenerEnviosPorIdDestinario(usuarioActual);
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
