namespace TOKO_SEPATU
{
    partial class penjual
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tampilkan_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // tampilkan_data
            // 
            this.tampilkan_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tampilkan_data.Location = new System.Drawing.Point(12, 354);
            this.tampilkan_data.Name = "tampilkan_data";
            this.tampilkan_data.Size = new System.Drawing.Size(166, 27);
            this.tampilkan_data.TabIndex = 1;
            this.tampilkan_data.Text = "TAMPILKAN DATA";
            this.tampilkan_data.UseVisualStyleBackColor = true;
            this.tampilkan_data.Click += new System.EventHandler(this.tampilkan_data_Click);
            // 
            // penjual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1166, 407);
            this.Controls.Add(this.tampilkan_data);
            this.Controls.Add(this.dataGridView1);
            this.Name = "penjual";
            this.Text = "LAPORAN TRANSAKSI";
            this.Load += new System.EventHandler(this.penjual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tampilkan_data;
    }
}