using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeEnvios.Modificaciones
{
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }
        BLL.Usuario bllusuario = new BLL.Usuario();
        private void modificarUsuarioBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlId1.ValidarRegex() && controlCodigoPostal1.ValidarRegex() && controlContraseña1.ValidarRegex() && controlDocumento1.ValidarRegex() && controlDomicilio1.ValidarRegex()
                    && controlEmail1.ValidarRegex() && controlLocalidad1.ValidarRegex() && controlNombre1.ValidarRegex() && controlProvincia1.ValidarRegex() && controlTelefono1.ValidarRegex() &&
                    tipoUsuarioCOMBOBOX.Items != null)
                {
                    int fa = 0;
                    BE.Usuario usuario = new BE.Usuario(controlEmail1.Texto, controlContraseña1.Texto, controlNombre1.Texto, activoBOX.Checked, disponibleBOX.Checked, controlTelefono1.Texto, controlDomicilio1.Texto,
                        controlLocalidad1.Texto, controlProvincia1.Texto, controlCodigoPostal1.Texto, controlDocumento1.Texto, tipoUsuarioCOMBOBOX.Text);
                    usuario.Id = Convert.ToInt32(controlId1.Texto);
                    fa = bllusuario.Editar(usuario);
                    if (fa == -1)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        MessageBox.Show("Usuario modificado con exito");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
