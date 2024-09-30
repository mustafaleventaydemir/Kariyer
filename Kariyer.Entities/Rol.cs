using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Rol : IEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Display(Name = "Rol Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string RolAdi { get; set; }
        [ForeignKey("RolId")]
        public ICollection<Uyelik> Uyelikler { get; set; }
    }
}
