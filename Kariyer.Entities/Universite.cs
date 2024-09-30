using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Universite : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Üniversite Adı")]
        [StringLength(80)]
        public string? Adi { get; set; }
        [ForeignKey("UniversiteId")]
        public ICollection<Fakulte> Fakulte { get; set; }
    }
}
