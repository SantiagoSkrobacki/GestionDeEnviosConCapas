namespace GestionDeEnvios.Bajas
{
    partial class BajaUsuario
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
            this.controlId1 = new GestionDeEnvios.Controles.ControlId();
            this.eliminarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlId1
            // 
            this.controlId1.Etiqueta = "Id";
            this.controlId1.Location = new System.Drawing.Point(142, 38);
            this.controlId1.Name = "controlId1";
            this.controlId1.Size = new System.Drawing.Size(496, 49);
            this.controlId1.TabIndex = 0;
            this.controlId1.Texto = "";
            // 
            // eliminarBTN
            // 
            this.eliminarBTN.Location = new System.Drawing.Point(258, 103);
            this.eliminarBTN.Name = "eliminarBTN";
            this.eliminarBTN.Size = new System.Drawing.Size(141, 45);
            this.eliminarBTN.TabIndex = 1;
            this.eliminarBTN.Text = "Eliminar";
            this.eliminarBTN.UseVisualStyleBackColor = true;
            this.eliminarBTN.Click += new System.EventHandler(this.eliminarBTN_Click);
            // 
            // BajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminarBTN);
            this.Controls.Add(this.controlId1);
            this.Name = "BajaUsuario";
            this.Text = "BajaUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ControlId controlId1;
        private System.Windows.Forms.Button eliminarBTN;
    }
}