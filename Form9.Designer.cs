namespace AplikasiPBO
{
    partial class absensiAdmin
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateAkhir = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateAwal = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateAkhir);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateAwal);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 10;
            // 
            // dateAkhir
            // 
            this.dateAkhir.Location = new System.Drawing.Point(406, 11);
            this.dateAkhir.Name = "dateAkhir";
            this.dateAkhir.Size = new System.Drawing.Size(200, 23);
            this.dateAkhir.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Akhir Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Awal Tanggal";
            // 
            // dateAwal
            // 
            this.dateAwal.Location = new System.Drawing.Point(103, 11);
            this.dateAwal.Name = "dateAwal";
            this.dateAwal.Size = new System.Drawing.Size(200, 23);
            this.dateAwal.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Rekap Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Riwayat Absensi";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid.Location = new System.Drawing.Point(0, 78);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(800, 372);
            this.dataGrid.TabIndex = 7;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(673, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(560, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Tambah Absensi";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // absensiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Name = "absensiAdmin";
            this.Text = "Absensi Editor";
            this.Load += new System.EventHandler(this.absensiAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel1;
        private DateTimePicker dateAkhir;
        private Label label4;
        private Label label3;
        private DateTimePicker dateAwal;
        private Button button3;
        private Label label1;
        private DataGridView dataGrid;
        private Button button5;
        private Button button9;
    }
}