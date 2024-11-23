using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengkelinAja.Model
{
    public class M_Pelanggan
    {
        public class dataAkun
        {
            [Key]
            public int id_pelanggan { get; set; }
            [Required]
            public string nama_pelanggan { get; set; }
            [Required]
            public string username_pelanggan { get; set; }
            [Required]
            public string password_pelanggan { get;set; }
            [Required]
            public string email_pelanggan { get; set; }
            [Required]
            public string no_telp {  get; set; }
            [Required]
            public string alamat_pelanggan { get; set; }
        }
        public class Transaksi
        {
            [Key]
            public int id_transaksi { get; set; }
            [Required]
            public DateTime waktu_transaksi { get; set; }
            [Required]
            public TimeOnly waktu_servis { get; set; }
            [Required]
            public bool is_antar_jemput { get; set; }
            [Required]
            public TimeOnly waktu_jemput { get; set; }
            [Required]
            public string alamat_penjemputan { get; set; }
            [Required]
            public int id_kendaraan { get; set; }
        } 
        
    }
}
