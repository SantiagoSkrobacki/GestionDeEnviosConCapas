namespace GestionDeEnvios
{
    partial class ConsultarEnvioDestinatario
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
            ((System.ComponentModel.ISupportInitialize)(this.enviosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // enviosDGV
            // 
            this.enviosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enviosDGV.Location = new System.Drawing.Point(12, 12);
            this.enviosDGV.Name = "enviosDGV";
            this.enviosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enviosDGV.Size = new System.Drawing.Size(776, 285);
            this.enviosDGV.TabIndex = 3;
            // 
            // ConsultarEnvioDestinatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enviosDGV);
            this.Name = "ConsultarEnvioDestinatario";
            this.Text = "ConsultarEnvioDestinatario";
            this.Load += new System.EventHandler(this.ConsultarEnvioDestinatario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enviosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView enviosDGV;
    }
}