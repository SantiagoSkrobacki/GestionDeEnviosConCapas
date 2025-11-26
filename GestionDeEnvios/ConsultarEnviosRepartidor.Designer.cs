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
            this.ComboBoxEstados = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cambiarEstadoBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.estadoFOT4 = new System.Windows.Forms.PictureBox();
            this.estadoFOT3 = new System.Windows.Forms.PictureBox();
            this.estado2FOT = new System.Windows.Forms.PictureBox();
            this.estado1FOT = new System.Windows.Forms.PictureBox();
            this.estado0FOT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enviosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoFOT4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoFOT3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado2FOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado1FOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado0FOT)).BeginInit();
            this.SuspendLayout();
            // 
            // enviosDGV
            // 
            this.enviosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enviosDGV.Location = new System.Drawing.Point(16, 15);
            this.enviosDGV.Margin = new System.Windows.Forms.Padding(4);
            this.enviosDGV.Name = "enviosDGV";
            this.enviosDGV.RowHeadersWidth = 51;
            this.enviosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enviosDGV.Size = new System.Drawing.Size(1453, 351);
            this.enviosDGV.TabIndex = 1;
            this.enviosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enviosDGV_CellClick);
            this.enviosDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enviosDGV_CellContentClick);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(558, 394);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(60, 24);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Estado:";
            // 
            // estadoLBL
            // 
            this.estadoLBL.Location = new System.Drawing.Point(664, 394);
            this.estadoLBL.Margin = new System.Windows.Forms.Padding(4);
            this.estadoLBL.Name = "estadoLBL";
            this.estadoLBL.Size = new System.Drawing.Size(18, 24);
            this.estadoLBL.TabIndex = 3;
            this.estadoLBL.Values.Text = "-";
            // 
            // ComboBoxEstados
            // 
            this.ComboBoxEstados.DropDownWidth = 121;
            this.ComboBoxEstados.Location = new System.Drawing.Point(561, 439);
            this.ComboBoxEstados.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxEstados.Name = "ComboBoxEstados";
            this.ComboBoxEstados.Size = new System.Drawing.Size(161, 25);
            this.ComboBoxEstados.TabIndex = 4;
            // 
            // cambiarEstadoBTN
            // 
            this.cambiarEstadoBTN.Location = new System.Drawing.Point(546, 482);
            this.cambiarEstadoBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cambiarEstadoBTN.Size = new System.Drawing.Size(196, 66);
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
            // estadoFOT4
            // 
            this.estadoFOT4.ErrorImage = global::GestionDeEnvios.Properties.Resources.estado0;
            this.estadoFOT4.Image = global::GestionDeEnvios.Properties.Resources.estado41;
            this.estadoFOT4.Location = new System.Drawing.Point(866, 414);
            this.estadoFOT4.Margin = new System.Windows.Forms.Padding(4);
            this.estadoFOT4.Name = "estadoFOT4";
            this.estadoFOT4.Size = new System.Drawing.Size(227, 111);
            this.estadoFOT4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estadoFOT4.TabIndex = 22;
            this.estadoFOT4.TabStop = false;
            // 
            // estadoFOT3
            // 
            this.estadoFOT3.ErrorImage = global::GestionDeEnvios.Properties.Resources.estado0;
            this.estadoFOT3.Image = global::GestionDeEnvios.Properties.Resources.estado31;
            this.estadoFOT3.Location = new System.Drawing.Point(866, 414);
            this.estadoFOT3.Margin = new System.Windows.Forms.Padding(4);
            this.estadoFOT3.Name = "estadoFOT3";
            this.estadoFOT3.Size = new System.Drawing.Size(227, 111);
            this.estadoFOT3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estadoFOT3.TabIndex = 21;
            this.estadoFOT3.TabStop = false;
            // 
            // estado2FOT
            // 
            this.estado2FOT.ErrorImage = global::GestionDeEnvios.Properties.Resources.estado0;
            this.estado2FOT.Image = global::GestionDeEnvios.Properties.Resources.estado21;
            this.estado2FOT.Location = new System.Drawing.Point(866, 414);
            this.estado2FOT.Margin = new System.Windows.Forms.Padding(4);
            this.estado2FOT.Name = "estado2FOT";
            this.estado2FOT.Size = new System.Drawing.Size(227, 111);
            this.estado2FOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estado2FOT.TabIndex = 20;
            this.estado2FOT.TabStop = false;
            // 
            // estado1FOT
            // 
            this.estado1FOT.ErrorImage = global::GestionDeEnvios.Properties.Resources.estado0;
            this.estado1FOT.Image = global::GestionDeEnvios.Properties.Resources.estado11;
            this.estado1FOT.Location = new System.Drawing.Point(866, 414);
            this.estado1FOT.Margin = new System.Windows.Forms.Padding(4);
            this.estado1FOT.Name = "estado1FOT";
            this.estado1FOT.Size = new System.Drawing.Size(227, 111);
            this.estado1FOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estado1FOT.TabIndex = 19;
            this.estado1FOT.TabStop = false;
            // 
            // estado0FOT
            // 
            this.estado0FOT.ErrorImage = global::GestionDeEnvios.Properties.Resources.estado0;
            this.estado0FOT.Image = global::GestionDeEnvios.Properties.Resources.estado01;
            this.estado0FOT.Location = new System.Drawing.Point(866, 414);
            this.estado0FOT.Margin = new System.Windows.Forms.Padding(4);
            this.estado0FOT.Name = "estado0FOT";
            this.estado0FOT.Size = new System.Drawing.Size(227, 111);
            this.estado0FOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estado0FOT.TabIndex = 18;
            this.estado0FOT.TabStop = false;
            // 
            // ConsultarEnviosRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 563);
            this.Controls.Add(this.estadoFOT4);
            this.Controls.Add(this.estadoFOT3);
            this.Controls.Add(this.estado2FOT);
            this.Controls.Add(this.estado1FOT);
            this.Controls.Add(this.estado0FOT);
            this.Controls.Add(this.cambiarEstadoBTN);
            this.Controls.Add(this.ComboBoxEstados);
            this.Controls.Add(this.estadoLBL);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.enviosDGV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarEnviosRepartidor";
            this.Text = "ConsultarEnviosRepartidor";
            this.Load += new System.EventHandler(this.ConsultarEnviosRepartidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enviosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoFOT4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoFOT3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado2FOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado1FOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado0FOT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView enviosDGV;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel estadoLBL;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBoxEstados;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cambiarEstadoBTN;
        private System.Windows.Forms.PictureBox estadoFOT4;
        private System.Windows.Forms.PictureBox estadoFOT3;
        private System.Windows.Forms.PictureBox estado2FOT;
        private System.Windows.Forms.PictureBox estado1FOT;
        private System.Windows.Forms.PictureBox estado0FOT;
    }
}