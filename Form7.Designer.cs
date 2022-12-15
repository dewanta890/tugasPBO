namespace AplikasiPBO
{
    partial class detailAbsensi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tanggalAbsen = new System.Windows.Forms.Label();
            this.absensi = new System.Windows.Forms.Label();
            this.pulang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nip_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.status);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tanggalAbsen);
            this.splitContainer1.Panel1.Controls.Add(this.absensi);
            this.splitContainer1.Panel1.Controls.Add(this.pulang);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.nip_title);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 0;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(129, 242);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(27, 15);
            this.status.TabIndex = 27;
            this.status.Text = "null";
            this.status.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "NIP Pegawai";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tanggalAbsen
            // 
            this.tanggalAbsen.AutoSize = true;
            this.tanggalAbsen.Location = new System.Drawing.Point(129, 121);
            this.tanggalAbsen.Name = "tanggalAbsen";
            this.tanggalAbsen.Size = new System.Drawing.Size(27, 15);
            this.tanggalAbsen.TabIndex = 24;
            this.tanggalAbsen.Text = "null";
            // 
            // absensi
            // 
            this.absensi.AutoSize = true;
            this.absensi.Location = new System.Drawing.Point(129, 164);
            this.absensi.Name = "absensi";
            this.absensi.Size = new System.Drawing.Size(27, 15);
            this.absensi.TabIndex = 23;
            this.absensi.Text = "null";
            // 
            // pulang
            // 
            this.pulang.AutoSize = true;
            this.pulang.Location = new System.Drawing.Point(129, 204);
            this.pulang.Name = "pulang";
            this.pulang.Size = new System.Drawing.Size(27, 15);
            this.pulang.TabIndex = 22;
            this.pulang.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Waktu Pulang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Waktu Absen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "Absen Pulang";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tanggal";
            // 
            // nip_title
            // 
            this.nip_title.AutoSize = true;
            this.nip_title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nip_title.Location = new System.Drawing.Point(119, 55);
            this.nip_title.Name = "nip_title";
            this.nip_title.Size = new System.Drawing.Size(38, 20);
            this.nip_title.TabIndex = 8;
            this.nip_title.Text = "Null";
            this.nip_title.Click += new System.EventHandler(this.label2_Click);
            // 
            // detailAbsensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "detailAbsensi";
            this.Text = "Detail Absensi";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private Button button3;
        private Label label1;
        private Label nip_title;
        private Label tanggalAbsen;
        private Label absensi;
        private Label pulang;
        private Label label4;
        private Label label2;
        private Label status;
        private Label label6;
    }
}