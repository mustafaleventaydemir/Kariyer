using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Hakkimda : IEntity
    {
        public int Id { get; set; }
        [StringLength(800)]
        [Display(Name = "Hakkımda")]
        public string? Aciklama { get; set; }
        [StringLength(50)]
        public string? Meslek { get; set; }
        [StringLength(30)]
        [Display(Name = "Çalışma Şekli")]
        public string? CalismaSekli { get; set; }
        [StringLength(20)]
        public string? Konum { get; set; }
        [StringLength(10)]
        [Display(Name = "Deneyim Yılı")]
        public string? DeneyimYili { get; set; }
        [StringLength(15)]
        [Display(Name = "Mezuniyet Derecesi")]
        public string? MezuniyetDerecesi { get; set; }
        public int OzgecmisId { get; set; }
        public virtual Ozgecmis? Ozgecmis { get; set; }

    }
}
