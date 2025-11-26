namespace GestionDeEnvios
{
    partial class GenerarXMLUsuario
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
            this.usuariosDGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.generarXMLBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosDGV
            // 
            this.usuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDGV.Location = new System.Drawing.Point(12, 23);
            this.usuariosDGV.Name = "usuariosDGV";
            this.usuariosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuariosDGV.Size = new System.Drawing.Size(776, 285);
            this.usuariosDGV.TabIndex = 2;
            // 
            // generarXMLBTN
            // 
            this.generarXMLBTN.Location = new System.Drawing.Point(304, 350);
            this.generarXMLBTN.Margin = new System.Windows.Forms.Padding(2);
            this.generarXMLBTN.Name = "generarXMLBTN";
            this.generarXMLBTN.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.generarXMLBTN.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.generarXMLBTN.OverrideDefault.Back.ColorAngle = 45F;
            this.generarXMLBTN.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.generarXMLBTN.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.generarXMLBTN.OverrideDefault.Border.ColorAngle = 45F;
            this.generarXMLBTN.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.generarXMLBTN.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.generarXMLBTN.OverrideDefault.Border.Rounding = 20;
            this.generarXMLBTN.OverrideDefault.Border.Width = 1;
            this.generarXMLBTN.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarXMLBTN.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.generarXMLBTN.Size = new System.Drawing.Size(147, 54);
            this.generarXMLBTN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.generarXMLBTN.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.generarXMLBTN.StateCommon.Back.ColorAngle = 45F;
            this.generarXMLBTN.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.generarXMLBTN.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.generarXMLBTN.StateCommon.Border.ColorAngle = 45F;
            this.generarXMLBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.generarXMLBTN.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.generarXMLBTN.StateCommon.Border.Rounding = 20;
            this.generarXMLBTN.StateCommon.Border.Width = 1;
            this.generarXMLBTN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.generarXMLBTN.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.generarXMLBTN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarXMLBTN.TabIndex = 8;
            this.generarXMLBTN.Values.Text = "Generar XML";
            this.generarXMLBTN.Click += new System.EventHandler(this.generarXMLBTN_Click);
            // 
            // GenerarXMLUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generarXMLBTN);
            this.Controls.Add(this.usuariosDGV);
            this.Name = "GenerarXMLUsuario";
            this.Text = "GenerarXMLUsuario";
            this.Load += new System.EventHandler(this.GenerarXMLUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView usuariosDGV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton generarXMLBTN;
    }
}