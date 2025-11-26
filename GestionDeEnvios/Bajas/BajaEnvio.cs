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
    public partial class BajaEnvio : FormBase
    {
        public BajaEnvio()
        {
            InitializeComponent();
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
               // CargarDGVa();
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
    }
}
