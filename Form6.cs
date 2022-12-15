using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPBO
{
    public partial class BerandaPegawai : Form
    {
        public DataGridViewButtonColumn detailButton = new DataGridViewButtonColumn();
        DBhelper getDataDB = new DBhelper();
        public static string nip = "";
        public static string uid = "";
        public static string uidP = "";
        public static string awal = "";
        public static string akhir = "";

        public BerandaPegawai()
        {
            InitializeComponent();
            dataGrid.DataSource = getDataDB.AbsenViewerDB(Login.nip.ToString());
            detailButton.UseColumnTextForButtonValue = true;
            detailButton.Name = "detail_colom";
            detailButton.HeaderText = "Detail";
            detailButton.Text = "Detail";


            if (dataGrid.Columns["detail_colom"] == null)
            {
                dataGrid.Columns.Insert(dataGrid.ColumnCount, detailButton);
            }

            var dataprofil = getDataDB.ReaderSingleDB(Login.nip);
            nama.Text = dataprofil.Rows[0]["nama_pegawai"].ToString();
            pass.Text = dataprofil.Rows[0]["pass"].ToString();
            noHp.Text = dataprofil.Rows[0]["no_handphone"].ToString();
            email.Text = dataprofil.Rows[0]["email"].ToString();
            tanggal.Text = dataprofil.Rows[0]["tanggal_lahir"].ToString();
            domisili.Text = dataprofil.Rows[0]["domisili"].ToString();
            uidP = dataprofil.Rows[0]["uid_pegawai"].ToString();
           

        }


        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Columns[e.ColumnIndex].Name == "detail_colom")
            {
                uid = dataGrid.Rows[e.RowIndex].Cells["uid"].Value.ToString();
                detailAbsensi tambahAbsensi = new detailAbsensi();
                tambahAbsensi.Show();
                
                
            }
            else
            {

            }
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = (Login)Tag;
            form1.Show();
            Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nip = Login.nip.ToString();
            var kembali = getDataDB.TambahAbsenDB(Login.nip);
            if (kembali == "berhasil") 
            {
                MessageBox.Show(kembali);
            }
            else
            {
                MessageBox.Show(kembali);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nip = Login.nip.ToString();
            dataGrid.DataSource = getDataDB.AbsenViewerDB(nip);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var rtunData =getDataDB.UpdateDataProfilDB(uidP, nama.Text, noHp.Text, email.Text, pass.Text, tanggal.Text, domisili.Text, "pegawai").ToString();
            MessageBox.Show(rtunData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nip = Login.nip.ToString();
            awal = dateAwal.Value.ToString("yyyy-MM-dd");
            akhir = dateAkhir.Value.ToString("yyyy-MM-dd");
            Rekap rekapAbsensi = new Rekap();
 
            rekapAbsensi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nip = Login.nip.ToString();
            MessageBox.Show(nip);
            Form10 ijin = new Form10();
            ijin.Show();
        }
    }
}
