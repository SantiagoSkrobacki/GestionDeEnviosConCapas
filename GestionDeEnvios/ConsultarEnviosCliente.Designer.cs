namespace GestionDeEnvios
{
    partial class ConsultarEnviosCliente
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
            this.estadoLBL = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.estadoFOT4 = new System.Windows.Forms.PictureBox();
            this.estadoFOT3 = new System.Windows.Forms.PictureBox();
            this.estado2FOT = new System.Windows.Forms.PictureBox();
            this.estado1FOT = new System.Windows.Forms.PictureBox();
            this.estado0FOT = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.enviosDGV)).BeginInit();
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
            this.enviosDGV.Location = new System.Drawing.Point(12, 12);
            this.enviosDGV.Name = "enviosDGV";
            this.enviosDGV.RowHeadersWidth = 51;
            this.enviosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enviosDGV.Size = new System.Drawing.Size(1090, 285);
            this.enviosDGV.TabIndex = 2;
            this.enviosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enviosDGV_CellClick);
            this.enviosDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enviosDGV_CellContentClick);
            // 
            // estadoLBL
            // 
            this.estadoLBL.Location = new System.Drawing.Point(580, 322);
            this.estadoLBL.Name = "estadoLBL";
            this.estadoLBL.Size = new System.Drawing.Size(15, 20);
            this.estadoLBL.TabIndex = 5;
            this.estadoLBL.Values.Text = "-";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(482, 322);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Estado:";
            // 
            // estadoFOT4
            // 
            this.estadoFOT4.ErrorImage = global::GestionDeEnvios.Properties.Resources.estado0;
            this.estadoFOT4.Image = global::GestionDeEnvios.Properties.Resources.estado41;
            this.estadoFOT4.Location = new System.Drawing.Point(453, 348);
            this.estadoFOT4.Name = "estadoFOT4";
            this.estadoFOT4.Size = new System.Drawing.Size(170, 90);
            this.estadoFOT4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estadoFOT4.TabIndex = 17;
            this.estadoFOT4.TabStop = false;
            // 
            // estadoFOT3
            // 
            this.estadoFOT3.ErrorImage = global::GestionDeEnvios.Properties.Resources.estado0;
            this.estadoFOT3.Image = global::GestionDeEnvios.Properties.Resources.estado31;
            this.estadoFOT3.Location = new System.Drawing.Point(453, 348);
            this.estadoFOT3.Name = "estadoFOT3";
            this.estadoFOT3.Size = new System.Drawing.Size(170, 90);
            this.estadoFOT3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estadoFOT3.TabIndex = 16;
            this.estadoFOT3.TabStop = false;
            // 
            // estado2FOT
            // 
            this.estado2FOT.ErrorImage = global::GestionDeEnvios.Properties.Resources.estado0;
            this.estado2FOT.Image = global::GestionDeEnvios.Properties.Resources.estado21;
            this.estado2FOT.Location = new System.Drawing.Point(453, 348);
            this.estado2FOT.Name = "estado2FOT";
            this.estado2FOT.Size = new System.Drawing.Size(170, 90);
            this.estado2FOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estado2FOT.TabIndex = 15;
            this.estado2FOT.TabStop = false;
            // 
            // estado1FOT
            // 
            this.estado1FOT.ErrorImage = global::GestionDeEnvios.Properties.Resources.estado0;
            this.estado1FOT.Image = global::GestionDeEnvios.Properties.Resources.estado11;
            this.estado1FOT.Location = new System.Drawing.Point(453, 348);
            this.estado1FOT.Name = "estado1FOT";
            this.estado1FOT.Size = new System.Drawing.Size(170, 90);
            this.estado1FOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estado1FOT.TabIndex = 14;
            this.estado1FOT.TabStop = false;
            // 
            // estado0FOT
            // 
            this.estado0FOT.ErrorImage = global::GestionDeEnvios.Properties.Resources.estado0;
            this.estado0FOT.Image = global::GestionDeEnvios.Properties.Resources.estado01;
            this.estado0FOT.Location = new System.Drawing.Point(453, 348);
            this.estado0FOT.Name = "estado0FOT";
            this.estado0FOT.Size = new System.Drawing.Size(170, 90);
            this.estado0FOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estado0FOT.TabIndex = 13;
            this.estado0FOT.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(873, 313);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizar.OverrideDefault.Back.ColorAngle = 45F;
            this.btnActualizar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizar.OverrideDefault.Border.ColorAngle = 45F;
            this.btnActualizar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizar.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizar.OverrideDefault.Border.Rounding = 20;
            this.btnActualizar.OverrideDefault.Border.Width = 1;
            this.btnActualizar.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnActualizar.Size = new System.Drawing.Size(147, 54);
            this.btnActualizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizar.StateCommon.Back.ColorAngle = 45F;
            this.btnActualizar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizar.StateCommon.Border.ColorAngle = 45F;
            this.btnActualizar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizar.StateCommon.Border.Rounding = 20;
            this.btnActualizar.StateCommon.Border.Width = 1;
            this.btnActualizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnActualizar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnActualizar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Values.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ConsultarEnviosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 456);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.estadoFOT4);
            this.Controls.Add(this.estadoFOT3);
            this.Controls.Add(this.estado2FOT);
            this.Controls.Add(this.estado1FOT);
            this.Controls.Add(this.estado0FOT);
            this.Controls.Add(this.estadoLBL);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.enviosDGV);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "ConsultarEnviosCliente";
            this.Text = "ConsultarEnviosCliente";
            this.Load += new System.EventHandler(this.ConsultarEnviosCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enviosDGV)).EndInit();
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel estadoLBL;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox estadoFOT4;
        private System.Windows.Forms.PictureBox estadoFOT3;
        private System.Windows.Forms.PictureBox estado2FOT;
        private System.Windows.Forms.PictureBox estado1FOT;
        private System.Windows.Forms.PictureBox estado0FOT;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnActualizar;
    }
}