using ProjectManagementApp.Models.Personel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagementApp.Models.ProjeTakip
{
    public class PersonelProjeleri
    {
        public PersonelProjeleri()
        {
            this.PersonelBilgileris = new HashSet<PersonelBilgileri>();
        }
        [Key]
        public int PersonelProjeId { get; set; }
        [DisplayName("PROJE BAŞLIĞI")]
        [StringLength(150, ErrorMessage = "Maksimum uzunluk 150 karakterden fazla olamaz.")]
        public string ProjeBaslik { get; set; }
        public string ProjeAciklama { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        [DisplayName("ÖNCELİK DURUMU")]
        [StringLength(30, ErrorMessage = "Maksimum uzunluk 30 karakterden fazla olamaz.")]
        public string OncelikDurumu { get; set; }
        public int TamamlanmaOranı { get; set; }
        public DateTime? TamamlanmaTarihi { get; set; }
        public bool TamamlanmaDurumu { get; set; }
        public virtual ICollection<PersonelBilgileri> PersonelBilgileris { get; set; }
    }
}