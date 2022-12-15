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
    public partial class detailAbsensi : Form
    {
        DBhelper getDataDB = new DBhelper();
        public detailAbsensi()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            getDataDB.UpdateAbsenDB(nip_title.Text, BerandaPegawai.uid);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            var dataAbsen=getDataDB.AbsenViewerDetailDB(BerandaPegawai.uid);
            nip_title.Text = dataAbsen.Rows[0]["pegawai_nip"].ToString();
            tanggalAbsen.Text = dataAbsen.Rows[0]["tanggal_absen"].ToString();
            absensi.Text = dataAbsen.Rows[0]["waktu_absen"].ToString();
            pulang.Text = dataAbsen.Rows[0]["waktu_pulang"].ToString();
            status.Text = dataAbsen.Rows[0]["status"].ToString();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
