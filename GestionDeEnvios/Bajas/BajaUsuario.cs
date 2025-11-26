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
                CargarDGVa();
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

        private void BajaUsuario_Load(object sender, EventArgs e)
        {
            CargarDGVa();
        }

        private void usuariosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = usuariosDGV.Rows[e.RowIndex];

                controlId1.Texto = row.Cells[0].Value.ToString();
            }
        }

        private void CargarDGVa()
        {
            usuariosDGV.DataSource = null;
            usuariosDGV.DataSource = bllusuario.ObtenerTodosLosUsuariosActivos();
        }

        private void controlId1_Load(object sender, EventArgs e)
        {

        }
    }
}
