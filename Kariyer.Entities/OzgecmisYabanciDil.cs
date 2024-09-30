using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class OzgecmisYabanciDil : IEntity
    {
        public int Id { get; set; }
        public int OzgecmisId { get; set; }
        public int YabanciDilId { get; set; }
        [StringLength(20)]
        public string? Okuma { get; set; }
        [StringLength(20)]
        public string? Yazma { get; set; }
        [Display(Name = "Konuşma")]
        [StringLength(20)]
        public string? Konusma { get; set; }
        public virtual Ozgecmis? Ozgecmis { get; set; }
        public virtual YabanciDil? YabanciDil { get; set; }
    }
}
