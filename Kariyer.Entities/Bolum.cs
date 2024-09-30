using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Bolum : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Bölüm Adı")]
        [StringLength(80)]
        public string? Adi { get; set; }
        public int FakulteId { get; set; }
        [ForeignKey("BolumId")]
        public ICollection<Egitim> Egitim { get; set; }
    }
}
