namespace GestionDeEnvios
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPaquetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPaqueteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosLosEnviosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repartidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEnvioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.destinatarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEnvioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.envioToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.repartidorToolStripMenuItem,
            this.destinatarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // envioToolStripMenuItem
            // 
            this.envioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.agregarPaquetesToolStripMenuItem,
            this.asignarEnvioToolStripMenuItem,
            this.eliminarPaqueteToolStripMenuItem,
            this.verTodosLosEnviosToolStripMenuItem});
            this.envioToolStripMenuItem.Name = "envioToolStripMenuItem";
            this.envioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.envioToolStripMenuItem.Text = "Envio";
            this.envioToolStripMenuItem.Click += new System.EventHandler(this.envioToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar Envio";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // agregarPaquetesToolStripMenuItem
            // 
            this.agregarPaquetesToolStripMenuItem.Name = "agregarPaquetesToolStripMenuItem";
            this.agregarPaquetesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.agregarPaquetesToolStripMenuItem.Text = "Agregar Paquetes";
            this.agregarPaquetesToolStripMenuItem.Click += new System.EventHandler(this.agregarPaquetesToolStripMenuItem_Click);
            // 
            // asignarEnvioToolStripMenuItem
            // 
            this.asignarEnvioToolStripMenuItem.Name = "asignarEnvioToolStripMenuItem";
            this.asignarEnvioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.asignarEnvioToolStripMenuItem.Text = "Asignar Envio";
            this.asignarEnvioToolStripMenuItem.Click += new System.EventHandler(this.asignarEnvioToolStripMenuItem_Click);
            // 
            // eliminarPaqueteToolStripMenuItem
            // 
            this.eliminarPaqueteToolStripMenuItem.Name = "eliminarPaqueteToolStripMenuItem";
            this.eliminarPaqueteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.eliminarPaqueteToolStripMenuItem.Text = "Eliminar Paquete";
            this.eliminarPaqueteToolStripMenuItem.Click += new System.EventHandler(this.eliminarPaqueteToolStripMenuItem_Click);
            // 
            // verTodosLosEnviosToolStripMenuItem
            // 
            this.verTodosLosEnviosToolStripMenuItem.Name = "verTodosLosEnviosToolStripMenuItem";
            this.verTodosLosEnviosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.verTodosLosEnviosToolStripMenuItem.Text = "Ver Todos Los Envios";
            this.verTodosLosEnviosToolStripMenuItem.Click += new System.EventHandler(this.verTodosLosEnviosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1,
            this.generarXMLToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // generarXMLToolStripMenuItem
            // 
            this.generarXMLToolStripMenuItem.Name = "generarXMLToolStripMenuItem";
            this.generarXMLToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.generarXMLToolStripMenuItem.Text = "Generar XML";
            this.generarXMLToolStripMenuItem.Click += new System.EventHandler(this.generarXMLToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEnvioToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // consultarEnvioToolStripMenuItem
            // 
            this.consultarEnvioToolStripMenuItem.Name = "consultarEnvioToolStripMenuItem";
            this.consultarEnvioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarEnvioToolStripMenuItem.Text = "Consultar Envio";
            this.consultarEnvioToolStripMenuItem.Click += new System.EventHandler(this.consultarEnvioToolStripMenuItem_Click);
            // 
            // repartidorToolStripMenuItem
            // 
            this.repartidorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEnvioToolStripMenuItem1});
            this.repartidorToolStripMenuItem.Name = "repartidorToolStripMenuItem";
            this.repartidorToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.repartidorToolStripMenuItem.Text = "Repartidor";
            // 
            // consultarEnvioToolStripMenuItem1
            // 
            this.consultarEnvioToolStripMenuItem1.Name = "consultarEnvioToolStripMenuItem1";
            this.consultarEnvioToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.consultarEnvioToolStripMenuItem1.Text = "Consultar Envio";
            this.consultarEnvioToolStripMenuItem1.Click += new System.EventHandler(this.consultarEnvioToolStripMenuItem1_Click);
            // 
            // destinatarioToolStripMenuItem
            // 
            this.destinatarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEnvioToolStripMenuItem2});
            this.destinatarioToolStripMenuItem.Name = "destinatarioToolStripMenuItem";
            this.destinatarioToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.destinatarioToolStripMenuItem.Text = "Destinatario";
            // 
            // consultarEnvioToolStripMenuItem2
            // 
            this.consultarEnvioToolStripMenuItem2.Name = "consultarEnvioToolStripMenuItem2";
            this.consultarEnvioToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.consultarEnvioToolStripMenuItem2.Text = "Consultar Envio";
            this.consultarEnvioToolStripMenuItem2.Click += new System.EventHandler(this.consultarEnvioToolStripMenuItem2_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 815);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem envioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEnvioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repartidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEnvioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem destinatarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPaquetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarEnvioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPaqueteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEnvioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem generarXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodosLosEnviosToolStripMenuItem;
    }
}

