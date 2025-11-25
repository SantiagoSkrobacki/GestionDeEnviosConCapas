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
using GestionDeEnvios.Controles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BE;

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
                if (ValiacionesUtils.ValidarEntradaUsuario(this) && tipoUsuarioCOMBOBOX.Items != null)
                {
                    

                    BE.Usuario usuario = new BE.Usuario()
                    {
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



                    bllusuario.Agregar(usuario);
                  
                    MessageBox.Show("Usuario agregado con exito"); // No uso int fa porque un insert no puede devolver 0, devuelve error unicamente
                    
                }
                else
                {
                    MessageBox.Show("Campos completados incorrectamente...\nPor favor vuelva a intentar.");
                }
            }
            catch (Exception ex)
            {
                if(ex is SqlException sqlEx && sqlEx.Number == (int)SqlErrorCode.UniqueConstraint)
                {
                    MessageBox.Show("Error, el mail utilizado ya posee un usuario asociado");
                }
                else
                {
                    MessageBox.Show($"EROR: {ex}");
                }
            }

        }
                
        
        private void AltaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
