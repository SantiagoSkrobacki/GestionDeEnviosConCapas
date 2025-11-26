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
    public partial class AsignarRepartidorEnvio : FormBase
    {
        public AsignarRepartidorEnvio()
        {
            InitializeComponent();

            cargarDgvEnvios();
            cargarDgvRepartidores();

        }

        BLL.Envio bllEnvio = new BLL.Envio();
        BLL.Usuario bllUsuario = new BLL.Usuario();


        private void cargarDgvEnvios()
        {
            dgvEnvios.DataSource = null;
            dgvEnvios.DataSource = bllEnvio.ObtenerEnviosConPaquetesYDestinatario();
            dgvEnvios.Columns["Costo"].DisplayIndex = dgvEnvios.Columns.Count - 1;
            dgvEnvios.Columns["FechaDespacho"].Visible = false;
            dgvEnvios.Columns["FechaAsignacion"].Visible = false;
            dgvEnvios.Columns["FechaCancelacion"].Visible = false;
            dgvEnvios.Columns["FechaEntrega"].Visible = false;
            dgvEnvios.Columns["Cliente"].Visible = false;
            dgvEnvios.Columns["Repartidor"].Visible = false;
            dgvEnvios.Columns["Destinatario"].Visible = false;
            dgvEnvios.Columns["telefonoDestinatario"].Visible = false;
            dgvEnvios.Columns["nombreDestinatario"].Visible = false;


        }

        private void cargarDgvRepartidores()
        {
            dgvRepartidores.DataSource = null;
            dgvRepartidores.DataSource = bllUsuario.ObtenerRepartidoresActivos();
            dgvRepartidores.Columns["password"].Visible = false;
            dgvRepartidores.Columns["activo"].Visible = false;
            dgvRepartidores.Columns["domicilio"].Visible = false;
            dgvRepartidores.Columns["localidad"].Visible = false;
            dgvRepartidores.Columns["provincia"].Visible = false;
            dgvRepartidores.Columns["codigoPostal"].Visible = false;
            dgvRepartidores.Columns["documento"].Visible = false;

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }
    }
}
