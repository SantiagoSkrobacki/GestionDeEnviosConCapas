using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BE;
using GestionDeEnvios.Controles;

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
                if (ValiacionesUtils.ValidarEntradaUsuario(this) && tipoUsuarioCOMBOBOX.Items != null)
                {
                    int fa = 0;

                    BE.Usuario usuario = new BE.Usuario()
                    {
                        Id = int.Parse(controlId1.Texto),
                        Email = controlEmail1.Texto,
                        Password = controlContraseña1.Texto,
                        Nombre = controlNombre1.Texto,
                        Activo = activoBOX.Checked,
                        Disponible = disponibleBOX.Checked,
                        Telefono = controlTelefono1.Texto,
                        Domicilio = controlDomicilio1.Texto,
                        Localidad = controlLocalidad1.Texto,
                        Provincia = controlProvincia1.Texto,
                        CodigoPostal = controlCodigoPostal1.Texto,
                        Documento = controlDocumento1.Texto,
                        TipoUsuario = tipoUsuarioCOMBOBOX.Text
                    };
                      
                   
                    
                    fa = bllusuario.Editar(usuario);
                    if (fa == 0)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        MessageBox.Show("Usuario modificado con exito");
                    }
                }
            }
            catch (Exception ex)
            {

                if (ex is SqlException sqlEx && sqlEx.Number == (int)SqlErrorCode.UniqueConstraint)
                {
                    MessageBox.Show("Error, el mail utilizado ya posee un usuario asociado");
                }
                else
                {
                    MessageBox.Show($"EROR: {ex}");
                }
            }
        }
    }
}
