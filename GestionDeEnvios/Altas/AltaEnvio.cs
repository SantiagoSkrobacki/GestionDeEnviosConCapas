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

namespace GestionDeEnvios.Altas
{
    public partial class AltaEnvio : FormBase
    {
        public AltaEnvio()
        {
            InitializeComponent();
            cargarDgvClientes();
            cargarDgvDestinatarios();

        }
        BLL.Usuario bllUsuario = new BLL.Usuario();
        BLL.Envio bllEnvio = new BLL.Envio();   
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AltaEnvio_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValiacionesUtils.ValidarEntradaUsuario(this))
                {
                    BE.Envio envio = new BE.Envio();

                    envio.Cliente.Id = int.Parse(controlIdCliente.Texto);
                    envio.Destinatario.Id = int.Parse(controlIdDestinatario.Texto);

                    bllEnvio.Agregar(envio);

                    MessageBox.Show("Envío agregado con exito"); 

                }
                else
                {
                    MessageBox.Show("Campos completados incorrectamente...\nPor favor vuelva a intentar.");
                }
            }
            catch (Exception ex)
            {

                    MessageBox.Show($"EROR: {ex}");
                
            }

        }
        
        private void cargarDgvClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = bllUsuario.ObtenerClientesActivos();
            dgvClientes.Columns["Password"].Visible = false;
            dgvClientes.Columns["TipoUsuario"].Visible = false;
            dgvClientes.Columns["ACtivo"].Visible = false;


        }
        private void cargarDgvDestinatarios()
        {
            dgvDestinatarios.DataSource = null;
            dgvDestinatarios.DataSource = bllUsuario.ObtenerDestinatariosActivos();
            dgvDestinatarios.Columns["Password"].Visible = false;
            dgvDestinatarios.Columns["TipoUsuario"].Visible = false;
            dgvDestinatarios.Columns["ACtivo"].Visible = false;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Usuario tmpUsuario = (BE.Usuario)dgvClientes.Rows[e.RowIndex].DataBoundItem;
            controlIdCliente.Texto = tmpUsuario.Id.ToString();
        }

        private void dgvDestinatarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Usuario tmpUsuario = (BE.Usuario)dgvDestinatarios.Rows[e.RowIndex].DataBoundItem;
            controlIdDestinatario.Texto = tmpUsuario.Id.ToString();
        }
    }
}
