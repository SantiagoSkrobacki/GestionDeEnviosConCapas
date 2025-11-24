namespace GestionDeEnvios.Login
{
    partial class Iniciar_Sesion
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
            this.iniciarSesionBTN = new System.Windows.Forms.Button();
            this.registrarseBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.controlContraseña1 = new GestionDeEnvios.Controles.ControlContraseña();
            this.controlEmail1 = new GestionDeEnvios.Controles.ControlEmail();
            this.SuspendLayout();
            // 
            // iniciarSesionBTN
            // 
            this.iniciarSesionBTN.Location = new System.Drawing.Point(164, 156);
            this.iniciarSesionBTN.Name = "iniciarSesionBTN";
            this.iniciarSesionBTN.Size = new System.Drawing.Size(154, 43);
            this.iniciarSesionBTN.TabIndex = 2;
            this.iniciarSesionBTN.Text = "Iniciar Sesion";
            this.iniciarSesionBTN.UseVisualStyleBackColor = true;
            this.iniciarSesionBTN.Click += new System.EventHandler(this.iniciarSesionBTN_Click);
            // 
            // registrarseBTN
            // 
            this.registrarseBTN.Location = new System.Drawing.Point(372, 233);
            this.registrarseBTN.Name = "registrarseBTN";
            this.registrarseBTN.Size = new System.Drawing.Size(81, 21);
            this.registrarseBTN.TabIndex = 3;
            this.registrarseBTN.Text = "registrarse";
            this.registrarseBTN.UseVisualStyleBackColor = true;
            this.registrarseBTN.Click += new System.EventHandler(this.registrarseBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "no tenes cuenta?";
            // 
            // controlContraseña1
            // 
            this.controlContraseña1.Etiqueta = "Contraseña";
            this.controlContraseña1.Location = new System.Drawing.Point(42, 101);
            this.controlContraseña1.Name = "controlContraseña1";
            this.controlContraseña1.Size = new System.Drawing.Size(496, 49);
            this.controlContraseña1.TabIndex = 1;
            this.controlContraseña1.Texto = "";
            // 
            // controlEmail1
            // 
            this.controlEmail1.Etiqueta = "Mail";
            this.controlEmail1.Location = new System.Drawing.Point(42, 46);
            this.controlEmail1.Name = "controlEmail1";
            this.controlEmail1.Size = new System.Drawing.Size(496, 49);
            this.controlEmail1.TabIndex = 0;
            this.controlEmail1.Texto = "";
            // 
            // Iniciar_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrarseBTN);
            this.Controls.Add(this.iniciarSesionBTN);
            this.Controls.Add(this.controlContraseña1);
            this.Controls.Add(this.controlEmail1);
            this.Name = "Iniciar_Sesion";
            this.Text = "Iniciar_Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ControlEmail controlEmail1;
        private Controles.ControlContraseña controlContraseña1;
        private System.Windows.Forms.Button iniciarSesionBTN;
        private System.Windows.Forms.Button registrarseBTN;
        private System.Windows.Forms.Label label1;
    }
}