using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Sehir : IEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Display(Name = "Şehir Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [ForeignKey("SehirId")]
        public ICollection<OzgecmisSehir> OzgecmisSehirler { get; set; }
        [ForeignKey("SehirId")]
        public ICollection<IsIlaniSehir> IsIlaniSehirler { get; set; }
        [ForeignKey("SehirId")]
        public ICollection<SirketSehir> SirketSehirler { get; set; }
    }
}
