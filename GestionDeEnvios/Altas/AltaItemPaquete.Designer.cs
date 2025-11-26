namespace GestionDeEnvios.Altas
{
    partial class AltaItemPaquete
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEnvios = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.controlIdEnvio = new GestionDeEnvios.Controles.ControlId();
            this.ControlDescripcion = new GestionDeEnvios.MiControl();
            this.label1 = new System.Windows.Forms.Label();
            this.ControlPeso = new GestionDeEnvios.MiControl();
            this.CheckBoxFragil = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.LabelTituloCosto = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCalcularCosto = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblCostoPaquete = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAgregarItemPaquete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Envíos Empaquetables";
            // 
            // dgvEnvios
            // 
            this.dgvEnvios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvios.Location = new System.Drawing.Point(12, 122);
            this.dgvEnvios.MultiSelect = false;
            this.dgvEnvios.Name = "dgvEnvios";
            this.dgvEnvios.RowHeadersWidth = 51;
            this.dgvEnvios.RowTemplate.Height = 24;
            this.dgvEnvios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnvios.Size = new System.Drawing.Size(646, 633);
            this.dgvEnvios.TabIndex = 8;
            this.dgvEnvios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnvios_CellClick);
            // 
            // controlIdEnvio
            // 
            this.controlIdEnvio.Etiqueta = "ID Envío";
            this.controlIdEnvio.Location = new System.Drawing.Point(688, 132);
            this.controlIdEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.controlIdEnvio.Name = "controlIdEnvio";
            this.controlIdEnvio.Size = new System.Drawing.Size(828, 69);
            this.controlIdEnvio.TabIndex = 15;
            this.controlIdEnvio.Texto = "";
            // 
            // ControlDescripcion
            // 
            this.ControlDescripcion.Etiqueta = "Descripción";
            this.ControlDescripcion.Location = new System.Drawing.Point(688, 209);
            this.ControlDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.ControlDescripcion.Name = "ControlDescripcion";
            this.ControlDescripcion.Size = new System.Drawing.Size(828, 69);
            this.ControlDescripcion.TabIndex = 16;
            this.ControlDescripcion.Texto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(956, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Datos Paquete";
            // 
            // ControlPeso
            // 
            this.ControlPeso.Etiqueta = "Peso";
            this.ControlPeso.Location = new System.Drawing.Point(688, 286);
            this.ControlPeso.Margin = new System.Windows.Forms.Padding(4);
            this.ControlPeso.Name = "ControlPeso";
            this.ControlPeso.Size = new System.Drawing.Size(828, 69);
            this.ControlPeso.TabIndex = 18;
            this.ControlPeso.Texto = "";
            // 
            // CheckBoxFragil
            // 
            this.CheckBoxFragil.Location = new System.Drawing.Point(942, 362);
            this.CheckBoxFragil.Name = "CheckBoxFragil";
            this.CheckBoxFragil.Size = new System.Drawing.Size(175, 21);
            this.CheckBoxFragil.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxFragil.TabIndex = 19;
            this.CheckBoxFragil.Values.Text = " Es un producto frágil";
            // 
            // LabelTituloCosto
            // 
            this.LabelTituloCosto.Location = new System.Drawing.Point(688, 523);
            this.LabelTituloCosto.Name = "LabelTituloCosto";
            this.LabelTituloCosto.Size = new System.Drawing.Size(326, 25);
            this.LabelTituloCosto.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTituloCosto.TabIndex = 20;
            this.LabelTituloCosto.Values.Text = "El costo de enviar el paquetes es de:";
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(930, 405);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCalcularCosto.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCalcularCosto.OverrideDefault.Back.ColorAngle = 45F;
            this.btnCalcularCosto.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCalcularCosto.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCalcularCosto.OverrideDefault.Border.ColorAngle = 45F;
            this.btnCalcularCosto.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCalcularCosto.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCalcularCosto.OverrideDefault.Border.Rounding = 20;
            this.btnCalcularCosto.OverrideDefault.Border.Width = 1;
            this.btnCalcularCosto.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCosto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCalcularCosto.Size = new System.Drawing.Size(196, 67);
            this.btnCalcularCosto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCalcularCosto.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCalcularCosto.StateCommon.Back.ColorAngle = 45F;
            this.btnCalcularCosto.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCalcularCosto.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCalcularCosto.StateCommon.Border.ColorAngle = 45F;
            this.btnCalcularCosto.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCalcularCosto.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCalcularCosto.StateCommon.Border.Rounding = 20;
            this.btnCalcularCosto.StateCommon.Border.Width = 1;
            this.btnCalcularCosto.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCalcularCosto.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCalcularCosto.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCosto.TabIndex = 21;
            this.btnCalcularCosto.Values.Text = "Calcular Costo";
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // lblCostoPaquete
            // 
            this.lblCostoPaquete.Location = new System.Drawing.Point(1036, 524);
            this.lblCostoPaquete.Name = "lblCostoPaquete";
            this.lblCostoPaquete.Size = new System.Drawing.Size(19, 25);
            this.lblCostoPaquete.StateCommon.ShortText.Color1 = System.Drawing.Color.ForestGreen;
            this.lblCostoPaquete.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoPaquete.TabIndex = 22;
            this.lblCostoPaquete.Values.Text = "-";
            // 
            // btnAgregarItemPaquete
            // 
            this.btnAgregarItemPaquete.Location = new System.Drawing.Point(911, 615);
            this.btnAgregarItemPaquete.Name = "btnAgregarItemPaquete";
            this.btnAgregarItemPaquete.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarItemPaquete.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarItemPaquete.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAgregarItemPaquete.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarItemPaquete.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarItemPaquete.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAgregarItemPaquete.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarItemPaquete.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarItemPaquete.OverrideDefault.Border.Rounding = 20;
            this.btnAgregarItemPaquete.OverrideDefault.Border.Width = 1;
            this.btnAgregarItemPaquete.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItemPaquete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAgregarItemPaquete.Size = new System.Drawing.Size(244, 73);
            this.btnAgregarItemPaquete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarItemPaquete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarItemPaquete.StateCommon.Back.ColorAngle = 45F;
            this.btnAgregarItemPaquete.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarItemPaquete.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarItemPaquete.StateCommon.Border.ColorAngle = 45F;
            this.btnAgregarItemPaquete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarItemPaquete.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarItemPaquete.StateCommon.Border.Rounding = 20;
            this.btnAgregarItemPaquete.StateCommon.Border.Width = 1;
            this.btnAgregarItemPaquete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAgregarItemPaquete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAgregarItemPaquete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItemPaquete.TabIndex = 23;
            this.btnAgregarItemPaquete.Values.Text = "Agregar Paquete";
            this.btnAgregarItemPaquete.Click += new System.EventHandler(this.btnAgregarItemPaquete_Click);
            // 
            // AltaItemPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 801);
            this.Controls.Add(this.btnAgregarItemPaquete);
            this.Controls.Add(this.lblCostoPaquete);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.LabelTituloCosto);
            this.Controls.Add(this.CheckBoxFragil);
            this.Controls.Add(this.ControlPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ControlDescripcion);
            this.Controls.Add(this.controlIdEnvio);
            this.Controls.Add(this.dgvEnvios);
            this.Controls.Add(this.label3);
            this.Name = "AltaItemPaquete";
            this.Text = "AltaItemPaquete";
            this.Load += new System.EventHandler(this.AltaItemPaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEnvios;
        private Controles.ControlId controlIdEnvio;
        private MiControl ControlDescripcion;
        private System.Windows.Forms.Label label1;
        private MiControl ControlPeso;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox CheckBoxFragil;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelTituloCosto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCalcularCosto;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCostoPaquete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAgregarItemPaquete;
    }
}