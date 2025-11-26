using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace GestionDeEnvios
{
    public partial class ConsultarEnviosRepartidor : FormBase
    {
        BE.Usuario usuarioActual = new BE.Usuario();
        BLL.Usuario bllusuario = new BLL.Usuario();
        BLL.Envio bllenvio = new BLL.Envio();
        BLL.ItemPaquete bllItempaquete = new BLL.ItemPaquete();
        public ConsultarEnviosRepartidor(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        List<BE.Envio> listaEnvios = new List<BE.Envio>();
        private void ConsultarEnviosRepartidor_Load(object sender, EventArgs e)
        {
            listaEnvios = bllusuario.ObtenerEnviosPorIdRepartidor(usuarioActual);
            enviosDGV.DataSource = listaEnvios;
            RefrescarDataGrid();
        }

        BE.Envio envioSeleccionado;
        private void enviosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                envioSeleccionado = (BE.Envio)enviosDGV.Rows[e.RowIndex].DataBoundItem;
                estadoLBL.Text = envioSeleccionado.Estado.ToString();
                CargarOpcionesEstado(envioSeleccionado);
            }
        }

        private void CargarOpcionesEstado(BE.Envio envio)
        {
            BE.EnumEstados estadoActual = envio.Estado;
            kryptonComboBox1.Items.Clear();
            kryptonComboBox1.Text = "";
            estadoLBL.Text = estadoActual.ToString();


            switch (estadoActual)
            {
                case BE.EnumEstados.Creado:
                case BE.EnumEstados.Asignado:
                    kryptonComboBox1.Items.Add(BE.EnumEstados.EnCamino.ToString());
                    kryptonComboBox1.Items.Add(BE.EnumEstados.Cancelado.ToString());
                    break;

                case BE.EnumEstados.EnCamino:
                    kryptonComboBox1.Items.Add(BE.EnumEstados.Entregado.ToString());
                    kryptonComboBox1.Items.Add(BE.EnumEstados.Cancelado.ToString());
                    break;

                case BE.EnumEstados.Entregado:
                    kryptonComboBox1.Items.Add(BE.EnumEstados.Cancelado.ToString());
                    break;

                case BE.EnumEstados.Cancelado:
                    kryptonComboBox1.Enabled = false; 
                    break;
            }
        }

        private void iniciarSesionBTN_Click(object sender, EventArgs e)
        {
          
        }

        private void cambiarEstadoBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (envioSeleccionado == null) return;

                // 1. Obtener el estado del combo
                BE.EnumEstados nuevoEstado = (BE.EnumEstados)Enum.Parse(typeof(BE.EnumEstados), kryptonComboBox1.Text);

                // 2. Mandar la orden 
                bllenvio.CambiarEstado(envioSeleccionado.CodigoSeguimiento, nuevoEstado);

                MessageBox.Show("Estado actualizado correctamente.");

                // 3. Recargar la grilla 
                RefrescarDataGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void RefrescarDataGrid()
        {
            enviosDGV.DataSource = null;
            BLL.Envio bll = new BLL.Envio();
            enviosDGV.DataSource = bllusuario.ObtenerEnviosPorIdRepartidor(usuarioActual);
            enviosDGV.Columns["Cliente"].Visible = false;
            enviosDGV.Columns["Repartidor"].Visible = false;
            enviosDGV.Columns["Destinatario"].Visible = false;
            enviosDGV.Columns["fechaCreacion"].Visible = false;
            enviosDGV.Columns["fechaAsignacion"].Visible = false;
            enviosDGV.Columns["fechaDespacho"].Visible = false;
            enviosDGV.Columns["fechaEntrega"].Visible = false;
            enviosDGV.Columns["fechaCancelacion"].Visible = false;
        }

        private void escribirXMLBTN_Click(object sender, EventArgs e)
        {
                       
        }
    }
}

