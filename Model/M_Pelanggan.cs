using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengkelinAja___Final_Project.Model
{
    public abstract class M_Pelanggan
    {
        public abstract class dataAkun
        {
            [Key]
            public int id_pelanggan { get; set; }

            [Required]
            public string nama_pelanggan { get; set; }

            [Required]
            public string username_pelanggan { get; set; }

            [Required]
            public string password_pelanggan { get; set; }

            [Required]
            public string email_pelanggan { get; set; }

            [Required]
            public string no_telp { get; set; }

            [Required]
            public string alamat_pelanggan { get; set; }
        }

        public abstract class Transaksi
        {
            [Key]
            public int id_transaksi { get; set; }

            [Required]
            public DateTime waktu_transaksi { get; set; }

            [Required]
            public DateTime waktu_servis { get; set; }

            [Required]
            public bool is_antar_jemput { get; set; }

            public TimeOnly waktu_jemput { get; set; }

            public string alamat_penjemputan { get; set; }

            [Required]
            public int id_kendaraan { get; set; }

            [Required]
            public int id_layanan { get; set; }
        }

        public abstract class detail_transaksi
        {
            [Required]
            public int id_bengkel { get; set; }

            [Required]
            public int id_pelanggan { get; set; }

            [Required]
            public int id_transaksi { get; set; }
        }
        public class ConcreteDetailTransaksi : M_Pelanggan.detail_transaksi
        {
        }
        public class ConcreteDataAkun : M_Pelanggan.dataAkun
        {
        }
        public class ConcreteTransaksi : M_Pelanggan.Transaksi
        {
        }
    }
}
