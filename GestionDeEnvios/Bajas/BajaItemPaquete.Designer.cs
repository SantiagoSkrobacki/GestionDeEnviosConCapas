namespace GestionDeEnvios.Bajas
{
    partial class BajaItemPaquete
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
            this.dgvEnvios = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.controlIdPaquete = new GestionDeEnvios.Controles.ControlId();
            this.btnEliminar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvPaquetes = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnvios
            // 
            this.dgvEnvios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvios.Location = new System.Drawing.Point(43, 107);
            this.dgvEnvios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEnvios.MultiSelect = false;
            this.dgvEnvios.Name = "dgvEnvios";
            this.dgvEnvios.RowHeadersWidth = 51;
            this.dgvEnvios.RowTemplate.Height = 24;
            this.dgvEnvios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnvios.Size = new System.Drawing.Size(484, 458);
            this.dgvEnvios.TabIndex = 9;
            this.dgvEnvios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnvios_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Envios ";
            // 
            // controlIdPaquete
            // 
            this.controlIdPaquete.Etiqueta = "ID Paquete";
            this.controlIdPaquete.Location = new System.Drawing.Point(274, 587);
            this.controlIdPaquete.Name = "controlIdPaquete";
            this.controlIdPaquete.Size = new System.Drawing.Size(621, 56);
            this.controlIdPaquete.TabIndex = 16;
            this.controlIdPaquete.Texto = "";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(894, 587);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminar.OverrideDefault.Back.ColorAngle = 45F;
            this.btnEliminar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminar.OverrideDefault.Border.ColorAngle = 45F;
            this.btnEliminar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminar.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminar.OverrideDefault.Border.Rounding = 20;
            this.btnEliminar.OverrideDefault.Border.Width = 1;
            this.btnEliminar.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnEliminar.Size = new System.Drawing.Size(147, 54);
            this.btnEliminar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminar.StateCommon.Back.ColorAngle = 45F;
            this.btnEliminar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminar.StateCommon.Border.ColorAngle = 45F;
            this.btnEliminar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminar.StateCommon.Border.Rounding = 20;
            this.btnEliminar.StateCommon.Border.Width = 1;
            this.btnEliminar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEliminar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEliminar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Values.Text = "Eliminar Paquete";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.Location = new System.Drawing.Point(556, 107);
            this.dgvPaquetes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPaquetes.MultiSelect = false;
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.RowHeadersWidth = 51;
            this.dgvPaquetes.RowTemplate.Height = 24;
            this.dgvPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaquetes.Size = new System.Drawing.Size(484, 458);
            this.dgvPaquetes.TabIndex = 23;
            this.dgvPaquetes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaquetes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Paquetes Dentro Del Envio";
            // 
            // BajaItemPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPaquetes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.controlIdPaquete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEnvios);
            this.Name = "BajaItemPaquete";
            this.Text = "Eliminar Item Paquete";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEnvios;
        private System.Windows.Forms.Label label3;
        private Controles.ControlId controlIdPaquete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEliminar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvPaquetes;
        private System.Windows.Forms.Label label1;
    }
}