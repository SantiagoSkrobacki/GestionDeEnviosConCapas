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
        
        private BE.Envio envioActual = new BE.Envio();
        public ConsultarEnviosRepartidor(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();

            RefrescarDataGrid();
            estado0FOT.Visible = false;
            estado1FOT.Visible = false;
            estado2FOT.Visible = false;
            estadoFOT3.Visible = false;
            estadoFOT4.Visible = false;
        }

        List<BE.Envio> listaEnvios = new List<BE.Envio>();
        private void ConsultarEnviosRepartidor_Load(object sender, EventArgs e)
        {

           
        }

      
        private void enviosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void CargarOpcionesEstado(BE.Envio envio)
        {
            BE.EnumEstados estadoActual = envio.Estado;
            ComboBoxEstados.Items.Clear();
            ComboBoxEstados.Text = "";
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
                    ComboBoxEstados.Items.Add(BE.EnumEstados.EnCamino.ToString());
                    ComboBoxEstados.Items.Add(BE.EnumEstados.Cancelado.ToString());
                    estado0FOT.Visible = false;
                    estado1FOT.Visible = true;
                    estado2FOT.Visible = false;
                    estadoFOT3.Visible = false;
                    estadoFOT4.Visible = false;
                    break;

                case BE.EnumEstados.EnCamino:
                    ComboBoxEstados.Items.Add(BE.EnumEstados.Entregado.ToString());
                    ComboBoxEstados.Items.Add(BE.EnumEstados.Cancelado.ToString());
                    estado0FOT.Visible = false;
                    estado1FOT.Visible = false;
                    estado2FOT.Visible = true;
                    estadoFOT3.Visible = false;
                    estadoFOT4.Visible = false;
                    break;

                case BE.EnumEstados.Entregado:
                    estado0FOT.Visible = false;
                    estado1FOT.Visible = false;
                    estado2FOT.Visible = false;
                    estadoFOT3.Visible = true;
                    estadoFOT4.Visible = false;
                    break;

                case BE.EnumEstados.Cancelado:
                    estado0FOT.Visible = false;
                    estado1FOT.Visible = false;
                    estado2FOT.Visible = false;
                    estadoFOT3.Visible = false;
                    estadoFOT4.Visible = true;
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
                if (envioActual != null)
                {
                   

                    if(ComboBoxEstados.Text != "")
                    {
                        BE.EnumEstados nuevoEstado = (BE.EnumEstados)Enum.Parse(typeof(BE.EnumEstados), ComboBoxEstados.Text);


                        bllenvio.CambiarEstado(envioActual.CodigoSeguimiento, nuevoEstado);

                        string nuevoEstadoString = nuevoEstado.ToString();

                        estadoLBL.Text = nuevoEstadoString;

                        envioActual.Estado = nuevoEstado;

                        CargarOpcionesEstado(envioActual);

                        if (nuevoEstadoString == "Asignado")



                            MessageBox.Show("Estado actualizado correctamente.");

                        RefrescarDataGrid();
                        
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione un Estado primero.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un envio primero.");
                }
                    


            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: "+ ex);
            }
        }

        private void RefrescarDataGrid()
        {
            enviosDGV.DataSource = null;
            enviosDGV.DataSource = bllenvio.ObtenerEnviosPorIdRepartidor(usuarioActual);
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

        private void enviosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BE.Envio envioTmp = new BE.Envio();
                envioTmp = (BE.Envio)enviosDGV.Rows[e.RowIndex].DataBoundItem;
                envioActual = envioTmp;

                estadoLBL.Text = envioTmp.Estado.ToString();
                CargarOpcionesEstado(envioTmp);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefrescarDataGrid();
        }
    }
}

