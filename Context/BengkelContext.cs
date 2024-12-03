using BengkelinAja.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_mvc.App.Core;

namespace BengkelinAja.Context
{
    internal class BengkelContext : DatabaseWrapper
    {
        public static bool LoginBengkel(string username, string password)
        {
            try
            {
                string loginQuery = "SELECT COUNT(*) FROM bengkel WHERE username = @username AND password = @password";
                NpgsqlParameter[] loginParams = {
                    new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = username },
                    new NpgsqlParameter("@password", NpgsqlDbType.Varchar) { Value = password }
                };

                DataTable result = queryExecutor(loginQuery, loginParams);
                return Convert.ToInt32(result.Rows[0][0]) > 0;
            }
            catch (Exception ex)
            {
                // Tambahkan log untuk melihat detail error
                Console.WriteLine("Error during login: " + ex.ToString());
                throw new Exception("Error during login: " + ex.Message);
            }


        }

        private static string table = "bengkel";
        public static void RegisterPengelola(M_Bengkel.DataBengkel pengelolaBaru)
        {
            try
            {
                string query = $@"
                    INSERT INTO {table} 
                    (nama_bengkel, nama_pemilik, alamat_pemilik, username, password, email, no_telp, alamat_bengkel, jam_buka, jam_tutup, layanan) 
                    VALUES(@namaBengkel, @namaPemilik, @alamatPemilik, @username, @password, @email, @noTelp, @alamatBengkel, @jamBuka, @jamTutup, @layanan)";
                //string query = $"INSERT INTO {table} (nama_bengkel, nama_pemilik, alamat_pemilik, username, password, email, no_telp, alamat_bengkel, jam_buka, jam_tutup) VALUES(@namaBengkel, @namaPemilik, @alamatPemilik, @username, @password, @email, @noTelp, @alamatBengkel, @jamBuka, @jamTutup)";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@namaBengkel", NpgsqlDbType.Varchar) { Value = pengelolaBaru.nama_bengkel },
                new NpgsqlParameter("@namaPemilik", NpgsqlDbType.Varchar) { Value = pengelolaBaru.nama_pemilik},
                new NpgsqlParameter("@alamatPemilik", NpgsqlDbType.Varchar) { Value = pengelolaBaru.alamat_pemilik },
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = pengelolaBaru.username},
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar) { Value = pengelolaBaru.password},
                new NpgsqlParameter("@email", NpgsqlDbType.Varchar) { Value = pengelolaBaru.email },
                new NpgsqlParameter("@noTelp", NpgsqlDbType.Varchar) { Value = pengelolaBaru.no_telp},
                new NpgsqlParameter("@alamatBengkel", NpgsqlDbType.Varchar) { Value = pengelolaBaru.alamat_bengkel},
                new NpgsqlParameter("@jamBuka", NpgsqlDbType.Time) { Value = pengelolaBaru.jam_buka},
                new NpgsqlParameter("@jamTutup", NpgsqlDbType.Time) { Value = pengelolaBaru.jam_tutup},
                new NpgsqlParameter("@layanan", NpgsqlDbType.Text) { Value = pengelolaBaru.Layanans}
            };
                commandExecutor(query, parameters);
                //using (var command = new NpgsqlCommand(query))
                //{
                //    command.Parameters.AddRange(parameters);
                //    command.ExecuteNonQuery(); // Menjalankan query untuk insert data
                //}
            }
            catch
            {
                MessageBox.Show("Error saat mendaftar: ");
                
            }
        }

        



        public static class BengkelController
        {
            // Method untuk update atau menyimpan data bengkel ke database
            public static bool UpdateDataBengkel(
                string namaBengkel,
                bool servisRutin,
                bool gantiOli,
                bool servisGaransi,
                bool servisDarurat,
                string alamat,
                string jamBuka,
                string jamTutup)
            {
                try
                {
                    // Gabungkan layanan menjadi satu string (misalnya: "Servis Rutin, Ganti Oli")
                    List<string> layanan = new List<string>();
                    if (servisRutin) layanan.Add("Servis Rutin");
                    if (gantiOli) layanan.Add("Ganti Oli");
                    if (servisGaransi) layanan.Add("Servis Garansi");
                    if (servisDarurat) layanan.Add("Servis Darurat");

                    string layananStr = string.Join(", ", layanan);

                    // Query untuk update data di database
                    string query = $"UPDATE bengkel SET " +
                                   "layanan = @layanan, " +
                                   "alamat = @alamat, " +
                                   "jam_buka = @jamBuka, " +
                                   "jam_tutup = @jamTutup " +
                                   "WHERE nama_bengkel = @namaBengkel";

                    // Parameter query
                    NpgsqlParameter[] parameters =
                    {
            new NpgsqlParameter("@namaBengkel", NpgsqlDbType.Varchar) { Value = namaBengkel },
            new NpgsqlParameter("@layanan", NpgsqlDbType.Varchar) { Value = layananStr },
            new NpgsqlParameter("@alamat", NpgsqlDbType.Varchar) { Value = alamat },
            new NpgsqlParameter("@jamBuka", NpgsqlDbType.Time) { Value = TimeSpan.Parse(jamBuka) },
            new NpgsqlParameter("@jamTutup", NpgsqlDbType.Time) { Value = TimeSpan.Parse(jamTutup) }
        };

                    // Eksekusi query menggunakan fungsi commandExecutor
                    commandExecutor(query, parameters);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saat mengupdate data bengkel: {ex.Message}");
                    return false;
                }
            }
        }

        public static DataTable GetAllBengkel()
        {
            try
            {
                string query = $"SELECT id_bengkel, nama_bengkel, nama_pemilik, alamat_bengkel, no_telp, email, jam_buka, jam_tutup FROM {table}";
                return queryExecutor(query); // Menggunakan queryExecutor dari DatabaseWrapper
            }
            catch (Exception e)
            {
                MessageBox.Show("Gagal mengambil data: " + e.Message);
                return null;
            }
        }
    }
}
