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
            this.agregarUsuarioBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // activoBOX
            // 
            this.activoBOX.AutoSize = true;
            this.activoBOX.Location = new System.Drawing.Point(25, 493);
            this.activoBOX.Name = "activoBOX";
            this.activoBOX.Size = new System.Drawing.Size(56, 17);
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
            this.tipoUsuarioCOMBOBOX.Location = new System.Drawing.Point(222, 558);
            this.tipoUsuarioCOMBOBOX.Name = "tipoUsuarioCOMBOBOX";
            this.tipoUsuarioCOMBOBOX.Size = new System.Drawing.Size(121, 21);
            this.tipoUsuarioCOMBOBOX.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo Usuario";
            // 
            // controlDocumento1
            // 
            this.controlDocumento1.Etiqueta = "Documento";
            this.controlDocumento1.Location = new System.Drawing.Point(12, 418);
            this.controlDocumento1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlDocumento1.Name = "controlDocumento1";
            this.controlDocumento1.Size = new System.Drawing.Size(541, 43);
            this.controlDocumento1.TabIndex = 8;
            this.controlDocumento1.Texto = "";
            // 
            // controlCodigoPostal1
            // 
            this.controlCodigoPostal1.Etiqueta = "Codigo Postal";
            this.controlCodigoPostal1.Location = new System.Drawing.Point(12, 366);
            this.controlCodigoPostal1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlCodigoPostal1.Name = "controlCodigoPostal1";
            this.controlCodigoPostal1.Size = new System.Drawing.Size(541, 43);
            this.controlCodigoPostal1.TabIndex = 7;
            this.controlCodigoPostal1.Texto = "";
            // 
            // controlProvincia1
            // 
            this.controlProvincia1.Etiqueta = "Provincia";
            this.controlProvincia1.Location = new System.Drawing.Point(12, 315);
            this.controlProvincia1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlProvincia1.Name = "controlProvincia1";
            this.controlProvincia1.Size = new System.Drawing.Size(541, 43);
            this.controlProvincia1.TabIndex = 6;
            this.controlProvincia1.Texto = "";
            // 
            // controlLocalidad1
            // 
            this.controlLocalidad1.Etiqueta = "Localidad";
            this.controlLocalidad1.Location = new System.Drawing.Point(12, 264);
            this.controlLocalidad1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlLocalidad1.Name = "controlLocalidad1";
            this.controlLocalidad1.Size = new System.Drawing.Size(541, 43);
            this.controlLocalidad1.TabIndex = 5;
            this.controlLocalidad1.Texto = "";
            // 
            // controlDomicilio1
            // 
            this.controlDomicilio1.Etiqueta = "Domicilio";
            this.controlDomicilio1.Location = new System.Drawing.Point(12, 213);
            this.controlDomicilio1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlDomicilio1.Name = "controlDomicilio1";
            this.controlDomicilio1.Size = new System.Drawing.Size(541, 43);
            this.controlDomicilio1.TabIndex = 4;
            this.controlDomicilio1.Texto = "";
            // 
            // controlTelefono1
            // 
            this.controlTelefono1.Etiqueta = "Telefono";
            this.controlTelefono1.Location = new System.Drawing.Point(12, 162);
            this.controlTelefono1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlTelefono1.Name = "controlTelefono1";
            this.controlTelefono1.Size = new System.Drawing.Size(541, 43);
            this.controlTelefono1.TabIndex = 3;
            this.controlTelefono1.Texto = "";
            // 
            // controlNombre1
            // 
            this.controlNombre1.Etiqueta = "Nombre";
            this.controlNombre1.Location = new System.Drawing.Point(12, 110);
            this.controlNombre1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlNombre1.Name = "controlNombre1";
            this.controlNombre1.Size = new System.Drawing.Size(541, 43);
            this.controlNombre1.TabIndex = 2;
            this.controlNombre1.Texto = "";
            // 
            // controlContraseña1
            // 
            this.controlContraseña1.Etiqueta = "Contraseña";
            this.controlContraseña1.Location = new System.Drawing.Point(12, 59);
            this.controlContraseña1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlContraseña1.Name = "controlContraseña1";
            this.controlContraseña1.Size = new System.Drawing.Size(541, 43);
            this.controlContraseña1.TabIndex = 1;
            this.controlContraseña1.Texto = "";
            // 
            // controlEmail1
            // 
            this.controlEmail1.Etiqueta = "Email";
            this.controlEmail1.Location = new System.Drawing.Point(12, 12);
            this.controlEmail1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlEmail1.Name = "controlEmail1";
            this.controlEmail1.Size = new System.Drawing.Size(541, 43);
            this.controlEmail1.TabIndex = 0;
            this.controlEmail1.Texto = "";
            // 
            // agregarUsuarioBTN
            // 
            this.agregarUsuarioBTN.Location = new System.Drawing.Point(198, 593);
            this.agregarUsuarioBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.agregarUsuarioBTN.Name = "agregarUsuarioBTN";
            this.agregarUsuarioBTN.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.agregarUsuarioBTN.Size = new System.Drawing.Size(165, 67);
            this.agregarUsuarioBTN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.agregarUsuarioBTN.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.agregarUsuarioBTN.StateCommon.Back.ColorAngle = 45F;
            this.agregarUsuarioBTN.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.agregarUsuarioBTN.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.agregarUsuarioBTN.StateCommon.Border.ColorAngle = 45F;
            this.agregarUsuarioBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.agregarUsuarioBTN.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.agregarUsuarioBTN.StateCommon.Border.Rounding = 20;
            this.agregarUsuarioBTN.StateCommon.Border.Width = 1;
            this.agregarUsuarioBTN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.agregarUsuarioBTN.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.agregarUsuarioBTN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarUsuarioBTN.TabIndex = 15;
            this.agregarUsuarioBTN.Values.Text = "Agregar Usuario";
            this.agregarUsuarioBTN.Click += new System.EventHandler(this.agregarUsuarioBTN_Click_1);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 696);
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
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton agregarUsuarioBTN;
    }
}