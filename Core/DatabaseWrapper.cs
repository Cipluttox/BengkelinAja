using Npgsql;
using System;
using System.Data;

namespace winform_mvc.App.Core
{
    internal class DatabaseWrapper
    {
        // Properti credential database dan koneksinya
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "BengkelinAja";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "12345";
        private static readonly string DB_PORT = "5432";

        // Menggabungkan kredensial di dalam satu connection string
        private static readonly string connectionString = $"Host={DB_HOST};Port={DB_PORT};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_DATABASE}";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        // Method open dan close Koneksi
        public static void openConnection()
        {
            connection = new NpgsqlConnection(connectionString); // Gunakan connectionString
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;
        }

        public static void closeConnection()
        {
            connection.Close();
            command.Parameters.Clear();
        }

        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();  // Membuka koneksi
                DataTable dataTable = new DataTable();
                command.CommandText = query;  // Menetapkan query pada command
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);  // Menambahkan parameter ke command
                    command.Prepare();  // Menyiapkan query
                }
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dataTable);  // Mengisi DataTable dengan hasil query
                closeConnection();  // Menutup koneksi setelah selesai
                return dataTable;
            }
            catch (Exception e)
            {
                // Menangani exception dan melempar ulang exception jika terjadi error
                throw new Exception("Error saat mengeksekusi query: " + e.Message);
            }
        }

        // Metode untuk menjalankan query INSERT, UPDATE, DELETE
        public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();  // Membuka koneksi
                command.CommandText = query;  // Menetapkan query pada command
                command.Parameters.AddRange(parameters);  // Menambahkan parameter ke command
                command.Prepare();  // Menyiapkan query
                command.ExecuteNonQuery();  // Mengeksekusi query tanpa hasil (untuk INSERT, UPDATE, DELETE)
                closeConnection();  // Menutup koneksi setelah selesai
            }
            catch (Exception e)
            {
                // Menangani exception dan melempar ulang exception jika terjadi error
                MessageBox.Show(e.Message);
                throw new Exception(e.Message);
            }
        }

        private static string connString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=BengkelinAja";

        public static bool UpdateBengkelData(string namaBengkel, string namaLayanan, string alamat, string jamBuka, string jamTutup)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"UPDATE m_bengkel SET 
                                    nama_bengkel = @namaBengkel, 
                                    nama_layanan = @namaLayanan, 
                                    alamat = @alamat, 
                                    jam_buka = @jamBuka, 
                                    jam_tutup = @jamTutup 
                                    WHERE id_bengkel = @idBengkel"; // Sesuaikan WHERE clause sesuai kebutuhan

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@namaBengkel", namaBengkel);
                        cmd.Parameters.AddWithValue("@namaLayanan", namaLayanan);
                        cmd.Parameters.AddWithValue("@alamat", alamat);
                        cmd.Parameters.AddWithValue("@jamBuka", jamBuka);
                        cmd.Parameters.AddWithValue("@jamTutup", jamTutup);
                        cmd.Parameters.AddWithValue("@idBengkel", 1); // Sesuaikan ID yang ingin diupdate

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating data: {ex.Message}");
                return false;
            }
        }
    }
}
