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
using static BengkelinAja.View.Login;

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

        public static void RegisterPengelola(M_Bengkel.DataBengkel pengelolaBaru)
        {
            try
            {
                string query = $@"
                    INSERT INTO bengkel 
                    (nama_bengkel, nama_pemilik, alamat_pemilik, username, password, email, no_telp, alamat_bengkel, jam_buka, jam_tutup) 
                    VALUES(@namaBengkel, @namaPemilik, @alamatPemilik, @username, @password, @email, @noTelp, @alamatBengkel, @jamBuka, @jamTutup)";
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
                new NpgsqlParameter("@jamTutup", NpgsqlDbType.Time) { Value = pengelolaBaru.jam_tutup}
            };
                commandExecutor(query, parameters);
            }
            catch
            {
                MessageBox.Show("Error saat mendaftar: ");
            }
        }

        public static int LoginBengkelGetId(string username, string password)
        {
            string loginQuery = "SELECT id_bengkel FROM bengkel WHERE username = @username AND password = @password";
            NpgsqlParameter[] loginParams = {
            new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = username },
            new NpgsqlParameter("@password", NpgsqlDbType.Varchar) { Value = password }
            
            };

            DataTable result = queryExecutor(loginQuery, loginParams);

            if (result.Rows.Count > 0)
            {
                LoginSession.BengkelId = Convert.ToInt32(result.Rows[0]["id_bengkel"]); // Simpan id_bengkel
                return LoginSession.BengkelId;
            }

            throw new Exception("Username atau password salah.");
        }


        public static void TambahLayananBengkel(int id_bengkel, int id_layanan)
        {
            try
            {
                string query = $@"
                                 INSERT INTO detail_layanan_bengkel (id_bengkel, id_layanan) 
                                 VALUES (@id_bengkel, @id_layanan)";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = id_bengkel},
                new NpgsqlParameter("@id_layanan", NpgsqlDbType.Integer) { Value = id_layanan}
                
            };
                commandExecutor(query, parameters);
            }
            catch
            {
                MessageBox.Show("Error when insert layanan detected");
            }
        }

        public static DataTable GetBengkelWithLayanan(int bengkelId)
        {
            try
            {
                // Query untuk mengambil data bengkel beserta layanan
                string query = @"
                    SELECT b.id_bengkel, b.nama_bengkel, b.nama_pemilik, b.alamat_bengkel, b.no_telp, b.email, b.jam_buka, b.jam_tutup,
                        string_agg(l.nama_layanan, ', ') AS layanan
                    FROM bengkel b
                    LEFT JOIN detail_layanan_bengkel dlb ON b.id_bengkel = dlb.id_bengkel
                    LEFT JOIN layanan l ON dlb.id_layanan = l.id_layanan
                    WHERE b.id_bengkel = @id_bengkel
                    GROUP BY b.id_bengkel, b.nama_bengkel, b.nama_pemilik, b.alamat_bengkel, b.no_telp, b.email, b.jam_buka, b.jam_tutup";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = bengkelId }
            };

                return queryExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Failed to load data for the current bengkel.");
            }
        }


        public static DataTable GetBengkelByPengelola(int bengkelId)
        {
            try
            {
                string query = "SELECT * FROM bengkel WHERE id_bengkel = @id_bengkel";
                NpgsqlParameter[] parameters = {
            new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = bengkelId }
        };

                return queryExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Failed to load data for the current bengkel.");
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
                                   "alamat_bengkel = @alamat, " +
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
                string query = $"SELECT id_bengkel, nama_bengkel, nama_pemilik, alamat_bengkel, no_telp, email, jam_buka, jam_tutup FROM bengkel";
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
