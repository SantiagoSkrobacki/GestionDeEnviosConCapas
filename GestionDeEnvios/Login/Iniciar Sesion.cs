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
    public partial class Iniciar_Sesion : FormBase
    {
        public Iniciar_Sesion()
        {
            InitializeComponent();
        }

        BLL.Usuario bllusuario = new BLL.Usuario();
   
        public event Action<BE.Usuario> OnLoginExitoso;
    
        private void iniciarSesionBTN_Click_1(object sender, EventArgs e)
        {
            BE.Usuario usuario = bllusuario.Login(controlEmail1.Texto, controlContraseña1.Texto);

            if (usuario != null)
            {
                // 2. DISPARAR EL EVENTO

                OnLoginExitoso?.Invoke(usuario);

                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void registrarseBTN_Click_1(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.MdiParent = this.MdiParent;
            registrarse.Show();
        }
    }
}
