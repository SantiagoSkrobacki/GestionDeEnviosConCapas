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
    public partial class BajaUsuario : FormBase
    {
        public BajaUsuario()
        {
            InitializeComponent();
        }

        BLL.Usuario bllusuario = new BLL.Usuario();
 

        private void eliminarBTN_Click_1(object sender, EventArgs e)
        {
            if (ValiacionesUtils.ValidarEntradaUsuario(this))
            {
                BE.Usuario usuario = new BE.Usuario();
                usuario.Id = Convert.ToInt32(controlId1.Texto);

                int fa = 0;
                fa = bllusuario.Eliminar(usuario);

                if (fa == 0)
                {
                    MessageBox.Show("Error: no se encontró usuario con el id = " + usuario.Id);
                }
                else
                {
                    MessageBox.Show("Usuario eliminado exitosamente");
                }


            }
            else
            {
                MessageBox.Show("Campos completados incorrectamente...\nPor favor vuelva a intentar.");
            }
        }
    }
}
