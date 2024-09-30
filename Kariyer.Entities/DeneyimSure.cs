using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class DeneyimSure : IEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Display(Name = "Deneyim Süresi")]
        public string? Adi { get; set; }
        [ForeignKey("DeneyimSureId")]
        public ICollection<IsIlaniDeneyimSuresi> IsIlaniDeneyimSureleri { get; set; }
    }
}
