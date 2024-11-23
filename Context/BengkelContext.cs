using BengkelinAja.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static bool RegisterPengelola(M_Bengkel.DataBengkel pengelolaBaru)
        {
            try
            {
                string query = $"INSERT INTO {table} (nama_bengkel, nama_pemilik, alamat_pemilik, username, password, email, alamat_bengkel, jam_buka, jam_tutup) VALUES(@namaBengkel, @namaPemilik, @alamatPemilik, @username, @password, @email, @noTelp, @alamatBengkel, @jamBuka, @jamTutup)";
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
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saat mendaftar: " + ex.Message);
                return false;
            }
        }
    }
}
