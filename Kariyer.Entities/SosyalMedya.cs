using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class SosyalMedya : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Sosyal Medya Adı")]
        [StringLength(50)]
        public string Adi { get; set; }
        [ForeignKey("SosyalMedyaId")]
        public ICollection<OzgecmisSosyalMedya> OzgecmisSosyalMedyalar { get; set; }
        [ForeignKey("SosyalMedyaId")]
        public ICollection<SirketSosyalMedya> SirketSosyalMedyalar { get; set; }
    }
}
