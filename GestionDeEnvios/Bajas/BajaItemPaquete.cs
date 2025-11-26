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

namespace GestionDeEnvios.Bajas
{
    public partial class BajaItemPaquete : FormBase
    {
        public BajaItemPaquete()
        {
            InitializeComponent();

            cargarDgvEnvios();
        }

        BLL.Envio bllEnvio = new BLL.Envio();
        BLL.ItemPaquete bllItemPaquete = new BLL.ItemPaquete();
        private int idEnvioActual;
        private void cargarDgvEnvios()
        {
            dgvEnvios.DataSource = null;
            dgvEnvios.DataSource = bllEnvio.ObtenerEnviosConPaquetes();
            dgvEnvios.Columns["Costo"].DisplayIndex = dgvEnvios.Columns.Count - 1;
            dgvEnvios.Columns["FechaDespacho"].Visible = false;
            dgvEnvios.Columns["FechaAsignacion"].Visible = false;
            dgvEnvios.Columns["FechaCancelacion"].Visible = false;
            dgvEnvios.Columns["FechaEntrega"].Visible = false;
            dgvEnvios.Columns["FechaEntrega"].Visible = false;
            dgvEnvios.Columns["Cliente"].Visible = false;
            dgvEnvios.Columns["Repartidor"].Visible = false;
            dgvEnvios.Columns["Destinatario"].Visible = false;
            dgvEnvios.Columns["documentoDestinatario"].Visible = false;
            dgvEnvios.Columns["telefonoDestinatario"].Visible = false;
            dgvEnvios.Columns["nombreDestinatario"].Visible = false;
            dgvEnvios.Columns["domicilioDestinatario"].Visible = false;
            dgvEnvios.Columns["codigoPostal"].Visible = false;
        }
        private void cargarDgvPaquetes(int envioId)
        {
            dgvPaquetes.DataSource = null;
            dgvPaquetes.DataSource = bllItemPaquete.ObtenerPaquetesEnvio(envioId);

        }

        private void dgvEnvios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Envio tmpEnvio = (BE.Envio)dgvEnvios.Rows[e.RowIndex].DataBoundItem;

            idEnvioActual = tmpEnvio.CodigoSeguimiento;
            cargarDgvPaquetes(tmpEnvio.CodigoSeguimiento);
        }

        private void dgvPaquetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.ItemPaquete paquete = (BE.ItemPaquete)dgvPaquetes.Rows[e.RowIndex].DataBoundItem;
            controlIdPaquete.Texto = paquete.Id.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValiacionesUtils.ValidarEntradaUsuario(this))
            {
                BE.ItemPaquete paquete = new BE.ItemPaquete();
                paquete.Id = Convert.ToInt32(controlIdPaquete.Texto);

                int fa = 0;
                fa = bllItemPaquete.Eliminar(paquete);

 
                cargarDgvEnvios();
                cargarDgvPaquetes(idEnvioActual);

                if (fa == 0)
                {
                    MessageBox.Show("Error: no se encontró paquete con el id = " + paquete.Id);
                }
                else
                {
                    MessageBox.Show("Paquete eliminado exitosamente");
                }


            }
            else
            {
                MessageBox.Show("Campos completados incorrectamente...\nPor favor vuelva a intentar.");
            }
        }
    }
}
