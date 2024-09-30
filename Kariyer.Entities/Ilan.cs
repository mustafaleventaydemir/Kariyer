using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Ilan : IEntity
    {
        public int Id { get; set; }
        [StringLength(40)]
        [Display(Name = "Pozisyon Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string PozisyonAdi { get; set; }
        [StringLength(500)]
        [Display(Name = "İş Tanımı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string IsTanimi { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Yetkinlikler { get; set; }
        [StringLength(400)]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Tercihen { get; set; }
        [StringLength(400)]
        [Display(Name = "Şirket İmkanları")]
        public string? SirketImkanlari { get; set; }
        [StringLength(10)]
        [Display(Name = "Posta Kodu")]
        public string PostaKodu { get; set; }
        [Display(Name = "İlan Tarihi")]
        public DateTime IlanTarihi { get; set; }
        [Display(Name = "Son Başvuru Tarihi")]
        public DateTime SonBasvuruTarihi { get; set; }
        public int IlanDurumId { get; set; }
        public virtual IlanDurumu? IlanDurumu { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<MulakatListe> MulakatListeleri { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<Basvuran> Basvuranlar { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<FavoriIlan> FavoriIlanlar { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<IlanKayit> IlanKayitlari { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<IsIlaniCalismaSekli> IsIlaniCalismaSekilleri { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<IsIlaniCinsiyet> IsIlaniCinsiyetleri { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<IsIlaniDeneyimSuresi> IsIlaniDeneyimSureleri { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<IsIlaniSehir> IsIlaniSehirler { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<IsIlaniSektor> IsIlaniSektorler { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<IsIlaniUlke> IsIlaniUlkeler { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<IsIlaniYabanciDil> IsIlaniYabanciDiller { get; set; }
        [ForeignKey("IlanId")]
        public ICollection<SirketIlan> SirketIlanlari { get; set; }
    }
}
