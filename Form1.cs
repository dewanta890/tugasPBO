namespace AplikasiPBO
{
    public partial class Login : Form
    {
        
        public static string nip = "";
        public static string jabatan = "";
        public static string pegawai = "";
        public Login()
        {
            InitializeComponent();
            DBhelper start = new DBhelper();
            start.StartingAdmin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBhelper login = new DBhelper();

            var dataLogin = login.LoginDB(username.Text, password.Text);

            

            if (dataLogin.Rows.Count != 0)
            {
                pegawai = dataLogin.Rows[0]["nama_pegawai"].ToString();

                if (dataLogin.Rows[0]["jabatan"].ToString() != "")
                {
                    jabatan = dataLogin.Rows[0]["jabatan"].ToString();

                    if (username.Text == dataLogin.Rows[0]["nip"].ToString() && password.Text == dataLogin.Rows[0]["pass"].ToString() && dataLogin.Rows[0]["jabatan"].ToString() == "pegawai")
                    {
                        absensiAdmin.nip = "";
                        BerandaPegawai.nip = "";
                        nip = username.Text;
                        BerandaPegawai Beranda = new BerandaPegawai();
                        Beranda.Tag = this;
                        Beranda.Show(this);
                        Hide();
                    }

                    else if (username.Text == dataLogin.Rows[0]["nip"].ToString() && password.Text == dataLogin.Rows[0]["pass"].ToString() && dataLogin.Rows[0]["jabatan"].ToString() == "admin")
                    {
                        absensiAdmin.nip = "";
                        BerandaPegawai.nip = "";
                        nip = username.Text;
                        Beranda Beranda = new Beranda();
                        Beranda.Tag = this;
                        Beranda.Show(this);
                        Hide();
                    }

                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Maaf Akun Anda Belum di Verifikasi oleh Admin!");
                }
            }
            else
            {
                MessageBox.Show("Maaf NIP atau Password Anda Salah!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register Register = new Register();
            Register.Show();
        }
    }
}