using ProjectManagementApp.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagementApp.Models.Personel
{//Kod okunurluğu açısından çok kötü ve önerilmez. Tamamen deneme projesidir.
    public class PersonelBilgileri
    {
        public PersonelBilgileri()
        {
            this.PersonelProjeleris = new HashSet<PersonelProjeleri>();
        }
        [Key]
        public int PersonelBilgileriId { get; set; }
        [DisplayName("E-Posta")]
        public string Eposta { get; set; }
        [DisplayName("ŞİFRE")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karakterden fazla olamaz.")]
        public string Sifre { get; set; }
        [DisplayName("YETKİ")]
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karakterden fazla olamaz.")]
        public string Yetki { get; set; }
        [DisplayName("AD SOYAD")]
        [StringLength(50, ErrorMessage = "Maksimum uzunluk 50 karakterden fazla olamaz.")]
        public string AdSoyad { get; set; }
        [DisplayName("TC KİMLİK NO")]
        [StringLength(11, ErrorMessage = "Maksimum uzunluk 11 karakterden fazla olamaz.")]
        public string TCNo { get; set; }
        [DisplayName("DEPARTMANI")]
        public string Departman { get; set; }
        [DisplayName("GÖREVİ")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karakterden fazla olamaz.")]
        public string Gorev { get; set; }
        [DisplayName("AÇIKLAMA")]
        public string PozisyonAciklama { get; set; }
        [DisplayName("TELEFON NUMARASI")]
        public string TelNo { get; set; }
        [DisplayName("ADRES BİLGİLERİ")]
        public string Adres { get; set; }
        [DisplayName("MEDENİ HAL")]
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karakterden fazla olamaz.")]
        public string MedeniHal { get; set; }
        [DisplayName("YAKINLIK BİLGİSİ")]
        [StringLength(20, ErrorMessage = "Maksimum uzunluk 20 karakterden fazla olamaz.")]
        public string YakinBilgisi { get; set; }
        [DisplayName("YAKIN TC NO")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karakterden fazla olamaz.")]
        public string YakinTc { get; set; }
        [DisplayName("YAKIN AD SOYAD")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karakterden fazla olamaz.")]
        public string YakinAdSoyad { get; set; }
        [DisplayName("YAKIN TELEFONU")]
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karakterden fazla olamaz.")]
        public string YakinTel { get; set; }
        [DisplayName("DOĞUM TARİHİ")]
        public DateTime DogumTarihi { get; set; }
        [DisplayName("İŞE GİRİŞ TARİHİ")]
        public DateTime? IseGirisTarihi { get; set; }
        public virtual ICollection<PersonelProjeleri> PersonelProjeleris { get; set; }
    }
}