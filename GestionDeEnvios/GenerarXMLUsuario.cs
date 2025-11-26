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
    public partial class GenerarXMLUsuario : FormBase
    {
        public GenerarXMLUsuario()
        {
            InitializeComponent();
        }

        BLL.Usuario bllusuario = new BLL.Usuario();
        private void GenerarXMLUsuario_Load(object sender, EventArgs e)
        {
            usuariosDGV.DataSource = bllusuario.ObtenerTodosLosUsuarios();
        }

        private void generarXMLBTN_Click(object sender, EventArgs e)
        {
            bllusuario.EscribirUsuariosXML();
            MessageBox.Show("XML Escrito Correctamente");
        }
    }
}
