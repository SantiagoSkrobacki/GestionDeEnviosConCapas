namespace GestionDeEnvios.Login
{
    partial class Registrarse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registrarseBTN = new System.Windows.Forms.Button();
            this.controlDocumento1 = new GestionDeEnvios.Controles.ControlDocumento();
            this.controlCodigoPostal1 = new GestionDeEnvios.Controles.ControlCodigoPostal();
            this.controlProvincia1 = new GestionDeEnvios.Controles.ControlProvincia();
            this.controlLocalidad1 = new GestionDeEnvios.Controles.ControlLocalidad();
            this.controlDomicilio1 = new GestionDeEnvios.Controles.ControlDomicilio();
            this.controlTelefono1 = new GestionDeEnvios.Controles.ControlTelefono();
            this.controlNombre1 = new GestionDeEnvios.Controles.ControlNombre();
            this.controlContraseña1 = new GestionDeEnvios.Controles.ControlContraseña();
            this.controlEmail1 = new GestionDeEnvios.Controles.ControlEmail();
            this.SuspendLayout();
            // 
            // registrarseBTN
            // 
            this.registrarseBTN.Location = new System.Drawing.Point(199, 500);
            this.registrarseBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrarseBTN.Name = "registrarseBTN";
            this.registrarseBTN.Size = new System.Drawing.Size(267, 76);
            this.registrarseBTN.TabIndex = 27;
            this.registrarseBTN.Text = "Registrarse";
            this.registrarseBTN.UseVisualStyleBackColor = true;
            this.registrarseBTN.Click += new System.EventHandler(this.registrarseBTN_Click);
            // 
            // controlDocumento1
            // 
            this.controlDocumento1.Etiqueta = "Documento";
            this.controlDocumento1.Location = new System.Drawing.Point(16, 416);
            this.controlDocumento1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlDocumento1.Name = "controlDocumento1";
            this.controlDocumento1.Size = new System.Drawing.Size(733, 53);
            this.controlDocumento1.TabIndex = 23;
            this.controlDocumento1.Texto = "";
            // 
            // controlCodigoPostal1
            // 
            this.controlCodigoPostal1.Etiqueta = "Codigo Postal";
            this.controlCodigoPostal1.Location = new System.Drawing.Point(16, 370);
            this.controlCodigoPostal1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlCodigoPostal1.Name = "controlCodigoPostal1";
            this.controlCodigoPostal1.Size = new System.Drawing.Size(733, 53);
            this.controlCodigoPostal1.TabIndex = 22;
            this.controlCodigoPostal1.Texto = "";
            // 
            // controlProvincia1
            // 
            this.controlProvincia1.Etiqueta = "Provincia";
            this.controlProvincia1.Location = new System.Drawing.Point(16, 315);
            this.controlProvincia1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlProvincia1.Name = "controlProvincia1";
            this.controlProvincia1.Size = new System.Drawing.Size(733, 53);
            this.controlProvincia1.TabIndex = 21;
            this.controlProvincia1.Texto = "";
            // 
            // controlLocalidad1
            // 
            this.controlLocalidad1.Etiqueta = "Localidad";
            this.controlLocalidad1.Location = new System.Drawing.Point(16, 266);
            this.controlLocalidad1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlLocalidad1.Name = "controlLocalidad1";
            this.controlLocalidad1.Size = new System.Drawing.Size(733, 53);
            this.controlLocalidad1.TabIndex = 20;
            this.controlLocalidad1.Texto = "";
            // 
            // controlDomicilio1
            // 
            this.controlDomicilio1.Etiqueta = "Domicilio";
            this.controlDomicilio1.Location = new System.Drawing.Point(16, 217);
            this.controlDomicilio1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlDomicilio1.Name = "controlDomicilio1";
            this.controlDomicilio1.Size = new System.Drawing.Size(733, 53);
            this.controlDomicilio1.TabIndex = 19;
            this.controlDomicilio1.Texto = "";
            // 
            // controlTelefono1
            // 
            this.controlTelefono1.Etiqueta = "Telefono";
            this.controlTelefono1.Location = new System.Drawing.Point(16, 169);
            this.controlTelefono1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlTelefono1.Name = "controlTelefono1";
            this.controlTelefono1.Size = new System.Drawing.Size(733, 53);
            this.controlTelefono1.TabIndex = 18;
            this.controlTelefono1.Texto = "";
            // 
            // controlNombre1
            // 
            this.controlNombre1.Etiqueta = "Nombre";
            this.controlNombre1.Location = new System.Drawing.Point(16, 114);
            this.controlNombre1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlNombre1.Name = "controlNombre1";
            this.controlNombre1.Size = new System.Drawing.Size(733, 53);
            this.controlNombre1.TabIndex = 17;
            this.controlNombre1.Texto = "";
            // 
            // controlContraseña1
            // 
            this.controlContraseña1.Etiqueta = "Contraseña";
            this.controlContraseña1.Location = new System.Drawing.Point(16, 69);
            this.controlContraseña1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlContraseña1.Name = "controlContraseña1";
            this.controlContraseña1.Size = new System.Drawing.Size(733, 53);
            this.controlContraseña1.TabIndex = 16;
            this.controlContraseña1.Texto = "";
            // 
            // controlEmail1
            // 
            this.controlEmail1.Etiqueta = "Email";
            this.controlEmail1.Location = new System.Drawing.Point(16, 18);
            this.controlEmail1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlEmail1.Name = "controlEmail1";
            this.controlEmail1.Size = new System.Drawing.Size(733, 53);
            this.controlEmail1.TabIndex = 15;
            this.controlEmail1.Texto = "";
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 589);
            this.Controls.Add(this.registrarseBTN);
            this.Controls.Add(this.controlDocumento1);
            this.Controls.Add(this.controlCodigoPostal1);
            this.Controls.Add(this.controlProvincia1);
            this.Controls.Add(this.controlLocalidad1);
            this.Controls.Add(this.controlDomicilio1);
            this.Controls.Add(this.controlTelefono1);
            this.Controls.Add(this.controlNombre1);
            this.Controls.Add(this.controlContraseña1);
            this.Controls.Add(this.controlEmail1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registrarseBTN;
        private Controles.ControlDocumento controlDocumento1;
        private Controles.ControlCodigoPostal controlCodigoPostal1;
        private Controles.ControlProvincia controlProvincia1;
        private Controles.ControlLocalidad controlLocalidad1;
        private Controles.ControlDomicilio controlDomicilio1;
        private Controles.ControlTelefono controlTelefono1;
        private Controles.ControlNombre controlNombre1;
        private Controles.ControlContraseña controlContraseña1;
        private Controles.ControlEmail controlEmail1;
    }
}