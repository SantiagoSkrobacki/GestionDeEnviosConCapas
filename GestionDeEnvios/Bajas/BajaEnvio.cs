using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeEnvios.Controles;

namespace GestionDeEnvios.Bajas
{
    public partial class BajaEnvio : FormBase
    {
        public BajaEnvio()
        {
            InitializeComponent();
            CargarDGgv();
        }

        BLL.Envio bllEnvio = new BLL.Envio();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValiacionesUtils.ValidarEntradaUsuario(this))
            {
                BE.Envio envio = new BE.Envio();
                envio.CodigoSeguimiento = Convert.ToInt32(controlIdEnvio.Texto);

                int fa = 0;
                fa = bllEnvio.Eliminar(envio);
                CargarDGgv();
                if (fa == 0)
                {
                    MessageBox.Show("Error: no se encontró envio con el id = " + envio.CodigoSeguimiento);
                }
                else
                {
                    MessageBox.Show("Envio eliminado exitosamente");
                }


            }
            else
            {
                MessageBox.Show("Campos completados incorrectamente...\nPor favor vuelva a intentar.");
            }

    
        }

        private void CargarDGgv()
        {
            enviosDGV.DataSource = bllEnvio.ObtenerTodosLosEnvios();
            enviosDGV.Columns["Cliente"].Visible = false;
            enviosDGV.Columns["Repartidor"].Visible = false;
            enviosDGV.Columns["Destinatario"].Visible = false;
            enviosDGV.Columns["fechaCreacion"].Visible = false;
            enviosDGV.Columns["fechaAsignacion"].Visible = false;
            enviosDGV.Columns["fechaDespacho"].Visible = false;
            enviosDGV.Columns["fechaEntrega"].Visible = false;
            enviosDGV.Columns["fechaCancelacion"].Visible = false;
        }

        private void enviosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Envio envio = (BE.Envio)enviosDGV.Rows[e.RowIndex].DataBoundItem;

            controlIdEnvio.Texto = envio.CodigoSeguimiento.ToString();
        }
    }
}
