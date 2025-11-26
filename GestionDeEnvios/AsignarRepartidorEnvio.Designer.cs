namespace GestionDeEnvios
{
    partial class AsignarRepartidorEnvio
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
            this.dgvRepartidores = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnAsignar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.controlIdRepartidor = new GestionDeEnvios.Controles.ControlId();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controlIdEnvio = new GestionDeEnvios.Controles.ControlId();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepartidores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnvios
            // 
            this.dgvEnvios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvios.Location = new System.Drawing.Point(12, 60);
            this.dgvEnvios.MultiSelect = false;
            this.dgvEnvios.Name = "dgvEnvios";
            this.dgvEnvios.RowHeadersWidth = 51;
            this.dgvEnvios.RowTemplate.Height = 24;
            this.dgvEnvios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnvios.Size = new System.Drawing.Size(1458, 286);
            this.dgvEnvios.TabIndex = 10;
            // 
            // dgvRepartidores
            // 
            this.dgvRepartidores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRepartidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepartidores.Location = new System.Drawing.Point(12, 396);
            this.dgvRepartidores.MultiSelect = false;
            this.dgvRepartidores.Name = "dgvRepartidores";
            this.dgvRepartidores.RowHeadersWidth = 51;
            this.dgvRepartidores.RowTemplate.Height = 24;
            this.dgvRepartidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepartidores.Size = new System.Drawing.Size(1458, 239);
            this.dgvRepartidores.TabIndex = 11;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(949, 668);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAsignar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAsignar.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAsignar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAsignar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAsignar.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAsignar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAsignar.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAsignar.OverrideDefault.Border.Rounding = 20;
            this.btnAsignar.OverrideDefault.Border.Width = 1;
            this.btnAsignar.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAsignar.Size = new System.Drawing.Size(196, 67);
            this.btnAsignar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAsignar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAsignar.StateCommon.Back.ColorAngle = 45F;
            this.btnAsignar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAsignar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAsignar.StateCommon.Border.ColorAngle = 45F;
            this.btnAsignar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAsignar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAsignar.StateCommon.Border.Rounding = 20;
            this.btnAsignar.StateCommon.Border.Width = 1;
            this.btnAsignar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAsignar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAsignar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.TabIndex = 24;
            this.btnAsignar.Values.Text = "Asignar Envio";
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // controlIdRepartidor
            // 
            this.controlIdRepartidor.Etiqueta = "ID Repartidor";
            this.controlIdRepartidor.Location = new System.Drawing.Point(114, 719);
            this.controlIdRepartidor.Margin = new System.Windows.Forms.Padding(4);
            this.controlIdRepartidor.Name = "controlIdRepartidor";
            this.controlIdRepartidor.Size = new System.Drawing.Size(828, 69);
            this.controlIdRepartidor.TabIndex = 23;
            this.controlIdRepartidor.Texto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Envios Con Paquetes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(623, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Repartidores Disponibles";
            // 
            // controlIdEnvio
            // 
            this.controlIdEnvio.Etiqueta = "ID Envio";
            this.controlIdEnvio.Location = new System.Drawing.Point(114, 642);
            this.controlIdEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.controlIdEnvio.Name = "controlIdEnvio";
            this.controlIdEnvio.Size = new System.Drawing.Size(828, 69);
            this.controlIdEnvio.TabIndex = 27;
            this.controlIdEnvio.Texto = "";
            // 
            // AsignarRepartidorEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 801);
            this.Controls.Add(this.controlIdEnvio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.controlIdRepartidor);
            this.Controls.Add(this.dgvRepartidores);
            this.Controls.Add(this.dgvEnvios);
            this.Name = "AsignarRepartidorEnvio";
            this.Text = "AsignarRepartidorEnvio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepartidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEnvios;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvRepartidores;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAsignar;
        private Controles.ControlId controlIdRepartidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Controles.ControlId controlIdEnvio;
    }
}