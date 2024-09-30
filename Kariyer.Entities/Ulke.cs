using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Ulke : IEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Display(Name = "Ülke"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [ForeignKey("UlkeId")]
        public ICollection<Ozgecmis> Ozgecmisler { get; set; }
        [ForeignKey("UlkeId")]
        public ICollection<IsIlaniUlke> IsIlaniUlkeler { get; set; }
    }
}
