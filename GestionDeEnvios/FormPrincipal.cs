﻿using System;
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
using GestionDeEnvios.Modificaciones;

namespace GestionDeEnvios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

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
            ConsultarEnviosCliente consultarEnviosCliente = new ConsultarEnviosCliente();
            consultarEnviosCliente.MdiParent = this;
            consultarEnviosCliente.Show();
        }

        private void consultarEnvioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarEnviosRepartidor consultarEnvioRepartidor = new ConsultarEnviosRepartidor();
            consultarEnvioRepartidor.MdiParent = this;
            consultarEnvioRepartidor.Show();
        }
    }
}
