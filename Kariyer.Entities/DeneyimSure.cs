using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
