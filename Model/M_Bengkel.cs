using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengkelinAja.Model
{
    public class M_Bengkel
    {
        public class DataBengkel
        {
            [Key]
            public int id_bengkel { get; set; }
            [Required]
            public string nama_bengkel { get; set; }
            [Required]
            public string nama_pemilik { get; set; }
            [Required]
            public string alamat_pemilik { get; set; }
            [Required]
            public string username { get; set; }
            [Required]
            public string password { get; set; }    
            [Required]
            public string email { get; set; }
            [Required]
            public string no_telp { get; set; }
            [Required]
            public string alamat_bengkel { get; set; }
            [Required]
            public TimeOnly jam_buka { get; set; }
            [Required]
            public TimeOnly jam_tutup {  get; set; }
        }
        public class metodePembayaran
        {
            [Key]
            public int id_metode { get; set; }
            [Required]
            public string metode_pembayaran { get; set; }
        }
        public class statusPembayaran
        {
            [Key]
            public int id_status { get; set; }
            [Required]
            public string status_pembayaran { get; set; }
        }
        public class jenisKendaraan
        {
            [Key]
            public int id_kendaraan { get; set; }
            [Required]
            public string jenis_kendaraan { get; set; }
        }
        public class layanan
        {
            [Key]
            public int id_layanan { get; set; }
            [Required]
            public string nama_layanan { get; set; }
        }
    } 
}
