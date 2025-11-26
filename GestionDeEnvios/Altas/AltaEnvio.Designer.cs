namespace GestionDeEnvios.Altas
{
    partial class AltaEnvio
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
            this.dgvClientes = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.controlIdCliente = new GestionDeEnvios.Controles.ControlId();
            this.controlIdDestinatario = new GestionDeEnvios.Controles.ControlId();
            this.btnCrearEnvio = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDestinatarios = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 67);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1458, 246);
            this.dgvClientes.TabIndex = 3;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // controlIdCliente
            // 
            this.controlIdCliente.Etiqueta = "ID Cliente";
            this.controlIdCliente.Location = new System.Drawing.Point(329, 320);
            this.controlIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.controlIdCliente.Name = "controlIdCliente";
            this.controlIdCliente.Size = new System.Drawing.Size(828, 69);
            this.controlIdCliente.TabIndex = 14;
            this.controlIdCliente.Texto = "";
            // 
            // controlIdDestinatario
            // 
            this.controlIdDestinatario.Etiqueta = "ID Destinatario";
            this.controlIdDestinatario.Location = new System.Drawing.Point(320, 652);
            this.controlIdDestinatario.Margin = new System.Windows.Forms.Padding(4);
            this.controlIdDestinatario.Name = "controlIdDestinatario";
            this.controlIdDestinatario.Size = new System.Drawing.Size(828, 69);
            this.controlIdDestinatario.TabIndex = 15;
            this.controlIdDestinatario.Texto = "";
            // 
            // btnCrearEnvio
            // 
            this.btnCrearEnvio.Location = new System.Drawing.Point(573, 716);
            this.btnCrearEnvio.Name = "btnCrearEnvio";
            this.btnCrearEnvio.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCrearEnvio.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCrearEnvio.OverrideDefault.Back.ColorAngle = 45F;
            this.btnCrearEnvio.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCrearEnvio.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCrearEnvio.OverrideDefault.Border.ColorAngle = 45F;
            this.btnCrearEnvio.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCrearEnvio.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCrearEnvio.OverrideDefault.Border.Rounding = 20;
            this.btnCrearEnvio.OverrideDefault.Border.Width = 1;
            this.btnCrearEnvio.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEnvio.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCrearEnvio.Size = new System.Drawing.Size(196, 67);
            this.btnCrearEnvio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCrearEnvio.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCrearEnvio.StateCommon.Back.ColorAngle = 45F;
            this.btnCrearEnvio.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCrearEnvio.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCrearEnvio.StateCommon.Border.ColorAngle = 45F;
            this.btnCrearEnvio.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCrearEnvio.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCrearEnvio.StateCommon.Border.Rounding = 20;
            this.btnCrearEnvio.StateCommon.Border.Width = 1;
            this.btnCrearEnvio.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCrearEnvio.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCrearEnvio.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEnvio.TabIndex = 16;
            this.btnCrearEnvio.Values.Text = "Crear Envío";
            this.btnCrearEnvio.Click += new System.EventHandler(this.btnCrearEnvio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clientes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvDestinatarios
            // 
            this.dgvDestinatarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDestinatarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinatarios.Location = new System.Drawing.Point(12, 426);
            this.dgvDestinatarios.MultiSelect = false;
            this.dgvDestinatarios.Name = "dgvDestinatarios";
            this.dgvDestinatarios.RowHeadersWidth = 51;
            this.dgvDestinatarios.RowTemplate.Height = 24;
            this.dgvDestinatarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestinatarios.Size = new System.Drawing.Size(1458, 219);
            this.dgvDestinatarios.TabIndex = 17;
            this.dgvDestinatarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestinatarios_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Destinatarios";
            // 
            // AltaEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 801);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDestinatarios);
            this.Controls.Add(this.btnCrearEnvio);
            this.Controls.Add(this.controlIdDestinatario);
            this.Controls.Add(this.controlIdCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltaEnvio";
            this.Text = "Envio";
            this.Load += new System.EventHandler(this.AltaEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvClientes;
        private Controles.ControlId controlIdCliente;
        private Controles.ControlId controlIdDestinatario;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCrearEnvio;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDestinatarios;
        private System.Windows.Forms.Label label1;
    }
}