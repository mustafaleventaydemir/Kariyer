using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Sinav : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Sınav Adı")]
        [StringLength(80)]
        public string? Adi { get; set; }
        [StringLength(10)]
        public string? Puan { get; set; }
        public DateTime? Tarih { get; set; }
        public int OzgecmizId { get; set; }
        public virtual Ozgecmis? Ozgecmis { get; set; }
    }
}
