namespace SistemaAsistencia
{
    partial class frmbus
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
            this.dtgbus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbus)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgbus
            // 
            this.dtgbus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbus.Location = new System.Drawing.Point(12, 67);
            this.dtgbus.Name = "dtgbus";
            this.dtgbus.Size = new System.Drawing.Size(722, 401);
            this.dtgbus.TabIndex = 0;
            // 
            // frmbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 480);
            this.Controls.Add(this.dtgbus);
            this.Name = "frmbus";
            this.Text = "buscar";
            this.Load += new System.EventHandler(this.frmbus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgbus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgbus;
    }
}