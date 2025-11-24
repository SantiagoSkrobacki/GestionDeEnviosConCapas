using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeEnvios.Login
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }
        BLL.Usuario bllusuario = new BLL.Usuario();
        private void registrarseBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlCodigoPostal1.ValidarRegex() && controlContraseña1.ValidarRegex() && controlDocumento1.ValidarRegex() && controlDomicilio1.ValidarRegex()
                    && controlEmail1.ValidarRegex() && controlLocalidad1.ValidarRegex() && controlNombre1.ValidarRegex() && controlProvincia1.ValidarRegex() && controlTelefono1.ValidarRegex())
                {
                    int fa = 0;
                    BE.Usuario usuario = new BE.Usuario(controlEmail1.Texto, controlContraseña1.Texto, controlNombre1.Texto, true , true , controlTelefono1.Texto, controlDomicilio1.Texto,
                        controlLocalidad1.Texto, controlProvincia1.Texto, controlCodigoPostal1.Texto, controlDocumento1.Texto, "Cliente");
                    fa = bllusuario.Agregar(usuario);
                    if (fa == -1)
                    {
                        MessageBox.Show("Error, ese mail ya existe");
                    }
                    else
                    {
                        MessageBox.Show("Usuario agregado con exito");
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
