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
            this.tanggalAbsen = new System.Windows.Forms.Label();
            this.absensi = new System.Windows.Forms.Label();
            this.pulang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nip_title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tanggalAbsen);
            this.splitContainer1.Panel1.Controls.Add(this.absensi);
            this.splitContainer1.Panel1.Controls.Add(this.pulang);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.nip_title);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 0;
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
            this.nip_title.Location = new System.Drawing.Point(129, 55);
            this.nip_title.Name = "nip_title";
            this.nip_title.Size = new System.Drawing.Size(29, 15);
            this.nip_title.TabIndex = 8;
            this.nip_title.Text = "Null";
            this.nip_title.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Upload File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(199, 415);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 415);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ajukan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Jenis Ijin";
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
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private Button button2;
        private Label label8;
        private Button button1;
        private Button button3;
        private Label label1;
        private Label nip_title;
        private Label tanggalAbsen;
        private Label absensi;
        private Label pulang;
        private Label label4;
    }
}