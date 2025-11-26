namespace GestionDeEnvios
{
    partial class ConsultarEnviosRepartidor
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
            this.enviosDGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.estadoLBL = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cambiarEstadoBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.enviosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enviosDGV
            // 
            this.enviosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enviosDGV.Location = new System.Drawing.Point(12, 12);
            this.enviosDGV.Name = "enviosDGV";
            this.enviosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enviosDGV.Size = new System.Drawing.Size(776, 285);
            this.enviosDGV.TabIndex = 1;
            this.enviosDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enviosDGV_CellContentClick);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(321, 314);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Estado:";
            // 
            // estadoLBL
            // 
            this.estadoLBL.Location = new System.Drawing.Point(420, 314);
            this.estadoLBL.Name = "estadoLBL";
            this.estadoLBL.Size = new System.Drawing.Size(15, 20);
            this.estadoLBL.TabIndex = 3;
            this.estadoLBL.Values.Text = "-";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 121;
            this.kryptonComboBox1.Location = new System.Drawing.Point(323, 350);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(121, 21);
            this.kryptonComboBox1.TabIndex = 4;
            this.kryptonComboBox1.Text = "kryptonComboBox1";
            // 
            // cambiarEstadoBTN
            // 
            this.cambiarEstadoBTN.Location = new System.Drawing.Point(224, 385);
            this.cambiarEstadoBTN.Margin = new System.Windows.Forms.Padding(2);
            this.cambiarEstadoBTN.Name = "cambiarEstadoBTN";
            this.cambiarEstadoBTN.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.cambiarEstadoBTN.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cambiarEstadoBTN.OverrideDefault.Back.ColorAngle = 45F;
            this.cambiarEstadoBTN.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.cambiarEstadoBTN.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cambiarEstadoBTN.OverrideDefault.Border.ColorAngle = 45F;
            this.cambiarEstadoBTN.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cambiarEstadoBTN.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cambiarEstadoBTN.OverrideDefault.Border.Rounding = 20;
            this.cambiarEstadoBTN.OverrideDefault.Border.Width = 1;
            this.cambiarEstadoBTN.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarEstadoBTN.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cambiarEstadoBTN.Size = new System.Drawing.Size(147, 54);
            this.cambiarEstadoBTN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.cambiarEstadoBTN.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cambiarEstadoBTN.StateCommon.Back.ColorAngle = 45F;
            this.cambiarEstadoBTN.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.cambiarEstadoBTN.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cambiarEstadoBTN.StateCommon.Border.ColorAngle = 45F;
            this.cambiarEstadoBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cambiarEstadoBTN.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cambiarEstadoBTN.StateCommon.Border.Rounding = 20;
            this.cambiarEstadoBTN.StateCommon.Border.Width = 1;
            this.cambiarEstadoBTN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cambiarEstadoBTN.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.cambiarEstadoBTN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarEstadoBTN.TabIndex = 7;
            this.cambiarEstadoBTN.Values.Text = "Cambiar Estado";
            this.cambiarEstadoBTN.Click += new System.EventHandler(this.cambiarEstadoBTN_Click);
            // 
            // ConsultarEnviosRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cambiarEstadoBTN);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.estadoLBL);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.enviosDGV);
            this.Name = "ConsultarEnviosRepartidor";
            this.Text = "ConsultarEnviosRepartidor";
            this.Load += new System.EventHandler(this.ConsultarEnviosRepartidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enviosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView enviosDGV;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel estadoLBL;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cambiarEstadoBTN;
    }
}