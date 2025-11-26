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
            this.usuariosDGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // controlId1
            // 
            this.controlId1.Etiqueta = "Id";
            this.controlId1.Location = new System.Drawing.Point(142, 312);
            this.controlId1.Margin = new System.Windows.Forms.Padding(4);
            this.controlId1.Name = "controlId1";
            this.controlId1.Size = new System.Drawing.Size(496, 49);
            this.controlId1.TabIndex = 0;
            this.controlId1.Texto = "";
            this.controlId1.Load += new System.EventHandler(this.controlId1_Load);
            // 
            // eliminarBTN
            // 
            this.eliminarBTN.Location = new System.Drawing.Point(302, 377);
            this.eliminarBTN.Margin = new System.Windows.Forms.Padding(2);
            this.eliminarBTN.Name = "eliminarBTN";
            this.eliminarBTN.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.eliminarBTN.Size = new System.Drawing.Size(147, 54);
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
            // usuariosDGV
            // 
            this.usuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDGV.Location = new System.Drawing.Point(12, 1);
            this.usuariosDGV.Name = "usuariosDGV";
            this.usuariosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuariosDGV.Size = new System.Drawing.Size(776, 285);
            this.usuariosDGV.TabIndex = 7;
            this.usuariosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosDGV_CellClick);
            // 
            // BajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.usuariosDGV);
            this.Controls.Add(this.eliminarBTN);
            this.Controls.Add(this.controlId1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "BajaUsuario";
            this.Text = "BajaUsuario";
            this.Load += new System.EventHandler(this.BajaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ControlId controlId1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton eliminarBTN;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView usuariosDGV;
    }
}