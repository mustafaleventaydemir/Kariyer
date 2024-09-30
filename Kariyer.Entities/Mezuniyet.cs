using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Mezuniyet : IEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Display(Name = "Mezuniyet Durumu"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Durumu { get; set; }
    }
}
