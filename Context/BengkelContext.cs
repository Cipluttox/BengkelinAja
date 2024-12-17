using BengkelinAja___Final_Project.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Windows.Forms;
using winform_mvc.App.Core;
using static BengkelinAja___Final_Project.View.Login;

namespace BengkelinAja___Final_Project.Context
{
    public interface IBengkelContext
    {
        bool LoginBengkel(string username, string password);
        void RegisterPengelola(M_Bengkel.DataBengkel pengelolaBaru);
        int LoginBengkelGetId(string username, string password);
        void TambahLayananBengkel(int id_bengkel, int id_layanan);
        void TambahKendaraan(int id_bengkel, int id_kendaraan);
        DataTable GetBengkelWithLayanan(int bengkelId);
        DataTable GetBengkelByPengelola(int bengkelId);
        bool UpdateDataBengkel(int id_bengkel, string namaBengkel, string alamat, string jamBuka, string jamTutup);
        DataTable GetAllBengkel();
        DataTable GetDataLayanan(int id_bengkel);
        DataTable GetDataKendaraan(int id_bengkel);
        void Deletedetail(int id_bengkel);
    }

    internal class BengkelContext : DatabaseWrapper, IBengkelContext
    {
        public bool LoginBengkel(string username, string password)
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
                Console.WriteLine("Error during login: " + ex.ToString());
                throw new Exception("Error during login: " + ex.Message);
            }
        }

        public void RegisterPengelola(M_Bengkel.DataBengkel pengelolaBaru)
        {
            try
            {
                string query = @"
                    INSERT INTO bengkel 
                    (nama_bengkel, nama_pemilik, alamat_pemilik, username, password, email, no_telp, alamat_bengkel, jam_buka, jam_tutup) 
                    VALUES(@namaBengkel, @namaPemilik, @alamatPemilik, @username, @password, @email, @noTelp, @alamatBengkel, @jamBuka, @jamTutup)";
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
                Console.WriteLine("Error saat mendaftar: ");
            }
        }

        public int LoginBengkelGetId(string username, string password)
        {
            string loginQuery = "SELECT id_bengkel FROM bengkel WHERE username = @username AND password = @password";
            NpgsqlParameter[] loginParams = {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = username },
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar) { Value = password }
            };

            DataTable result = queryExecutor(loginQuery, loginParams);

            if (result.Rows.Count > 0)
            {
                LoginSession.BengkelId = Convert.ToInt32(result.Rows[0]["id_bengkel"]);
                return LoginSession.BengkelId;
            }

            throw new Exception("Username atau password salah.");
        }

        public void TambahLayananBengkel(int id_bengkel, int id_layanan)
        {
            try
            {
                string query = @"
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
                Console.WriteLine("Error when insert layanan detected");
            }
        }

        public void TambahKendaraan(int id_bengkel, int id_kendaraan)
        {
            try
            {
                string query = @"
                                 INSERT INTO detail_kendaraan (id_bengkel, id_kendaraan) 
                                 VALUES (@id_bengkel, @id_kendaraan)";
                NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = id_bengkel},
                    new NpgsqlParameter("@id_kendaraan", NpgsqlDbType.Integer) { Value = id_kendaraan}
                };
                commandExecutor(query, parameters);
            }
            catch
            {
                Console.WriteLine("Error when insert kendaraan detected");
            }
        }

        public DataTable GetBengkelWithLayanan(int bengkelId)
        {
            try
            {
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

        public DataTable GetBengkelByPengelola(int bengkelId)
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

        public bool UpdateDataBengkel(int id_bengkel, string namaBengkel, string alamat, string jamBuka, string jamTutup)
        {
            try
            {
                string query = "UPDATE bengkel SET " +
                               "nama_bengkel = @namaBengkel, " +
                               "alamat_bengkel = @alamat, " +
                               "jam_buka = @jamBuka, " +
                               "jam_tutup = @jamTutup " +
                               "WHERE id_bengkel = @id_bengkel";

                NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = id_bengkel},
                    new NpgsqlParameter("@namaBengkel", NpgsqlDbType.Varchar) { Value = namaBengkel },
                    new NpgsqlParameter("@alamat", NpgsqlDbType.Varchar) { Value = alamat },
                    new NpgsqlParameter("@jamBuka", NpgsqlDbType.Time) { Value = TimeSpan.Parse(jamBuka) },
                    new NpgsqlParameter("@jamTutup", NpgsqlDbType.Time) { Value = TimeSpan.Parse(jamTutup) }
                };
                commandExecutor(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saat mengupdate data bengkel: {ex.Message}");
                return false;
            }
        }

        public DataTable GetAllBengkel()
        {
            try
            {
                string query = "SELECT id_bengkel, nama_bengkel, nama_pemilik, alamat_bengkel, no_telp, email, jam_buka, jam_tutup FROM bengkel";
                return queryExecutor(query);
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal mengambil data: " + e.Message);
                return null;
            }
        }

        public DataTable GetDataLayanan(int id_bengkel)
        {
            try
            {
                string query = @"SELECT l.nama_layanan
                         FROM detail_layanan_bengkel dl
                         JOIN layanan l ON dl.id_layanan = l.id_layanan
                         WHERE dl.id_bengkel = @id_bengkel";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = id_bengkel }
                };
                return queryExecutor(query, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal mengambil data layanan: " + e.Message);
                return null;
            }
        }

        public DataTable GetDataKendaraan(int id_bengkel)
        {
            try
            {
                string query = @"SELECT k.jenis_kendaraan
                         FROM detail_kendaraan db
                         JOIN jenis_kendaraan k ON db.id_kendaraan = k.id_kendaraan
                         WHERE db.id_bengkel = @id_bengkel";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = id_bengkel }
                };

                return queryExecutor(query, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal mengambil data kendaraan: " + e.Message);
                return null;
            }
        }

        public void Deletedetail(int id_bengkel)
        {
            try
            {
                string query = @"DELETE FROM detail_layanan_bengkel WHERE id_bengkel = @id_bengkel; 
                                    DELETE FROM detail_kendaraan WHERE id_bengkel = @id_bengkel";
                NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("@id_bengkel", NpgsqlDbType.Integer) { Value = id_bengkel}
                };
                commandExecutor(query, parameters);
            }
            catch
            {
                Console.WriteLine("Error when deleting details detected");
            }
        }
    }
}
