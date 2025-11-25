namespace GestionDeEnvios
{
    partial class AltaUsuario
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
            this.activoBOX = new System.Windows.Forms.CheckBox();
            this.tipoUsuarioCOMBOBOX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controlDocumento1 = new GestionDeEnvios.Controles.ControlDocumento();
            this.controlCodigoPostal1 = new GestionDeEnvios.Controles.ControlCodigoPostal();
            this.controlProvincia1 = new GestionDeEnvios.Controles.ControlProvincia();
            this.controlLocalidad1 = new GestionDeEnvios.Controles.ControlLocalidad();
            this.controlDomicilio1 = new GestionDeEnvios.Controles.ControlDomicilio();
            this.controlTelefono1 = new GestionDeEnvios.Controles.ControlTelefono();
            this.controlNombre1 = new GestionDeEnvios.Controles.ControlNombre();
            this.controlContraseña1 = new GestionDeEnvios.Controles.ControlContraseña();
            this.controlEmail1 = new GestionDeEnvios.Controles.ControlEmail();
            this.agregarUsuarioBTN = new System.Windows.Forms.Button();
            this.disponibleBOX = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activoBOX
            // 
            this.activoBOX.AutoSize = true;
            this.activoBOX.Location = new System.Drawing.Point(44, 486);
            this.activoBOX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activoBOX.Name = "activoBOX";
            this.activoBOX.Size = new System.Drawing.Size(66, 20);
            this.activoBOX.TabIndex = 9;
            this.activoBOX.Text = "Activo";
            this.activoBOX.UseVisualStyleBackColor = true;
            // 
            // tipoUsuarioCOMBOBOX
            // 
            this.tipoUsuarioCOMBOBOX.FormattingEnabled = true;
            this.tipoUsuarioCOMBOBOX.Items.AddRange(new object[] {
            "Administrador",
            "Cliente",
            "Repartidor",
            "Destinatario"});
            this.tipoUsuarioCOMBOBOX.Location = new System.Drawing.Point(235, 597);
            this.tipoUsuarioCOMBOBOX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipoUsuarioCOMBOBOX.Name = "tipoUsuarioCOMBOBOX";
            this.tipoUsuarioCOMBOBOX.Size = new System.Drawing.Size(160, 24);
            this.tipoUsuarioCOMBOBOX.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 568);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo Usuario";
            // 
            // controlDocumento1
            // 
            this.controlDocumento1.Etiqueta = "Documento";
            this.controlDocumento1.Location = new System.Drawing.Point(16, 412);
            this.controlDocumento1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlDocumento1.Name = "controlDocumento1";
            this.controlDocumento1.Size = new System.Drawing.Size(721, 53);
            this.controlDocumento1.TabIndex = 8;
            this.controlDocumento1.Texto = "";
            // 
            // controlCodigoPostal1
            // 
            this.controlCodigoPostal1.Etiqueta = "Codigo Postal";
            this.controlCodigoPostal1.Location = new System.Drawing.Point(16, 367);
            this.controlCodigoPostal1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlCodigoPostal1.Name = "controlCodigoPostal1";
            this.controlCodigoPostal1.Size = new System.Drawing.Size(721, 53);
            this.controlCodigoPostal1.TabIndex = 7;
            this.controlCodigoPostal1.Texto = "";
            // 
            // controlProvincia1
            // 
            this.controlProvincia1.Etiqueta = "Provincia";
            this.controlProvincia1.Location = new System.Drawing.Point(16, 311);
            this.controlProvincia1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlProvincia1.Name = "controlProvincia1";
            this.controlProvincia1.Size = new System.Drawing.Size(721, 53);
            this.controlProvincia1.TabIndex = 6;
            this.controlProvincia1.Texto = "";
            // 
            // controlLocalidad1
            // 
            this.controlLocalidad1.Etiqueta = "Localidad";
            this.controlLocalidad1.Location = new System.Drawing.Point(16, 262);
            this.controlLocalidad1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlLocalidad1.Name = "controlLocalidad1";
            this.controlLocalidad1.Size = new System.Drawing.Size(721, 53);
            this.controlLocalidad1.TabIndex = 5;
            this.controlLocalidad1.Texto = "";
            // 
            // controlDomicilio1
            // 
            this.controlDomicilio1.Etiqueta = "Domicilio";
            this.controlDomicilio1.Location = new System.Drawing.Point(16, 213);
            this.controlDomicilio1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlDomicilio1.Name = "controlDomicilio1";
            this.controlDomicilio1.Size = new System.Drawing.Size(721, 53);
            this.controlDomicilio1.TabIndex = 4;
            this.controlDomicilio1.Texto = "";
            // 
            // controlTelefono1
            // 
            this.controlTelefono1.Etiqueta = "Telefono";
            this.controlTelefono1.Location = new System.Drawing.Point(16, 165);
            this.controlTelefono1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlTelefono1.Name = "controlTelefono1";
            this.controlTelefono1.Size = new System.Drawing.Size(721, 53);
            this.controlTelefono1.TabIndex = 3;
            this.controlTelefono1.Texto = "";
            // 
            // controlNombre1
            // 
            this.controlNombre1.Etiqueta = "Nombre";
            this.controlNombre1.Location = new System.Drawing.Point(16, 111);
            this.controlNombre1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlNombre1.Name = "controlNombre1";
            this.controlNombre1.Size = new System.Drawing.Size(721, 53);
            this.controlNombre1.TabIndex = 2;
            this.controlNombre1.Texto = "";
            // 
            // controlContraseña1
            // 
            this.controlContraseña1.Etiqueta = "Contraseña";
            this.controlContraseña1.Location = new System.Drawing.Point(16, 65);
            this.controlContraseña1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlContraseña1.Name = "controlContraseña1";
            this.controlContraseña1.Size = new System.Drawing.Size(721, 53);
            this.controlContraseña1.TabIndex = 1;
            this.controlContraseña1.Texto = "";
            // 
            // controlEmail1
            // 
            this.controlEmail1.Etiqueta = "Email";
            this.controlEmail1.Location = new System.Drawing.Point(16, 15);
            this.controlEmail1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlEmail1.Name = "controlEmail1";
            this.controlEmail1.Size = new System.Drawing.Size(721, 53);
            this.controlEmail1.TabIndex = 0;
            this.controlEmail1.Texto = "";
            // 
            // agregarUsuarioBTN
            // 
            this.agregarUsuarioBTN.Location = new System.Drawing.Point(184, 650);
            this.agregarUsuarioBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.agregarUsuarioBTN.Name = "agregarUsuarioBTN";
            this.agregarUsuarioBTN.Size = new System.Drawing.Size(267, 76);
            this.agregarUsuarioBTN.TabIndex = 12;
            this.agregarUsuarioBTN.Text = "Agregar Usuario";
            this.agregarUsuarioBTN.UseVisualStyleBackColor = true;
            this.agregarUsuarioBTN.Click += new System.EventHandler(this.agregarUsuarioBTN_Click);
            // 
            // disponibleBOX
            // 
            this.disponibleBOX.AutoSize = true;
            this.disponibleBOX.Location = new System.Drawing.Point(44, 518);
            this.disponibleBOX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disponibleBOX.Name = "disponibleBOX";
            this.disponibleBOX.Size = new System.Drawing.Size(94, 20);
            this.disponibleBOX.TabIndex = 13;
            this.disponibleBOX.Text = "Disponible";
            this.disponibleBOX.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 519);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "(solo para proveedores)";
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 785);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disponibleBOX);
            this.Controls.Add(this.agregarUsuarioBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoUsuarioCOMBOBOX);
            this.Controls.Add(this.activoBOX);
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
            this.Name = "AltaUsuario";
            this.Text = "AltaUsuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ControlEmail controlEmail1;
        private Controles.ControlContraseña controlContraseña1;
        private Controles.ControlNombre controlNombre1;
        private Controles.ControlTelefono controlTelefono1;
        private Controles.ControlDomicilio controlDomicilio1;
        private Controles.ControlLocalidad controlLocalidad1;
        private Controles.ControlProvincia controlProvincia1;
        private Controles.ControlCodigoPostal controlCodigoPostal1;
        private Controles.ControlDocumento controlDocumento1;
        private System.Windows.Forms.CheckBox activoBOX;
        private System.Windows.Forms.ComboBox tipoUsuarioCOMBOBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarUsuarioBTN;
        private System.Windows.Forms.CheckBox disponibleBOX;
        private System.Windows.Forms.Label label2;
    }
}