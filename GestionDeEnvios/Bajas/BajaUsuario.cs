using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeEnvios.Bajas
{
    public partial class BajaUsuario : Form
    {
        public BajaUsuario()
        {
            InitializeComponent();
        }

        BLL.Usuario bllusuario = new BLL.Usuario();
        private void eliminarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlId1.ValidarRegex())
                {
                    BE.Usuario usuario = new BE.Usuario();
                    usuario.Id = Convert.ToInt32(controlId1.Texto);
                    bllusuario.Eliminar(usuario);
                    MessageBox.Show("Usuario eliminado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                throw;
            }
        }
    }
}
