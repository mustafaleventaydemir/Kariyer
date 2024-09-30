using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class YabanciDil : IEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Display(Name = "Yabancı Dil"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [ForeignKey("YabanciDilId")]
        public ICollection<IsIlaniYabanciDil> IsIlaniYabanciDiller { get; set; }
        [ForeignKey("YabanciDilId")]
        public ICollection<OzgecmisYabanciDil> OzgecmisYabanciDiller { get; set; }
    }
}
