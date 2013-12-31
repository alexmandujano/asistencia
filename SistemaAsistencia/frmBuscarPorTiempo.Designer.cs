namespace SistemaAsistencia
{
    partial class frmBuscarPorTiempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPorTiempo));
            this.dtgbus = new System.Windows.Forms.DataGridView();
            this.btnreporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbus)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgbus
            // 
            this.dtgbus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbus.Location = new System.Drawing.Point(12, 34);
            this.dtgbus.Name = "dtgbus";
            this.dtgbus.Size = new System.Drawing.Size(698, 385);
            this.dtgbus.TabIndex = 2;
            // 
            // btnreporte
            // 
            this.btnreporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnreporte.BackgroundImage")));
            this.btnreporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreporte.FlatAppearance.BorderSize = 0;
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Location = new System.Drawing.Point(652, 425);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(58, 49);
            this.btnreporte.TabIndex = 3;
            this.btnreporte.Text = "  ";
            this.btnreporte.UseVisualStyleBackColor = true;
            // 
            // frmBuscarPorTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 507);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.dtgbus);
            this.Name = "frmBuscarPorTiempo";
            this.Text = "frmBuscarPorTiempo";
            this.Load += new System.EventHandler(this.frmBuscarPorTiempo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgbus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.DataGridView dtgbus;
    }
}