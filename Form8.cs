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
    public partial class editProfil : Form
    {
        DBhelper akunConfig = new DBhelper();
        public editProfil()
        {
            InitializeComponent();
            textBox1.Text = Beranda.nama;
            textBox2.Text = Beranda.noHp;
            textBox3.Text = Beranda.email;
            textBox5.Text = Beranda.jabatan;
            textBox6.Text = Beranda.pass;
            richTextBox1.Text = Beranda.domisili;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            string valueDb = akunConfig.UpdateDataProfilDB(Beranda.uid,textBox1.Text,textBox2.Text,textBox3.Text,textBox6.Text,Beranda.tanggal,richTextBox1.Text,textBox5.Text).ToString();

            MessageBox.Show(valueDb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueDb = akunConfig.HapusAkunDB(Beranda.nip);
            MessageBox.Show(valueDb);
        }

        private void editProfil_Load(object sender, EventArgs e)
        {

        }
    }
}
