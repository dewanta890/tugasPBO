namespace AplikasiPBO
{
    partial class Register
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
            this.label8 = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.domisili = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noHP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.namaPegawai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.tanggal);
            this.splitContainer1.Panel1.Controls.Add(this.pass);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.submit);
            this.splitContainer1.Panel1.Controls.Add(this.domisili);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.noHP);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.email);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.namaPegawai);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.NIP);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tanggal Lahir";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(13, 259);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(200, 23);
            this.tanggal.TabIndex = 9;
            this.tanggal.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(12, 211);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(243, 23);
            this.pass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(13, 396);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(242, 42);
            this.submit.TabIndex = 12;
            this.submit.Text = "Register";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // domisili
            // 
            this.domisili.Location = new System.Drawing.Point(13, 304);
            this.domisili.Name = "domisili";
            this.domisili.Size = new System.Drawing.Size(242, 86);
            this.domisili.TabIndex = 11;
            this.domisili.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Domisili";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // noHP
            // 
            this.noHP.Location = new System.Drawing.Point(12, 162);
            this.noHP.Name = "noHP";
            this.noHP.Size = new System.Drawing.Size(243, 23);
            this.noHP.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "NoHandphone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(12, 115);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(243, 23);
            this.email.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // namaPegawai
            // 
            this.namaPegawai.Location = new System.Drawing.Point(12, 71);
            this.namaPegawai.Name = "namaPegawai";
            this.namaPegawai.Size = new System.Drawing.Size(243, 23);
            this.namaPegawai.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nama Lengkap";
            // 
            // NIP
            // 
            this.NIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NIP.Location = new System.Drawing.Point(12, 27);
            this.NIP.Name = "NIP";
            this.NIP.Size = new System.Drawing.Size(243, 23);
            this.NIP.TabIndex = 1;
            this.NIP.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "NIP";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Register";
            this.Text = "Register Akun";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox email;
        private Label label6;
        private TextBox namaPegawai;
        private Label label5;
        private TextBox NIP;
        private Label label4;
        private Label label8;
        private TextBox noHP;
        private Label label7;
        private Button submit;
        private RichTextBox domisili;
        private Label label1;
        private DateTimePicker tanggal;
        private TextBox pass;
        private Label label2;
    }
}