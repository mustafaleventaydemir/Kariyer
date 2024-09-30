using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class OzgecmisSosyalMedya : IEntity
    {
        public int Id { get; set; }
        public int SosyalMedyaId { get; set; }
        public int OzgecmisId { get; set; }
        [Display(Name = "Hesap Adı")]
        [StringLength(80)]
        public string? HesapAdi { get; set; }
        // public virtual SosyalMedya? SosyalMedya { get; set; }
        //public virtual Ozgecmis? Ozgecmis { get; set; }
    }
}
