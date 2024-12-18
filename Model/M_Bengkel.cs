using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengkelinAja___Final_Project.Model
{
    public abstract class M_Bengkel
    {
        public abstract class DataBengkel
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
            public TimeOnly jam_tutup { get; set; }

            public List<layanan> Layanans { get; set; }
        }

        public abstract class jenisKendaraan
        {
            [Key]
            public int id_kendaraan { get; set; }

            [Required]
            public string jenis_kendaraan { get; set; }
        }

        public abstract class layanan
        {
            [Key]
            public int id_layanan { get; set; }

            [Required]
            public string nama_layanan { get; set; } // Ganti dari List<string> ke string
        }
        public class ConcreteDataBengkel : M_Bengkel.DataBengkel
        {
        }
    }
}
