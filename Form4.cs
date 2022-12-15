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
    public partial class TambahAbsen : Form
    {
        DBhelper absen = new DBhelper();
        public TambahAbsen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TambahAbsen_Load(object sender, EventArgs e)
        {
           var data = absen.AbsenViewerDetailDB(absensiAdmin.uid);
            label2.Text = data.Rows[0]["pegawai_nip"].ToString();
            textBox1.Text = data.Rows[0]["tanggal_absen"].ToString();
            textBox2.Text = data.Rows[0]["waktu_absen"].ToString();
            textBox3.Text = data.Rows[0]["waktu_pulang"].ToString();
            textBox4.Text = data.Rows[0]["status"].ToString();
            textBox5.Text = data.Rows[0]["img_ijin"].ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var returnValue= absen.UpdateAbsenAdminDB(label2.Text,absensiAdmin.uid,textBox1.Text,textBox2.Text,textBox3.Text).ToString();
            MessageBox.Show(returnValue);
        }
    }
}
