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
    public partial class Form10 : Form
    {
        DBhelper database = new DBhelper();
        private static string nip = BerandaPegawai.nip.ToString();
        public Form10()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tanggal = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var returndata = database.InsertIjinDB(nip, tanggal, textBox4.Text, textBox5.Text);
            
        }
    }
}
