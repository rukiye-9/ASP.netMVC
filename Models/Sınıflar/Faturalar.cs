using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Faturalar
    {
        [Key]
        public int FaturaID { get; set; }
        [Column(TypeName = "char")]
        [StringLength(10)]
        
        public string FaturaSıraNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string FaturaSeriNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]

        public string VergiDairesi { get; set; }

        public string Saat { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]

        public string FaturaTarih { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]

        public string TeslimEden { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimAlan { get; set; }

        public decimal Toplam { get; set; }





        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}