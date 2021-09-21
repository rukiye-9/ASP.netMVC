using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Cariler
    {
        [Key]
        public int CariID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string CariAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string CariSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string CariSehir { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string CariMail { get; set; }
        
        public bool Durum { get; set; }


        public string CariSifre { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        

        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}