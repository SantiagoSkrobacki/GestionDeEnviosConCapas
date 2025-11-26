using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeEnvios.Altas;
using GestionDeEnvios.Bajas;
using GestionDeEnvios.Login;
using GestionDeEnvios.Modificaciones;

namespace GestionDeEnvios
{
    public partial class FormPrincipal : FormBase
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        BE.Usuario usuarioActual = new BE.Usuario();
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaEnvio altaEnvio = new AltaEnvio();
            altaEnvio.MdiParent = this;
            altaEnvio.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEnvio modificarEnvio = new ModificarEnvio();
            modificarEnvio.MdiParent = this;
            modificarEnvio.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BajaEnvio bajaEnvio = new BajaEnvio();
            bajaEnvio.MdiParent = this;
            bajaEnvio.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuario = new AltaUsuario();
            altaUsuario.MdiParent = this;
            altaUsuario.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarUsuario modificarUsuario = new ModificarUsuario();
            modificarUsuario.MdiParent = this;
            modificarUsuario.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BajaUsuario bajaUsuario = new BajaUsuario();
            bajaUsuario.MdiParent = this;
            bajaUsuario.Show();
        }

        private void consultarEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEnviosCliente consultarEnviosCliente = new ConsultarEnviosCliente(usuarioActual);
            consultarEnviosCliente.MdiParent = this;
            consultarEnviosCliente.Show();
        }

        private void consultarEnvioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarEnviosRepartidor consultarEnvioRepartidor = new ConsultarEnviosRepartidor(usuarioActual);
            consultarEnvioRepartidor.MdiParent = this;
            consultarEnvioRepartidor.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            OcultarBotones();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iniciar_Sesion iniciar_Sesion = new Iniciar_Sesion();
            iniciar_Sesion.MdiParent = this;
            iniciar_Sesion.Show();
            iniciar_Sesion.OnLoginExitoso += ConfigurarPermisos;
        }

        private void ConfigurarPermisos(BE.Usuario usuario1)
        {
            usuarioActual = usuario1;
            // SWITCH POR ROLES
            switch (usuario1.TipoUsuario)
            {
                case "Administrador":
                    envioToolStripMenuItem.Visible = true;
                    usuariosToolStripMenuItem.Visible = true;
                    clienteToolStripMenuItem.Visible = true;
                    repartidorToolStripMenuItem.Visible = true;
                    break;

                case "Cliente":
                    clienteToolStripMenuItem.Visible = true;
                    break;

                case "Repartidor":
                    repartidorToolStripMenuItem.Visible = true;
                    break;
                case "Destinatario":
                    destinatarioToolStripMenuItem.Visible = true;
                    break;
            }

        }

        private void OcultarBotones()
        {
            envioToolStripMenuItem.Visible = false;
            usuariosToolStripMenuItem.Visible = false;
            clienteToolStripMenuItem.Visible = false;
            repartidorToolStripMenuItem.Visible = false;
            destinatarioToolStripMenuItem.Visible = false;
        }

        private void envioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarEnvioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultarEnvioDestinatario consultarEnvioDestinatario = new ConsultarEnvioDestinatario(usuarioActual);
            consultarEnvioDestinatario.MdiParent = this;
            consultarEnvioDestinatario.Show();
        }

        private void generarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarXMLUsuario generarXML = new GenerarXMLUsuario();
            generarXML.MdiParent = this;
            generarXML.Show();
        }
    }
}
