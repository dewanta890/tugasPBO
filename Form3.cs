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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBhelper DBinsert = new DBhelper();
            string theDate = tanggal.Value.ToString("yyyy-MM-dd");
            var databaseInsert= DBinsert.InsertDB(NIP.Text, namaPegawai.Text, noHP.Text, email.Text, pass.Text, theDate, domisili.Text);
            
            MessageBox.Show(theDate);

            if(databaseInsert=="true")
            {
                MessageBox.Show("Berhasil");
            }
            else
            {
                MessageBox.Show(databaseInsert);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
