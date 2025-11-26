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
    public partial class ConsultarEnvioDestinatario : FormBase
    {

        BE.Usuario usuarioActual = new BE.Usuario();
        List<BE.Envio> listaEnvios = new List<BE.Envio>();
        BLL.Usuario bllUsuario = new BLL.Usuario();
        BLL.Envio bllenvio = new BLL.Envio();
        public ConsultarEnvioDestinatario(BE.Usuario usuario)
        {
            usuarioActual = usuario;    
            InitializeComponent();

            refrescarGrid();
        }


        private void refrescarGrid()
        {
           
            listaEnvios = bllenvio.ObtenerEnviosPorIdCliente(usuarioActual);
            enviosDGV.DataSource = listaEnvios;
            enviosDGV.Columns["Cliente"].Visible = false;
            enviosDGV.Columns["Repartidor"].Visible = false;
            enviosDGV.Columns["Destinatario"].Visible = false;
            enviosDGV.Columns["costo"].Visible = false;
            //  enviosDGV.Columns["fechaCreacion"].Visible = false;
            enviosDGV.Columns["fechaAsignacion"].Visible = false;
            // enviosDGV.Columns["fechaDespacho"].Visible = false;
            //enviosDGV.Columns["fechaEntrega"].Visible = false;
            //  enviosDGV.Columns["fechaCancelacion"].Visible = false;

            estado0FOT.Visible = false;
            estado1FOT.Visible = false;
            estado2FOT.Visible = false;
            estadoFOT3.Visible = false;
            estadoFOT4.Visible = false;
        }
        private void ConsultarEnvioDestinatario_Load(object sender, EventArgs e)
        {
           
        }
        BE.Envio envioSeleccionado;
        private void enviosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CargarOpcionesEstado(BE.Envio envio)
        {
            BE.EnumEstados estadoActual = envio.Estado;
            estadoLBL.Text = estadoActual.ToString();


            switch (estadoActual)
            {
                case BE.EnumEstados.Creado:
                case BE.EnumEstados.Asignado:
                    estado1FOT.Visible = true;
                    estado2FOT.Visible = false;
                    estadoFOT3.Visible = false;
                    estadoFOT4.Visible = false;
                    break;

                case BE.EnumEstados.EnCamino:
                    estado1FOT.Visible = false;
                    estado2FOT.Visible = true;
                    estadoFOT3.Visible = false;
                    estadoFOT4.Visible = false;
                    break;

                case BE.EnumEstados.Entregado:
                    estado1FOT.Visible = false;
                    estado2FOT.Visible = false;
                    estadoFOT3.Visible = true;
                    estadoFOT4.Visible = false;
                    break;

                case BE.EnumEstados.Cancelado:
                    estado1FOT.Visible = false;
                    estado2FOT.Visible = false;
                    estadoFOT3.Visible = false;
                    estadoFOT4.Visible = true;
                    break;
            }
        }

        private void enviosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                envioSeleccionado = (BE.Envio)enviosDGV.Rows[e.RowIndex].DataBoundItem;
                estadoLBL.Text = envioSeleccionado.Estado.ToString();
                CargarOpcionesEstado(envioSeleccionado);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            refrescarGrid();
        }
    }
}
