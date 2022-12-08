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
    public partial class Rekap : Form
    {
        
        public Rekap()
        {
            InitializeComponent();
            DBhelper rekap = new DBhelper();
            
            if (absensiAdmin.nip != "")
            {
                dataGrid.DataSource = rekap.AbsenRekapDB(absensiAdmin.nip.ToString(), absensiAdmin.awal, absensiAdmin.akhir);
            }
            
            if(BerandaPegawai.nip != "")
            {
                dataGrid.DataSource = rekap.AbsenRekapDB(BerandaPegawai.nip.ToString(), BerandaPegawai.awal,BerandaPegawai.akhir);
            }
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
