using Npgsql;
using NpgsqlTypes;
using System;
using BengkelinAja___Final_Project.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winform_mvc.App.Core;
using static BengkelinAja___Final_Project.View.Login;
using static BengkelinAja___Final_Project.View.Riwayat_Pemesanan;
using winform_mvc.App.Core; // Menggunakan DatabaseWrapper

namespace BengkelinAja___Final_Project.Context
{
    internal class PelangganContext : DatabaseWrapper
    {
        public static bool LoginPelanggan(string username, string password)
        {
            try
            {
                string loginQuery = "SELECT COUNT(*) FROM pelanggan WHERE username_pelanggan = @username AND password_pelanggan = @password";
                NpgsqlParameter[] loginParams = {
                    new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = username},
                    new NpgsqlParameter("@password", NpgsqlDbType.Varchar) { Value = password}
                };

                DataTable result = queryExecutor(loginQuery, loginParams);
                return Convert.ToInt32(result.Rows[0][0]) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error during login: " + ex.Message);
            }
        }
        private static string table = "pelanggan";
        public static bool RegisterPelanggan(M_Pelanggan.dataAkun pelangganBaru)
        {
            try
            {
                string query = $"INSERT INTO {table} (nama_pelanggan, username_pelanggan, password_pelanggan, email_pelanggan, no_telp, alamat_pelanggan) VALUES(@namaLengkap, @username, @password, @email, @noTelp, @alamat)";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@namaLengkap", NpgsqlDbType.Varchar) { Value = pelangganBaru.nama_pelanggan },
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = pelangganBaru.username_pelanggan },
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar) { Value = pelangganBaru.password_pelanggan },
                new NpgsqlParameter("@email", NpgsqlDbType.Varchar) { Value = pelangganBaru.email_pelanggan },
                new NpgsqlParameter("@noTelp", NpgsqlDbType.Varchar) { Value = pelangganBaru.no_telp },
                new NpgsqlParameter("@alamat", NpgsqlDbType.Varchar) { Value = pelangganBaru.alamat_pelanggan }
            };
                commandExecutor(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saat mendaftar: " + ex.Message);
                return false;
            }
        }

        public static DataTable GetBengkel(int id_layanan)
        {
            try
            {
                string query = "SELECT b. id_bengkel, b.nama_bengkel, b.alamat_bengkel, b.no_telp FROM bengkel b JOIN detail_layanan_bengkel dl ON b.id_bengkel = dl.id_bengkel WHERE dl.id_layanan = @id_layanan";
                NpgsqlParameter[] parameters = {
            new NpgsqlParameter("@id_layanan", NpgsqlDbType.Integer) { Value = id_layanan }
            };

                return queryExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Failed to load data for the current bengkel.");
            }
        }
        public static bool InsertTransaksiAntarJemput(M_Pelanggan.Transaksi TransaksiBaru)
        {
            try
            {
                string query = $"INSERT INTO transaksi (waktu_transaksi, waktu_servis, is_antar_jemput, waktu_jemput, alamat_penjemputan, id_kendaraan, id_layanan) VALUES(@waktu_transaksi, @waktu_servis, @is_antar_jemput, @waktu_jemput, @alamat_penjemputan, @id_kendaraan, @id_layanan)";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@waktu_transaksi", NpgsqlDbType.Timestamp) { Value = TransaksiBaru.waktu_transaksi},
                new NpgsqlParameter("@waktu_servis", NpgsqlDbType.Timestamp) { Value = TransaksiBaru.waktu_servis},
                new NpgsqlParameter("@is_antar_jemput", NpgsqlDbType.Boolean) { Value = TransaksiBaru.is_antar_jemput },
                new NpgsqlParameter("@waktu_jemput", NpgsqlDbType.Time) { Value = TransaksiBaru.waktu_jemput },
                new NpgsqlParameter("@alamat_penjemputan", NpgsqlDbType.Varchar) { Value = TransaksiBaru.alamat_penjemputan },
                new NpgsqlParameter("@id_kendaraan", NpgsqlDbType.Integer) { Value = TransaksiBaru.id_kendaraan },
                new NpgsqlParameter("@id_layanan", NpgsqlDbType.Integer) { Value = TransaksiBaru.id_layanan }
            };
                commandExecutor(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saat melakukan transaksi: " + ex.Message);
                return false;
            }
        }

        public static bool InsertTransaksiNonAntarJemput(M_Pelanggan.Transaksi TransaksiBaru)
        {
            try
            {
                string query = $"INSERT INTO transaksi (waktu_transaksi, waktu_servis, is_antar_jemput, id_kendaraan, id_layanan) VALUES(@waktu_transaksi, @waktu_servis, @is_antar_jemput, @id_kendaraan, @id_layanan)";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@waktu_transaksi", NpgsqlDbType.Timestamp) { Value = TransaksiBaru.waktu_transaksi},
                new NpgsqlParameter("@waktu_servis", NpgsqlDbType.Timestamp) { Value = TransaksiBaru.waktu_servis},
                new NpgsqlParameter("@is_antar_jemput", NpgsqlDbType.Boolean) { Value = TransaksiBaru.is_antar_jemput },
                new NpgsqlParameter("@id_kendaraan", NpgsqlDbType.Integer) { Value = TransaksiBaru.id_kendaraan },
                new NpgsqlParameter("@id_layanan", NpgsqlDbType.Integer) { Value = TransaksiBaru.id_layanan }
            };
                commandExecutor(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat melakukan transaksi: " + ex.Message);
                return false;
            }
        }

        public static int LoginPelangganGetId(string username, string password)
        {
            string loginQuery = "SELECT id_pelanggan FROM pelanggan WHERE username_pelanggan = @username AND password_pelanggan = @password;";
            NpgsqlParameter[] loginParams = {
            new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = username },
            new NpgsqlParameter("@password", NpgsqlDbType.Varchar) { Value = password }

            };

            DataTable result = queryExecutor(loginQuery, loginParams);

            if (result.Rows.Count > 0)
            {
                LoginSession.PelangganId = Convert.ToInt32(result.Rows[0]["id_pelanggan"]);
                return LoginSession.PelangganId;
            }
            else
            {
                MessageBox.Show("Tidak ada data yang cocok dengan username dan password.");
                return 0;
            }

            throw new Exception("Username atau password salah.");
        }

        public static DataTable RiwayatPemesanan(int id_pelanggan)
        {
            try
            {
                string query = "SELECT t.waktu_transaksi, t.waktu_servis, l.nama_layanan, t.waktu_jemput, t.alamat_penjemputan, k.jenis_kendaraan FROM detail_transaksi dt JOIN transaksi t ON dt.id_transaksi = t.id_transaksi JOIN layanan l ON t.id_layanan = l.id_layanan JOIN jenis_kendaraan k ON t.id_kendaraan = k.id_kendaraan WHERE dt.id_pelanggan = @id_pelanggan order by t.waktu_transaksi desc;";
                NpgsqlParameter[] parameters =
                { new NpgsqlParameter("@id_pelanggan", NpgsqlDbType.Integer) { Value = id_pelanggan}};
                return queryExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Failed to load data for the current pelanggan.");
            }
        }

        public static int getLastTransaksiId()
        {
            try
            {
                string query = "SELECT id_transaksi FROM transaksi ORDER BY id_transaksi DESC LIMIT 1;";
                NpgsqlParameter[] parameters =
                { new NpgsqlParameter("@id_pelanggan", NpgsqlDbType.Varchar) { Value = "Haloo"}};
                return queryExecutorInt(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Failed to load data for the current pelanggan.");
            }
        }

        public static bool InsertDetailTransaksi(M_Pelanggan.detail_transaksi TransaksiBaru)
        {
            try
            {
                string query = $"insert into detail_transaksi (id_bengkel, id_pelanggan, id_transaksi) values (@id_bengkel, @id_pelanggan, @id_transaksi)";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = TransaksiBaru.id_bengkel},
                new NpgsqlParameter("@id_pelanggan", NpgsqlDbType.Integer) { Value = TransaksiBaru.id_pelanggan},
                new NpgsqlParameter("@id_transaksi", NpgsqlDbType.Integer) { Value = TransaksiBaru.id_transaksi }
            };
                commandExecutor(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saat melakukan transaksi: " + ex.Message);
                return false;
            }
        }

        //public static int LoginPelangganGetId(string username, string password)
        //{
        //    // Kode untuk mengambil ID pelanggan dari database berdasarkan username dan password
        //    // Misalnya menggunakan query SQL berikut:
        //    // "SELECT id_pelanggan FROM pelanggan WHERE username = @username AND password = @password"
        //    // Pastikan Anda mengganti kode ini dengan koneksi database yang valid
        //}

        // Fungsi untuk mendapatkan jadwal servis berdasarkan ID pelanggan
        public static DataTable GetJadwalServis(int id_bengkel)
        {
            try
            {
                string query = @"
            SELECT
                t.waktu_transaksi,
                t.waktu_servis, 
                l.nama_layanan,
                p.nama_pelanggan,
                p.no_telp,
                t.alamat_penjemputan 
            FROM 
                transaksi t 
            JOIN 
                detail_transaksi dt ON t.id_transaksi = dt.id_transaksi 
            JOIN 
                bengkel b ON dt.id_bengkel = b.id_bengkel 
            JOIN 
                layanan l ON t.id_layanan = l.id_layanan 
            JOIN 
                pelanggan p on dt.id_pelanggan = p.id_pelanggan
            WHERE 
                b.id_bengkel = @id_bengkel 
            ORDER BY 
                t.waktu_servis ASC;";
                NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = id_bengkel }
            };

                return queryExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Failed to load data for the current bengkel.");
            }
        }
        public static DataTable GetLayananAntarJemput(int id_bengkel)
        {
            try
            {
                string query = "SELECT p.nama_pelanggan, p.no_telp,t.alamat_penjemputan,t.waktu_jemput FROM transaksi t JOIN detail_transaksi dt ON t.id_transaksi = dt.id_transaksi JOIN pelanggan p ON dt.id_pelanggan = p.id_pelanggan WHERE t.is_antar_jemput = true AND dt.id_bengkel = @id_bengkel";
                NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = id_bengkel }
            };

                return queryExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Failed to load data for the current bengkel.");
            }
        }
    }
}
