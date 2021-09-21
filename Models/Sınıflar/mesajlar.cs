using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class mesajlar
    {
        [Key]
        public int MesajId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Gönderici { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Alıcı { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Konu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public string Icerik { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime Tarih { get; set; }
    }
}