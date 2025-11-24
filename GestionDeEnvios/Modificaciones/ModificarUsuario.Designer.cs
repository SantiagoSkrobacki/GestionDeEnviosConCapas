namespace GestionDeEnvios.Modificaciones
{
    partial class ModificarUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.disponibleBOX = new System.Windows.Forms.CheckBox();
            this.modificarUsuarioBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoUsuarioCOMBOBOX = new System.Windows.Forms.ComboBox();
            this.activoBOX = new System.Windows.Forms.CheckBox();
            this.controlDocumento1 = new GestionDeEnvios.Controles.ControlDocumento();
            this.controlCodigoPostal1 = new GestionDeEnvios.Controles.ControlCodigoPostal();
            this.controlProvincia1 = new GestionDeEnvios.Controles.ControlProvincia();
            this.controlLocalidad1 = new GestionDeEnvios.Controles.ControlLocalidad();
            this.controlDomicilio1 = new GestionDeEnvios.Controles.ControlDomicilio();
            this.controlTelefono1 = new GestionDeEnvios.Controles.ControlTelefono();
            this.controlNombre1 = new GestionDeEnvios.Controles.ControlNombre();
            this.controlContraseña1 = new GestionDeEnvios.Controles.ControlContraseña();
            this.controlEmail1 = new GestionDeEnvios.Controles.ControlEmail();
            this.controlId1 = new GestionDeEnvios.Controles.ControlId();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "(solo para proveedores)";
            // 
            // disponibleBOX
            // 
            this.disponibleBOX.AutoSize = true;
            this.disponibleBOX.Location = new System.Drawing.Point(33, 438);
            this.disponibleBOX.Name = "disponibleBOX";
            this.disponibleBOX.Size = new System.Drawing.Size(75, 17);
            this.disponibleBOX.TabIndex = 28;
            this.disponibleBOX.Text = "Disponible";
            this.disponibleBOX.UseVisualStyleBackColor = true;
            // 
            // modificarUsuarioBTN
            // 
            this.modificarUsuarioBTN.Location = new System.Drawing.Point(505, 202);
            this.modificarUsuarioBTN.Name = "modificarUsuarioBTN";
            this.modificarUsuarioBTN.Size = new System.Drawing.Size(200, 62);
            this.modificarUsuarioBTN.TabIndex = 27;
            this.modificarUsuarioBTN.Text = "Modificar Usuario";
            this.modificarUsuarioBTN.UseVisualStyleBackColor = true;
            this.modificarUsuarioBTN.Click += new System.EventHandler(this.modificarUsuarioBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tipo Usuario";
            // 
            // tipoUsuarioCOMBOBOX
            // 
            this.tipoUsuarioCOMBOBOX.FormattingEnabled = true;
            this.tipoUsuarioCOMBOBOX.Items.AddRange(new object[] {
            "Administrador",
            "Cliente",
            "Repartidor",
            "Destinatario"});
            this.tipoUsuarioCOMBOBOX.Location = new System.Drawing.Point(543, 159);
            this.tipoUsuarioCOMBOBOX.Name = "tipoUsuarioCOMBOBOX";
            this.tipoUsuarioCOMBOBOX.Size = new System.Drawing.Size(121, 21);
            this.tipoUsuarioCOMBOBOX.TabIndex = 25;
            // 
            // activoBOX
            // 
            this.activoBOX.AutoSize = true;
            this.activoBOX.Location = new System.Drawing.Point(33, 412);
            this.activoBOX.Name = "activoBOX";
            this.activoBOX.Size = new System.Drawing.Size(56, 17);
            this.activoBOX.TabIndex = 24;
            this.activoBOX.Text = "Activo";
            this.activoBOX.UseVisualStyleBackColor = true;
            // 
            // controlDocumento1
            // 
            this.controlDocumento1.Etiqueta = "Documento";
            this.controlDocumento1.Location = new System.Drawing.Point(12, 352);
            this.controlDocumento1.Name = "controlDocumento1";
            this.controlDocumento1.Size = new System.Drawing.Size(487, 43);
            this.controlDocumento1.TabIndex = 23;
            this.controlDocumento1.Texto = "";
            // 
            // controlCodigoPostal1
            // 
            this.controlCodigoPostal1.Etiqueta = "Codigo Postal";
            this.controlCodigoPostal1.Location = new System.Drawing.Point(12, 315);
            this.controlCodigoPostal1.Name = "controlCodigoPostal1";
            this.controlCodigoPostal1.Size = new System.Drawing.Size(487, 43);
            this.controlCodigoPostal1.TabIndex = 22;
            this.controlCodigoPostal1.Texto = "";
            // 
            // controlProvincia1
            // 
            this.controlProvincia1.Etiqueta = "Provincia";
            this.controlProvincia1.Location = new System.Drawing.Point(12, 270);
            this.controlProvincia1.Name = "controlProvincia1";
            this.controlProvincia1.Size = new System.Drawing.Size(487, 43);
            this.controlProvincia1.TabIndex = 21;
            this.controlProvincia1.Texto = "";
            // 
            // controlLocalidad1
            // 
            this.controlLocalidad1.Etiqueta = "Localidad";
            this.controlLocalidad1.Location = new System.Drawing.Point(12, 230);
            this.controlLocalidad1.Name = "controlLocalidad1";
            this.controlLocalidad1.Size = new System.Drawing.Size(487, 43);
            this.controlLocalidad1.TabIndex = 20;
            this.controlLocalidad1.Texto = "";
            // 
            // controlDomicilio1
            // 
            this.controlDomicilio1.Etiqueta = "Domicilio";
            this.controlDomicilio1.Location = new System.Drawing.Point(12, 190);
            this.controlDomicilio1.Name = "controlDomicilio1";
            this.controlDomicilio1.Size = new System.Drawing.Size(487, 43);
            this.controlDomicilio1.TabIndex = 19;
            this.controlDomicilio1.Texto = "";
            // 
            // controlTelefono1
            // 
            this.controlTelefono1.Etiqueta = "Telefono";
            this.controlTelefono1.Location = new System.Drawing.Point(12, 151);
            this.controlTelefono1.Name = "controlTelefono1";
            this.controlTelefono1.Size = new System.Drawing.Size(487, 43);
            this.controlTelefono1.TabIndex = 18;
            this.controlTelefono1.Texto = "";
            // 
            // controlNombre1
            // 
            this.controlNombre1.Etiqueta = "Nombre";
            this.controlNombre1.Location = new System.Drawing.Point(12, 107);
            this.controlNombre1.Name = "controlNombre1";
            this.controlNombre1.Size = new System.Drawing.Size(487, 43);
            this.controlNombre1.TabIndex = 17;
            this.controlNombre1.Texto = "";
            // 
            // controlContraseña1
            // 
            this.controlContraseña1.Etiqueta = "Contraseña";
            this.controlContraseña1.Location = new System.Drawing.Point(12, 70);
            this.controlContraseña1.Name = "controlContraseña1";
            this.controlContraseña1.Size = new System.Drawing.Size(487, 43);
            this.controlContraseña1.TabIndex = 16;
            this.controlContraseña1.Texto = "";
            // 
            // controlEmail1
            // 
            this.controlEmail1.Etiqueta = "Email";
            this.controlEmail1.Location = new System.Drawing.Point(12, 29);
            this.controlEmail1.Name = "controlEmail1";
            this.controlEmail1.Size = new System.Drawing.Size(487, 43);
            this.controlEmail1.TabIndex = 15;
            this.controlEmail1.Texto = "";
            // 
            // controlId1
            // 
            this.controlId1.Etiqueta = "ID";
            this.controlId1.Location = new System.Drawing.Point(12, -7);
            this.controlId1.Name = "controlId1";
            this.controlId1.Size = new System.Drawing.Size(496, 49);
            this.controlId1.TabIndex = 30;
            this.controlId1.Texto = "";
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlId1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disponibleBOX);
            this.Controls.Add(this.modificarUsuarioBTN);
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
            this.Name = "ModificarUsuario";
            this.Text = "ModificarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox disponibleBOX;
        private System.Windows.Forms.Button modificarUsuarioBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipoUsuarioCOMBOBOX;
        private System.Windows.Forms.CheckBox activoBOX;
        private Controles.ControlDocumento controlDocumento1;
        private Controles.ControlCodigoPostal controlCodigoPostal1;
        private Controles.ControlProvincia controlProvincia1;
        private Controles.ControlLocalidad controlLocalidad1;
        private Controles.ControlDomicilio controlDomicilio1;
        private Controles.ControlTelefono controlTelefono1;
        private Controles.ControlNombre controlNombre1;
        private Controles.ControlContraseña controlContraseña1;
        private Controles.ControlEmail controlEmail1;
        private Controles.ControlId controlId1;
    }
}