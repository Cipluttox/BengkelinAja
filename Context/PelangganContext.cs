using Npgsql;
using NpgsqlTypes;
using System;
using BengkelinAja.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winform_mvc.App.Core;

namespace BengkelinAja.Context
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
        public static bool RegisterPelanggan (M_Pelanggan.dataAkun pelangganBaru)
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

    }
}
