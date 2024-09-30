using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class YazilimDil : IEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Display(Name = "Yazılım Dili"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [ForeignKey("YazilimDilId")]
        public ICollection<OzgecmisYazilimDil> ozgecmisYazilimDils { get; set; }
    }
}
