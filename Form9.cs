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
    public partial class absensiAdmin : Form
    {
        public DataGridViewButtonColumn detailButton = new DataGridViewButtonColumn();
        DBhelper getDataDB = new DBhelper();
        public static string nip = "";
        public static string uid = "";
        public static string uidP = "";
        public static string awal = "";
        public static string akhir = "";

        public absensiAdmin()
        {
            InitializeComponent();
        }

        private void absensiAdmin_Load(object sender, EventArgs e)
        {
            nip = Beranda.nip.ToString();
            dataGrid.DataSource = getDataDB.AbsenViewerDB(nip);
            detailButton.UseColumnTextForButtonValue = true;
            detailButton.Name = "detail_colom";
            detailButton.HeaderText = "Detail";
            detailButton.Text = "Detail";

            if (dataGrid.Columns["detail_colom"] == null)
            {
                dataGrid.Columns.Insert(dataGrid.ColumnCount, detailButton);
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Columns[e.ColumnIndex].Name == "detail_colom")
            {
                uid = dataGrid.Rows[e.RowIndex].Cells["uid"].Value.ToString();
                TambahAbsen tambahAbsensi = new TambahAbsen();
                tambahAbsensi.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            awal = dateAwal.Value.ToString("yyyy-MM-dd");
            akhir = dateAkhir.Value.ToString("yyyy-MM-dd");
            Rekap rekapAbsensi = new Rekap();
            rekapAbsensi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = getDataDB.AbsenViewerDB(nip);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            getDataDB.TambahAbsenDB(nip);
        }
    }
}
