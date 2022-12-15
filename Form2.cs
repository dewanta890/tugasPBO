using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPBO
{
    public partial class Beranda : Form
    {
       
        DBhelper getDataDB = new DBhelper();
        public static string uid = "";
        public static string nama = "";
        public static string noHp = "";
        public static string email = "";
        public static string jabatan = "";
        public static string pass = "";
        public static string domisili = "";
        public static string tanggal = "";
        public static string nip = "";


        public Beranda()
        {
            InitializeComponent();

            DataGridViewButtonColumn detailButton = new DataGridViewButtonColumn();
            DataGridViewButtonColumn absensiButton = new DataGridViewButtonColumn();

            var data = getDataDB.ReaderDB();
            dataGrid.DataSource = data;
            detailButton.UseColumnTextForButtonValue = true;
            detailButton.Name = "detail_colom";
            detailButton.HeaderText = "Detail";
            detailButton.Text = "Detail";

            var data2 = getDataDB.ReaderAbsensiDB();
            absensiGrid.DataSource = data2;
            absensiButton.UseColumnTextForButtonValue = true;
            absensiButton.Name = "absensi_detail";
            absensiButton.HeaderText = "Absensi Detail";
            absensiButton.Text = "Detail";


            if (dataGrid.Columns["detail_colom"] == null || absensiGrid.Columns["detail.colom"] == null )
            {
                dataGrid.Columns.Insert(dataGrid.ColumnCount, detailButton);
                absensiGrid.Columns.Insert(absensiGrid.ColumnCount, absensiButton);
            }
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = (Login)Tag;
            form1.Show();
            Close();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void absensiTab_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGrid.Columns[e.ColumnIndex].Name == "detail_colom")
            {
                uid = dataGrid.Rows[e.RowIndex].Cells["uid_pegawai"].Value.ToString();
                nama = dataGrid.Rows[e.RowIndex].Cells["nama_pegawai"].Value.ToString();
                noHp = dataGrid.Rows[e.RowIndex].Cells["no_handphone"].Value.ToString();
                email = dataGrid.Rows[e.RowIndex].Cells["email"].Value.ToString();
                jabatan = dataGrid.Rows[e.RowIndex].Cells["jabatan"].Value.ToString();
                pass = dataGrid.Rows[e.RowIndex].Cells["pass"].Value.ToString();
                domisili = dataGrid.Rows[e.RowIndex].Cells["domisili"].Value.ToString();
                tanggal = dataGrid.Rows[e.RowIndex].Cells["tanggal_lahir"].Value.ToString();
                nip = absensiGrid.Rows[e.RowIndex].Cells["nip"].Value.ToString();
                editProfil akumDetail = new editProfil();
                akumDetail.Show();
            }
            else
            {

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = getDataDB.ReaderDB();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Register Register = new Register();
            Register.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Columns[e.ColumnIndex].Name == "detail_colom")
            {
                nip = absensiGrid.Rows[e.RowIndex].Cells["nip"].Value.ToString();
                absensiAdmin AbsensiDetail = new absensiAdmin();
                AbsensiDetail.Show();
                
            }
                
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            absensiGrid.DataSource = getDataDB.ReaderDB();
        }
    }
}
