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

namespace GestionDeEnvios.Altas
{
    public partial class AltaItemPaquete : FormBase
    {
        public AltaItemPaquete()
        {
            InitializeComponent();

            cargarDgvEnvios();
        }

        BLL.Envio bllEnvio = new BLL.Envio();
        BLL.ItemPaquete bllItemPaquete = new BLL.ItemPaquete();
        private void AltaItemPaquete_Load(object sender, EventArgs e)
        {

        }

        private void cargarDgvEnvios()
        {
            dgvEnvios.DataSource = null;
            dgvEnvios.DataSource = bllEnvio.ObtenerEnviosCreados();
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

        private void dgvEnvios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Envio tmpEnvio = (BE.Envio)dgvEnvios.Rows[e.RowIndex].DataBoundItem;
            controlIdEnvio.Texto = tmpEnvio.CodigoSeguimiento.ToString();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValiacionesUtils.ValidarEntradaUsuario(this))
                {
                    BE.ItemPaquete itemPaquete = new BE.ItemPaquete();
                    itemPaquete.Descripcion = ControlDescripcion.Texto;
                    itemPaquete.Peso = Convert.ToDecimal(ControlPeso.Texto);
                    itemPaquete.Fragil = CheckBoxFragil.Checked;

                    itemPaquete.Costo = Convert.ToDecimal(bllItemPaquete.CalcularCosto(itemPaquete));

                    lblCostoPaquete.Text = itemPaquete.Costo.ToString();

                   

                    MessageBox.Show("Costo de paquete calculado con éxito");

                }
                else
                {
                    MessageBox.Show("Campos completados incorrectamente...\nPor favor vuelva a intentar.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"EROR: {ex}");

            }
        }

        private void btnAgregarItemPaquete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValiacionesUtils.ValidarEntradaUsuario(this))
                {
                    BE.ItemPaquete itemPaquete = new BE.ItemPaquete();

                    itemPaquete.Descripcion = ControlDescripcion.Texto;

                    itemPaquete.Peso = Convert.ToDecimal(ControlPeso.Texto);

                    itemPaquete.Fragil = CheckBoxFragil.Checked;

                    itemPaquete.IdEnvio = int.Parse(controlIdEnvio.Texto);

                    itemPaquete.Costo = Convert.ToDecimal(lblCostoPaquete.Text);


                    bllItemPaquete.Agregar(itemPaquete);

                    cargarDgvEnvios();

                    MessageBox.Show("Paquete añadido con éxito");

                }
                else
                {
                    MessageBox.Show("Campos completados incorrectamente...\nPor favor vuelva a intentar.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"EROR: {ex}");

            }
        }
    }
}
