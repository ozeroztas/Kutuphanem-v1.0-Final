namespace Kütüphanem.Kullanici
{
    partial class KullaniciEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kullaniciAdtxt = new System.Windows.Forms.TextBox();
            this.kullaniciSoyadtxt = new System.Windows.Forms.TextBox();
            this.kullaniciTCtxt = new System.Windows.Forms.TextBox();
            this.kullaniciTeltxt = new System.Windows.Forms.TextBox();
            this.kullaniciMailtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.kullaniciCezatxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail:";
            // 
            // kullaniciAdtxt
            // 
            this.kullaniciAdtxt.Location = new System.Drawing.Point(110, 70);
            this.kullaniciAdtxt.Name = "kullaniciAdtxt";
            this.kullaniciAdtxt.Size = new System.Drawing.Size(182, 22);
            this.kullaniciAdtxt.TabIndex = 5;
            // 
            // kullaniciSoyadtxt
            // 
            this.kullaniciSoyadtxt.Location = new System.Drawing.Point(110, 98);
            this.kullaniciSoyadtxt.Name = "kullaniciSoyadtxt";
            this.kullaniciSoyadtxt.Size = new System.Drawing.Size(182, 22);
            this.kullaniciSoyadtxt.TabIndex = 6;
            // 
            // kullaniciTCtxt
            // 
            this.kullaniciTCtxt.Location = new System.Drawing.Point(110, 156);
            this.kullaniciTCtxt.Name = "kullaniciTCtxt";
            this.kullaniciTCtxt.Size = new System.Drawing.Size(182, 22);
            this.kullaniciTCtxt.TabIndex = 7;
            // 
            // kullaniciTeltxt
            // 
            this.kullaniciTeltxt.Location = new System.Drawing.Point(110, 184);
            this.kullaniciTeltxt.Name = "kullaniciTeltxt";
            this.kullaniciTeltxt.Size = new System.Drawing.Size(182, 22);
            this.kullaniciTeltxt.TabIndex = 8;
            // 
            // kullaniciMailtxt
            // 
            this.kullaniciMailtxt.Location = new System.Drawing.Point(110, 214);
            this.kullaniciMailtxt.Name = "kullaniciMailtxt";
            this.kullaniciMailtxt.Size = new System.Drawing.Size(182, 22);
            this.kullaniciMailtxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cinsiyet:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(121, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 20);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "E";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(164, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "K";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 684);
            this.dataGridView1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ceza:";
            // 
            // kullaniciCezatxt
            // 
            this.kullaniciCezatxt.Location = new System.Drawing.Point(110, 249);
            this.kullaniciCezatxt.Name = "kullaniciCezatxt";
            this.kullaniciCezatxt.Size = new System.Drawing.Size(182, 22);
            this.kullaniciCezatxt.TabIndex = 16;
            // 
            // KullaniciEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1476, 726);
            this.Controls.Add(this.kullaniciCezatxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kullaniciMailtxt);
            this.Controls.Add(this.kullaniciTeltxt);
            this.Controls.Add(this.kullaniciTCtxt);
            this.Controls.Add(this.kullaniciSoyadtxt);
            this.Controls.Add(this.kullaniciAdtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciEkleForm";
            this.Text = "KullaniciEkleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullaniciEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kullaniciAdtxt;
        private System.Windows.Forms.TextBox kullaniciSoyadtxt;
        private System.Windows.Forms.TextBox kullaniciTCtxt;
        private System.Windows.Forms.TextBox kullaniciTeltxt;
        private System.Windows.Forms.TextBox kullaniciMailtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kullaniciCezatxt;
    }
}