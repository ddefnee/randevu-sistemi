using System;
using System.ComponentModel.DataAnnotations;

namespace Randevu_Sistemi.Models
{
    public class Randevu
    {
        public int Id { get; set; }

        [Required]
        public string AdSoyad { get; set; }

        [Required]
        public DateTime Tarih { get; set; }

        [Required]
        public string Aciklama { get; set; }
    }
}
