using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Hobi : IEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string? Adi { get; set; }
        public int OzgecmisId { get; set; }
        public virtual Ozgecmis? Ozgecmis { get; set; }
    }
}
