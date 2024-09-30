using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Fakulte : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Fakülte Adı")]
        [StringLength(80)]
        public string? Adi { get; set; }
        public int UniversiteId { get; set; }
        [ForeignKey("FakulteId")]
        public ICollection<Bolum> Bolum { get; set; }
    }
}
