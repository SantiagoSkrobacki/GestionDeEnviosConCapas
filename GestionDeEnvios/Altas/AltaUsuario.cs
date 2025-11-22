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
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        BLL.Usuario bllusuario = new BLL.Usuario();
        private void agregarUsuarioBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if(controlCodigoPostal1.ValidarRegex()&&controlContraseña1.ValidarRegex()&&controlDocumento1.ValidarRegex()&&controlDomicilio1.ValidarRegex()
                    &&controlEmail1.ValidarRegex()&&controlLocalidad1.ValidarRegex()&&controlNombre1.ValidarRegex()&&controlProvincia1.ValidarRegex()&&controlTelefono1.ValidarRegex()&&
                    tipoUsuarioCOMBOBOX.Items != null)
                {
                    BE.Usuario usuario = new BE.Usuario();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
