using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web;
using System.Data;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AplikasiPBO
{
    class DBhelper
    {
        private NpgsqlConnection connect = new NpgsqlConnection();

        public void ConfigDB()
        {
            connect.ConnectionString = "Host=localhost; Username=postgres; Password=root; Database=DataSekolah; CommandTimeout=10";
        }

        public void StartingAdmin()
        {
            ConfigDB();
           
            try
            {
                connect.Open();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = connect;
                string querySql = "INSERT INTO pegawai( nip, nama_pegawai, tanggal_lahir, no_handphone, email, pass, domisili, jabatan, uid_pegawai) VALUES('0000', 'admin', CURRENT_DATE, '0000', 'email', '0000', '0000', 'admin', default) ON CONFLICT DO NOTHING; ";
                query.CommandText = querySql;
                query.CommandType = CommandType.Text;
                query.Dispose();
                connect.Close();
            }
            catch (Exception ex)
            {

            }
            
        }
        public DataTable LoginDB( string nip, string pass)
        {
            ConfigDB();
            DataTable dataread = new DataTable();
            try
            {
                connect.Open();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = connect;
                string querySql = "SELECT nip,pass,jabatan,nama_pegawai FROM pegawai WHERE nip = "+nip+"";
                query.CommandText = querySql;
                query.CommandType = CommandType.Text;
                NpgsqlDataAdapter adapterdata = new NpgsqlDataAdapter(query);
                adapterdata.Fill(dataread);
                query.Dispose();
                connect.Close();
            }
            catch(Exception ex)
            {
                
            }
            return dataread;
        }

        public DataTable AbsenViewerDB(string nip)
        {
            ConfigDB();
            DataTable dataread = new DataTable();
            try
            {
                connect.Open();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = connect;
                string querySql = "SELECT uid, pegawai.nama_pegawai,pegawai.nip, tanggal_absen, waktu_absen, waktu_pulang FROM absensi INNER JOIN pegawai ON absensi.pegawai_nip = "+ nip +" WHERE pegawai.nip = "+ nip +" ;";
                query.CommandText = querySql;
                query.CommandType = CommandType.Text;
                NpgsqlDataAdapter adapterdata = new NpgsqlDataAdapter(query);
                adapterdata.Fill(dataread);
                query.Dispose();
                connect.Close();
            }
            catch
            {

            }
            return dataread;
        }

        public DataTable AbsenRekapDB(string nip, string tanggalAwal, string tanggalAkhir)
        {
            ConfigDB();
            DataTable dataread = new DataTable();
            try
            {
                connect.Open();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = connect;
                string querySql = "SELECT uid, pegawai.nama_pegawai,pegawai.nip, tanggal_absen, waktu_absen, waktu_pulang FROM absensi INNER JOIN pegawai ON absensi.pegawai_nip = " + nip + " WHERE pegawai.nip = " + nip + " AND '["+ tanggalAwal +", "+ tanggalAkhir +"]'::daterange @> tanggal_absen";
                query.CommandText = querySql;
                query.CommandType = CommandType.Text;
                NpgsqlDataAdapter adapterdata = new NpgsqlDataAdapter(query);
                adapterdata.Fill(dataread);
                query.Dispose();
                connect.Close();
            }
            catch
            {

            }
            return dataread;
        }

        public DataTable AbsenViewerDetailDB(string uid)
        {
            ConfigDB();
            DataTable dataread = new DataTable();
            try
            {
                connect.Open();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = connect;
                string querySql = "SELECT * FROM absensi WHERE uid = "+ uid +";";
                query.CommandText = querySql;
                query.CommandType = CommandType.Text;
                NpgsqlDataAdapter adapterdata = new NpgsqlDataAdapter(query);
                adapterdata.Fill(dataread);
                query.Dispose();
                connect.Close();
            }
            catch (Exception ex)
            {
            
            }
            return dataread;
        }

        public DataTable ReaderDB()
        {
             ConfigDB();
             DataTable dataread = new DataTable();

             try
             {
                 connect.Open();
                 NpgsqlCommand query = new NpgsqlCommand();
                 query.Connection = connect;
                 string querySql = "SELECT * FROM pegawai;";
                 query.CommandText = querySql;
                 query.CommandType = CommandType.Text;
                 NpgsqlDataAdapter adapterdata = new NpgsqlDataAdapter(query);
                 adapterdata.Fill(dataread);
                 query.Dispose();
                 connect.Close();

             }
             catch (Exception ex)
             {
             
             }
             return dataread;
        }

        public DataTable ReaderSingleDB(string nip)
        {
            ConfigDB();
            DataTable dataread = new DataTable();

            try
            {
                connect.Open();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = connect;
                string querySql = "SELECT * FROM pegawai WHERE nip = "+ nip +";";
                query.CommandText = querySql;
                query.CommandType = CommandType.Text;
                NpgsqlDataAdapter adapterdata = new NpgsqlDataAdapter(query);
                adapterdata.Fill(dataread);
                query.Dispose();
                connect.Close();

            }
            catch (Exception ex)
            {

            }
            return dataread;
        }

        public string InsertDB(string NIP, string nama, string noHP, string email, string pass, string date, string domisili)

        {
            ConfigDB();
            try
            {
                connect.Open();
                string querySql = "INSERT INTO pegawai ( nip, nama_pegawai, tanggal_lahir, no_handphone, email, pass, domisili, uid_pegawai ) VALUES ( '"+ NIP + "', @namaPegawai, '" + date +"', '"+ noHP +"', @email, @password, @domisili, default );";
                NpgsqlCommand query = new NpgsqlCommand(querySql, connect);
                query.Parameters.AddWithValue("namaPegawai", nama);
                query.Parameters.AddWithValue("email", email);
                query.Parameters.AddWithValue("password", pass);
                query.Parameters.AddWithValue("domisili", domisili);
                query.Prepare();
                query.ExecuteNonQuery();
                query.Dispose();
                connect.Close();
                return "true";
            }

            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        public string TambahAbsenDB(string nip)

        {
            ConfigDB();
            try
            {
                connect.Open();
                string querySql = "INSERT INTO absensi ( uid, pegawai_nip, tanggal_absen, waktu_absen) VALUES ( default, "+ nip +", CURRENT_DATE, LOCALTIMESTAMP);";
                NpgsqlCommand query = new NpgsqlCommand(querySql, connect);
                query.ExecuteNonQuery();
                query.Dispose();
                connect.Close();
                
            }

            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "Data Absen Telah diPerbaharui";
        }

        public string UpdateAbsenDB(string nip, string uid)

        {
            ConfigDB();
            try
            {
                connect.Open();
                string querySql = "UPDATE absensi SET waktu_pulang = LOCALTIMESTAMP WHERE uid = " +uid+ " AND pegawai_nip= " +nip+ ";";
                NpgsqlCommand query = new NpgsqlCommand(querySql, connect);
                query.ExecuteNonQuery();
                query.Dispose();
                connect.Close();

            }

            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "Absensi Telah di Update";
        }

        public string UpdateDataProfilDB(string uid, string nama, string noHp, string email, string pass, string tanggal, string domisili, string jabatan)
        {
            ConfigDB();
            try
            {
                connect.Open();
                string querySql = "UPDATE pegawai SET " +
                    "nama_pegawai ='"+nama+"',"+
                    "no_handphone ='"+noHp+"'," +
                    "email ='"+email+"'," +
                    "pass = '"+pass+"'," +
                    "tanggal_lahir = '"+tanggal+"'," +
                    "domisili = '"+domisili+"'," +
                    "jabatan = '"+jabatan+"' " +
                    "WHERE uid_pegawai = '"+uid+"'" +
                    ";";
                NpgsqlCommand query = new NpgsqlCommand(querySql, connect);
                query.ExecuteNonQuery();
                query.Dispose();
                connect.Close();

            }

            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "Berhasil Update";
        }

        public string HapusAkunDB(string uid)

        {
            ConfigDB();
            try
            {
                connect.Open();
                string querySql = "DELETE FROM pegawai WHERE uid_pegawai="+uid+" ;";
                NpgsqlCommand query = new NpgsqlCommand(querySql, connect);
                query.ExecuteNonQuery();
                query.Dispose();
                connect.Close();

            }

            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "Berhasil Terhapus";
        }
    }
}

