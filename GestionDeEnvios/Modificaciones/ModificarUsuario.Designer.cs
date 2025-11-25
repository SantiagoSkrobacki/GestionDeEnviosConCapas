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
            this.modificarUsuarioBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 624);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "(solo para proveedores)";
            // 
            // disponibleBOX
            // 
            this.disponibleBOX.AutoSize = true;
            this.disponibleBOX.Location = new System.Drawing.Point(42, 623);
            this.disponibleBOX.Margin = new System.Windows.Forms.Padding(4);
            this.disponibleBOX.Name = "disponibleBOX";
            this.disponibleBOX.Size = new System.Drawing.Size(94, 20);
            this.disponibleBOX.TabIndex = 28;
            this.disponibleBOX.Text = "Disponible";
            this.disponibleBOX.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 665);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
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
            this.tipoUsuarioCOMBOBOX.Location = new System.Drawing.Point(294, 695);
            this.tipoUsuarioCOMBOBOX.Margin = new System.Windows.Forms.Padding(4);
            this.tipoUsuarioCOMBOBOX.Name = "tipoUsuarioCOMBOBOX";
            this.tipoUsuarioCOMBOBOX.Size = new System.Drawing.Size(160, 24);
            this.tipoUsuarioCOMBOBOX.TabIndex = 25;
            // 
            // activoBOX
            // 
            this.activoBOX.AutoSize = true;
            this.activoBOX.Location = new System.Drawing.Point(42, 591);
            this.activoBOX.Margin = new System.Windows.Forms.Padding(4);
            this.activoBOX.Name = "activoBOX";
            this.activoBOX.Size = new System.Drawing.Size(66, 20);
            this.activoBOX.TabIndex = 24;
            this.activoBOX.Text = "Activo";
            this.activoBOX.UseVisualStyleBackColor = true;
            // 
            // controlDocumento1
            // 
            this.controlDocumento1.Etiqueta = "Documento";
            this.controlDocumento1.Location = new System.Drawing.Point(14, 529);
            this.controlDocumento1.Margin = new System.Windows.Forms.Padding(5);
            this.controlDocumento1.Name = "controlDocumento1";
            this.controlDocumento1.Size = new System.Drawing.Size(805, 53);
            this.controlDocumento1.TabIndex = 23;
            this.controlDocumento1.Texto = "";
            // 
            // controlCodigoPostal1
            // 
            this.controlCodigoPostal1.Etiqueta = "Codigo Postal";
            this.controlCodigoPostal1.Location = new System.Drawing.Point(14, 466);
            this.controlCodigoPostal1.Margin = new System.Windows.Forms.Padding(5);
            this.controlCodigoPostal1.Name = "controlCodigoPostal1";
            this.controlCodigoPostal1.Size = new System.Drawing.Size(805, 53);
            this.controlCodigoPostal1.TabIndex = 22;
            this.controlCodigoPostal1.Texto = "";
            // 
            // controlProvincia1
            // 
            this.controlProvincia1.Etiqueta = "Provincia";
            this.controlProvincia1.Location = new System.Drawing.Point(14, 403);
            this.controlProvincia1.Margin = new System.Windows.Forms.Padding(5);
            this.controlProvincia1.Name = "controlProvincia1";
            this.controlProvincia1.Size = new System.Drawing.Size(805, 53);
            this.controlProvincia1.TabIndex = 21;
            this.controlProvincia1.Texto = "";
            // 
            // controlLocalidad1
            // 
            this.controlLocalidad1.Etiqueta = "Localidad";
            this.controlLocalidad1.Location = new System.Drawing.Point(14, 340);
            this.controlLocalidad1.Margin = new System.Windows.Forms.Padding(5);
            this.controlLocalidad1.Name = "controlLocalidad1";
            this.controlLocalidad1.Size = new System.Drawing.Size(805, 53);
            this.controlLocalidad1.TabIndex = 20;
            this.controlLocalidad1.Texto = "";
            // 
            // controlDomicilio1
            // 
            this.controlDomicilio1.Etiqueta = "Domicilio";
            this.controlDomicilio1.Location = new System.Drawing.Point(14, 277);
            this.controlDomicilio1.Margin = new System.Windows.Forms.Padding(5);
            this.controlDomicilio1.Name = "controlDomicilio1";
            this.controlDomicilio1.Size = new System.Drawing.Size(805, 53);
            this.controlDomicilio1.TabIndex = 19;
            this.controlDomicilio1.Texto = "";
            // 
            // controlTelefono1
            // 
            this.controlTelefono1.Etiqueta = "Telefono";
            this.controlTelefono1.Location = new System.Drawing.Point(14, 214);
            this.controlTelefono1.Margin = new System.Windows.Forms.Padding(5);
            this.controlTelefono1.Name = "controlTelefono1";
            this.controlTelefono1.Size = new System.Drawing.Size(805, 53);
            this.controlTelefono1.TabIndex = 18;
            this.controlTelefono1.Texto = "";
            // 
            // controlNombre1
            // 
            this.controlNombre1.Etiqueta = "Nombre";
            this.controlNombre1.Location = new System.Drawing.Point(14, 151);
            this.controlNombre1.Margin = new System.Windows.Forms.Padding(5);
            this.controlNombre1.Name = "controlNombre1";
            this.controlNombre1.Size = new System.Drawing.Size(805, 53);
            this.controlNombre1.TabIndex = 17;
            this.controlNombre1.Texto = "";
            // 
            // controlContraseña1
            // 
            this.controlContraseña1.Etiqueta = "Contraseña";
            this.controlContraseña1.Location = new System.Drawing.Point(16, 104);
            this.controlContraseña1.Margin = new System.Windows.Forms.Padding(5);
            this.controlContraseña1.Name = "controlContraseña1";
            this.controlContraseña1.Size = new System.Drawing.Size(803, 53);
            this.controlContraseña1.TabIndex = 16;
            this.controlContraseña1.Texto = "";
            // 
            // controlEmail1
            // 
            this.controlEmail1.Etiqueta = "Email";
            this.controlEmail1.Location = new System.Drawing.Point(14, 52);
            this.controlEmail1.Margin = new System.Windows.Forms.Padding(5);
            this.controlEmail1.Name = "controlEmail1";
            this.controlEmail1.Size = new System.Drawing.Size(805, 53);
            this.controlEmail1.TabIndex = 15;
            this.controlEmail1.Texto = "";
            // 
            // controlId1
            // 
            this.controlId1.Etiqueta = "ID";
            this.controlId1.Location = new System.Drawing.Point(16, -3);
            this.controlId1.Margin = new System.Windows.Forms.Padding(5);
            this.controlId1.Name = "controlId1";
            this.controlId1.Size = new System.Drawing.Size(803, 60);
            this.controlId1.TabIndex = 30;
            this.controlId1.Texto = "";
            // 
            // modificarUsuarioBTN
            // 
            this.modificarUsuarioBTN.Location = new System.Drawing.Point(243, 747);
            this.modificarUsuarioBTN.Name = "modificarUsuarioBTN";
            this.modificarUsuarioBTN.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.modificarUsuarioBTN.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.modificarUsuarioBTN.OverrideDefault.Back.ColorAngle = 45F;
            this.modificarUsuarioBTN.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.modificarUsuarioBTN.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.modificarUsuarioBTN.OverrideDefault.Border.ColorAngle = 45F;
            this.modificarUsuarioBTN.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.modificarUsuarioBTN.OverrideDefault.Border.Rounding = 20;
            this.modificarUsuarioBTN.OverrideDefault.Border.Width = 1;
            this.modificarUsuarioBTN.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuarioBTN.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.modificarUsuarioBTN.Size = new System.Drawing.Size(252, 97);
            this.modificarUsuarioBTN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.modificarUsuarioBTN.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.modificarUsuarioBTN.StateCommon.Back.ColorAngle = 45F;
            this.modificarUsuarioBTN.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.modificarUsuarioBTN.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.modificarUsuarioBTN.StateCommon.Border.ColorAngle = 45F;
            this.modificarUsuarioBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.modificarUsuarioBTN.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.modificarUsuarioBTN.StateCommon.Border.Rounding = 20;
            this.modificarUsuarioBTN.StateCommon.Border.Width = 1;
            this.modificarUsuarioBTN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.modificarUsuarioBTN.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.modificarUsuarioBTN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuarioBTN.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.modificarUsuarioBTN.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.modificarUsuarioBTN.StateNormal.Back.ColorAngle = 45F;
            this.modificarUsuarioBTN.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.modificarUsuarioBTN.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.modificarUsuarioBTN.StateNormal.Border.ColorAngle = 45F;
            this.modificarUsuarioBTN.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.modificarUsuarioBTN.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.modificarUsuarioBTN.StateNormal.Border.Rounding = 20;
            this.modificarUsuarioBTN.StateNormal.Border.Width = 1;
            this.modificarUsuarioBTN.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.modificarUsuarioBTN.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.modificarUsuarioBTN.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuarioBTN.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.modificarUsuarioBTN.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.modificarUsuarioBTN.StatePressed.Back.ColorAngle = 45F;
            this.modificarUsuarioBTN.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.modificarUsuarioBTN.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.modificarUsuarioBTN.StatePressed.Border.ColorAngle = 45F;
            this.modificarUsuarioBTN.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.modificarUsuarioBTN.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.modificarUsuarioBTN.StatePressed.Border.Rounding = 20;
            this.modificarUsuarioBTN.StatePressed.Border.Width = 1;
            this.modificarUsuarioBTN.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.modificarUsuarioBTN.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.modificarUsuarioBTN.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuarioBTN.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.modificarUsuarioBTN.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.modificarUsuarioBTN.StateTracking.Back.ColorAngle = 45F;
            this.modificarUsuarioBTN.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.modificarUsuarioBTN.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.modificarUsuarioBTN.StateTracking.Border.ColorAngle = 45F;
            this.modificarUsuarioBTN.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.modificarUsuarioBTN.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.modificarUsuarioBTN.StateTracking.Border.Rounding = 20;
            this.modificarUsuarioBTN.StateTracking.Border.Width = 1;
            this.modificarUsuarioBTN.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuarioBTN.TabIndex = 31;
            this.modificarUsuarioBTN.Values.Text = "Modificar Usuario";
            this.modificarUsuarioBTN.Click += new System.EventHandler(this.modificarUsuarioBTN_Click_1);
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 856);
            this.Controls.Add(this.modificarUsuarioBTN);
            this.Controls.Add(this.controlId1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disponibleBOX);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarUsuario";
            this.Text = "ModificarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox disponibleBOX;
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton modificarUsuarioBTN;
    }
}