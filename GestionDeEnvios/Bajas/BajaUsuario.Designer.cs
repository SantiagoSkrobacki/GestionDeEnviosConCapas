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
            this.eliminarBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // controlId1
            // 
            this.controlId1.Etiqueta = "Id";
            this.controlId1.Location = new System.Drawing.Point(189, 47);
            this.controlId1.Margin = new System.Windows.Forms.Padding(5);
            this.controlId1.Name = "controlId1";
            this.controlId1.Size = new System.Drawing.Size(661, 60);
            this.controlId1.TabIndex = 0;
            this.controlId1.Texto = "";
            // 
            // eliminarBTN
            // 
            this.eliminarBTN.Location = new System.Drawing.Point(403, 127);
            this.eliminarBTN.Name = "eliminarBTN";
            this.eliminarBTN.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.eliminarBTN.Size = new System.Drawing.Size(196, 67);
            this.eliminarBTN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.eliminarBTN.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.eliminarBTN.StateCommon.Back.ColorAngle = 45F;
            this.eliminarBTN.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.eliminarBTN.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.eliminarBTN.StateCommon.Border.ColorAngle = 45F;
            this.eliminarBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.eliminarBTN.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.eliminarBTN.StateCommon.Border.Rounding = 20;
            this.eliminarBTN.StateCommon.Border.Width = 1;
            this.eliminarBTN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.eliminarBTN.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.eliminarBTN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBTN.TabIndex = 6;
            this.eliminarBTN.Values.Text = "Eliminar";
            this.eliminarBTN.Click += new System.EventHandler(this.eliminarBTN_Click_1);
            // 
            // BajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 559);
            this.Controls.Add(this.eliminarBTN);
            this.Controls.Add(this.controlId1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BajaUsuario";
            this.Text = "BajaUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ControlId controlId1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton eliminarBTN;
    }
}