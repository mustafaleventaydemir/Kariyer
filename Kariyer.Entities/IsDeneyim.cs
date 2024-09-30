using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class IsDeneyim : IEntity
    {
        public int Id { get; set; }
        [StringLength(40)]
        [Display(Name = "İş Adı")]
        public string? Adi { get; set; }
        [StringLength(600)]
        [Display(Name = "Açıklama")]
        public string? Aciklama { get; set; }
        [StringLength(50)]
        [Display(Name = "Şirket Adı")]
        public string? SirketAdi { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public int OzgecmisId { get; set; }
        public virtual Ozgecmis? Ozgecmis { get; set; }
    }
}
