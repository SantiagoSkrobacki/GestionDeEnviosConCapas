using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeEnvios.Controles;

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
            if (ValiacionesUtils.ValidarEntradaUsuario(this))
            {
                BE.Envio envio = new BE.Envio();
                envio.Repartidor.Id = Convert.ToInt32(controlIdRepartidor.Texto);
                envio.CodigoSeguimiento = Convert.ToInt32(controlIdEnvio.Texto);

                int fa = 0;
                fa = bllEnvio.AsigarRepartidorEnvio(envio);


                cargarDgvEnvios();
                cargarDgvRepartidores();

                if (fa == 0)
                {
                    MessageBox.Show("Error: no se encontró envio con el id = " + envio.CodigoSeguimiento +"\n O no se encontró el repartidor con id = " +envio.Repartidor.Id);
                }
                else
                {
                    MessageBox.Show("Envio asignado al repartido exitosamente");
                }


            }
            else
            {
                MessageBox.Show("Campos completados incorrectamente...\nPor favor vuelva a intentar.");
            }
        }

        private void dgvEnvios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Envio tmpEnvio = (BE.Envio)dgvEnvios.Rows[e.RowIndex].DataBoundItem;

            controlIdEnvio.Texto = tmpEnvio.CodigoSeguimiento.ToString();
        }

        private void dgvRepartidores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Usuario tmpRepartidor = (BE.Usuario)dgvRepartidores.Rows[e.RowIndex].DataBoundItem;

            controlIdRepartidor.Texto = tmpRepartidor.Id.ToString();
        }

        private void controlIdEnvio_Load(object sender, EventArgs e)
        {

        }
    }
}
