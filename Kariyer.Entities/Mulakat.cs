using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Mulakat : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Mülakat Durumu")]
        [StringLength(80)]
        public string? Durum { get; set; }
        [ForeignKey("MulakatId")]
        public ICollection<MulakatListe> MulakatListe { get; set; }
    }
}
