using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Uyelik : IEntity
    {
        public int Id { get; set; }
        [StringLength(40)]
        [Display(Name = "Ad"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [StringLength(40)]
        [Display(Name = "Soyad"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Soyadi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? KullaniciAdi { get; set; }
        [StringLength(40)]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email { get; set; }
        [StringLength(40)]
        [Display(Name = "Şifre"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Sifre { get; set; }
        [Display(Name = "Kullanıcı Rolü"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int RolId { get; set; }
        //public virtual Rol? Rol { get; set; }

        public Guid? UserGuid { get; set; } = Guid.NewGuid();
        [ForeignKey("UyelikId")]
        public ICollection<Ozgecmis> Ozgecmisler { get; set; }
        [ForeignKey("UyelikId")]
        public ICollection<SirketTakip> SirketTakipleri { get; set; }
        [ForeignKey("UyelikId")]
        public ICollection<FavoriIlan> FavoriIlanlar { get; set; }
        [ForeignKey("UyelikId")]
        public ICollection<IlanKayit> IlanKayitlari { get; set; }
    }
}
