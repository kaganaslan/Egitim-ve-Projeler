using PROJETAKIP.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJETAKIP.Models.Personel
{
    public class PersonelBilgileri
    {
        public PersonelBilgileri()
        {
            this.PersonelProjeleris = new HashSet<PersonelProjeleri>();
        }
        [Key]
        public int PersonelBilgileriId { get; set; }
        [DisplayName("E-POSTA")]
        public string EPosta { get; set; }
        [DisplayName("Sifre")]
        [StringLength(32, ErrorMessage = "Maximum 32 karakter")]
        public string Sifre { get; set; }
        [DisplayName("Yetki")]
        [StringLength(15, ErrorMessage = "Maximum 15 karakter")]
        public string Yetki { get; set; }
        [DisplayName("Ad Soyad")]
        [StringLength(80, ErrorMessage = "Maximum 80 karakter")]
        public string AdSoyad { get; set; }
        [DisplayName("TC")]
        [StringLength(11, ErrorMessage = "Maximum 11 karakter")]
        public string TCNO { get; set; }
        [DisplayName("Personel Görseli")]
        public string PersonelGorseli { get; set; }
       
        [DisplayName("Departman")]
        [StringLength(50, ErrorMessage = "Maximum 50 karakter")]
        public string Departman { get; set; }
        [DisplayName("Gorev")]
        [StringLength(32, ErrorMessage = "Maximum 32 karakter")]
        public string Gorev { get; set; }
        [DisplayName("Açıklama")]
        public string PozisyonAciklama { get; set; }
        [DisplayName("Telefon")]
        [StringLength(25, ErrorMessage = "Maximum 25 karakter")]
        public string TelNO { get; set; }
        [DisplayName("Adres")]
        [StringLength(32, ErrorMessage = "Maximum 32 karakter")]
        public string Adres { get; set; }
        [DisplayName("MedeniHal")]
        [StringLength(32, ErrorMessage = "Maximum 32 karakter")]
        public string MedeniHal { get; set; }
        [DisplayName("Yakın Bilgisi")]
        [StringLength(32, ErrorMessage = "Maximum 32 karakter")]
        public string YakınBilgisi { get; set; }
        [DisplayName("Yakın TC")]
        [StringLength(32, ErrorMessage = "Maximum 32 karakter")]
        public string YakınTC { get; set; }
        [DisplayName("Yakın Ad Soyad")]
        [StringLength(32, ErrorMessage = "Maximum 32 karakter")]
        public string YakınAdSoyad { get; set; }
        public string YakınTel { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime? IseGirisTarihi { get; set; }
        public virtual ICollection<PersonelProjeleri> PersonelProjeleris { get; set; }
    }
}