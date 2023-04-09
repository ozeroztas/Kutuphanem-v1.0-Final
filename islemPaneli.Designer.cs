namespace Kütüphanem
{
    partial class islemPaneli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kullaniciBilgiPaneli = new System.Windows.Forms.Panel();
            this.Kullanicibtn = new System.Windows.Forms.Button();
            this.ekleKullanicibtn = new System.Windows.Forms.Button();
            this.guncelleKullanicibtn = new System.Windows.Forms.Button();
            this.silKullanicibtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.silKullanicibtn);
            this.panel1.Controls.Add(this.guncelleKullanicibtn);
            this.panel1.Controls.Add(this.ekleKullanicibtn);
            this.panel1.Controls.Add(this.Kullanicibtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 595);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // kullaniciBilgiPaneli
            // 
            this.kullaniciBilgiPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.kullaniciBilgiPaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciBilgiPaneli.Location = new System.Drawing.Point(152, 0);
            this.kullaniciBilgiPaneli.Name = "kullaniciBilgiPaneli";
            this.kullaniciBilgiPaneli.Size = new System.Drawing.Size(1005, 42);
            this.kullaniciBilgiPaneli.TabIndex = 1;
            // 
            // Kullanicibtn
            // 
            this.Kullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Kullanicibtn.Location = new System.Drawing.Point(0, 0);
            this.Kullanicibtn.Name = "Kullanicibtn";
            this.Kullanicibtn.Size = new System.Drawing.Size(152, 60);
            this.Kullanicibtn.TabIndex = 0;
            this.Kullanicibtn.Text = "Kullanıcılar";
            this.Kullanicibtn.UseVisualStyleBackColor = true;
            this.Kullanicibtn.Click += new System.EventHandler(this.Kullanicibtn_Click);
            // 
            // ekleKullanicibtn
            // 
            this.ekleKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ekleKullanicibtn.Location = new System.Drawing.Point(0, 60);
            this.ekleKullanicibtn.Name = "ekleKullanicibtn";
            this.ekleKullanicibtn.Size = new System.Drawing.Size(152, 60);
            this.ekleKullanicibtn.TabIndex = 1;
            this.ekleKullanicibtn.Text = "Ekle";
            this.ekleKullanicibtn.UseVisualStyleBackColor = true;
            // 
            // guncelleKullanicibtn
            // 
            this.guncelleKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.guncelleKullanicibtn.Location = new System.Drawing.Point(0, 120);
            this.guncelleKullanicibtn.Name = "guncelleKullanicibtn";
            this.guncelleKullanicibtn.Size = new System.Drawing.Size(152, 60);
            this.guncelleKullanicibtn.TabIndex = 2;
            this.guncelleKullanicibtn.Text = "Güncelle";
            this.guncelleKullanicibtn.UseVisualStyleBackColor = true;
            // 
            // silKullanicibtn
            // 
            this.silKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.silKullanicibtn.Location = new System.Drawing.Point(0, 180);
            this.silKullanicibtn.Name = "silKullanicibtn";
            this.silKullanicibtn.Size = new System.Drawing.Size(152, 60);
            this.silKullanicibtn.TabIndex = 3;
            this.silKullanicibtn.Text = "Sil";
            this.silKullanicibtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(152, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 553);
            this.dataGridView1.TabIndex = 2;
            // 
            // islemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kullaniciBilgiPaneli);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "islemPaneli";
            this.Text = "islemPaneli";
            this.Load += new System.EventHandler(this.islemPaneli_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Kullanicibtn;
        private System.Windows.Forms.Panel kullaniciBilgiPaneli;
        private System.Windows.Forms.Button silKullanicibtn;
        private System.Windows.Forms.Button guncelleKullanicibtn;
        private System.Windows.Forms.Button ekleKullanicibtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}