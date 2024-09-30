using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
