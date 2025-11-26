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
using BE;
using GestionDeEnvios.Controles;

namespace GestionDeEnvios.Login
{
    public partial class Registrarse : FormBase
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }
        BLL.Usuario bllusuario = new BLL.Usuario();
    
        private void registrarseBTN_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValiacionesUtils.ValidarEntradaUsuario(this))
                {

                    BE.Usuario usuario = new BE.Usuario()
                    {
                        Email = controlEmail1.Texto,
                        Password = controlContraseña1.Texto,
                        Nombre = controlNombre1.Texto,
                        Activo = true,
                        Telefono = controlTelefono1.Texto,
                        Domicilio = controlDomicilio1.Texto,
                        Localidad = controlLocalidad1.Texto,
                        Provincia = controlProvincia1.Texto,
                        CodigoPostal = controlCodigoPostal1.Texto,
                        Documento = controlDocumento1.Texto,
                        TipoUsuario = "Cliente"
                    };

                    bllusuario.Agregar(usuario);

                    MessageBox.Show("Usuario agregado con exito");

                }
                else
                {
                    MessageBox.Show("Campos completados incorrectamente...\nPor favor vuelva a intentar.");
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

        private void controlEmail1_Load(object sender, EventArgs e)
        {

        }
    }
}
