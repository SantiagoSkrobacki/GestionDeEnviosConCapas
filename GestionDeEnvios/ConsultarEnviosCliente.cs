using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ComponentFactory.Krypton.Toolkit;

namespace GestionDeEnvios
{
    public partial class ConsultarEnviosCliente : FormBase
    {

        BE.Usuario usuarioActual = new BE.Usuario();    
        public List<BE.Envio> listaEnvios = new List<BE.Envio>();
        BLL.Usuario bllUsuario = new BLL.Usuario();
        BLL.Envio bllenvio = new BLL.Envio();
        public ConsultarEnviosCliente(BE.Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        private void ConsultarEnviosCliente_Load(object sender, EventArgs e)
        {
            listaEnvios = bllenvio.ObtenerEnviosPorIdCliente(usuarioActual);
            enviosDGV.DataSource = listaEnvios;
            enviosDGV.Columns["Cliente"].Visible = false;
            enviosDGV.Columns["Repartidor"].Visible = false;
            enviosDGV.Columns["Destinatario"].Visible = false;
            enviosDGV.Columns["fechaCreacion"].Visible = false;
            enviosDGV.Columns["fechaAsignacion"].Visible = false;
            enviosDGV.Columns["fechaDespacho"].Visible = false;
            enviosDGV.Columns["fechaEntrega"].Visible = false;
            enviosDGV.Columns["fechaCancelacion"].Visible = false;

            estado0FOT.Visible = false;
            estado1FOT.Visible = false;
            estado2FOT.Visible = false;
            estadoFOT3.Visible = false;
            estadoFOT4.Visible = false;
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
            estadoLBL.Text = estadoActual.ToString();


            switch (estadoActual)
            {
                case BE.EnumEstados.Creado:
                    estado0FOT.Visible = true;
                    estado1FOT.Visible = false;
                    estado2FOT.Visible = false;
                    estadoFOT3.Visible = false;
                    estadoFOT4.Visible = false;
                    break;
                case BE.EnumEstados.Asignado:
                    estado1FOT.Visible = true;
                    estado2FOT.Visible = false;
                    estadoFOT3.Visible = false;
                    estadoFOT4.Visible = false;

                    break;

                case BE.EnumEstados.EnCamino:
                    estado2FOT.Visible = true;
                    estadoFOT3.Visible = false;
                    estadoFOT4.Visible = false;
                    break;

                case BE.EnumEstados.Entregado:
                    estadoFOT3.Visible = true;
                    estadoFOT4.Visible = false;
                    break;

                case BE.EnumEstados.Cancelado:
                    estadoFOT4.Visible = true;
                    break;
            }
        }
    }
}
