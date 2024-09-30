using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Sektor : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Sektör Adı")]
        [StringLength(80)]
        public string? Adi { get; set; }
    }
}
