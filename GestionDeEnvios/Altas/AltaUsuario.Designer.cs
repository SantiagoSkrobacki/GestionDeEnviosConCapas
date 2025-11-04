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
            this.miControl1 = new GestionDeEnvios.MiControl();
            this.SuspendLayout();
            // 
            // miControl1
            // 
            this.miControl1.Etiqueta = "label1";
            this.miControl1.Location = new System.Drawing.Point(12, 12);
            this.miControl1.Name = "miControl1";
            this.miControl1.Size = new System.Drawing.Size(360, 49);
            this.miControl1.TabIndex = 0;
            this.miControl1.Texto = "";
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.miControl1);
            this.Name = "AltaUsuario";
            this.Text = "AltaUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private MiControl miControl1;
    }
}