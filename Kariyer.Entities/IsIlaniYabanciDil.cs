using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class IsIlaniYabanciDil : IEntity
    {
        public int Id { get; set; }
        public int IlanId { get; set; }
        public int YabanciDilId { get; set; }
        [StringLength(20)]
        public string? Okuma { get; set; }
        [StringLength(20)]
        public string? Yazma { get; set; }
        [StringLength(20)]
        [Display(Name = "Konuşma")]
        public string? Konusma { get; set; }
        public virtual Ilan? Ilan { get; set; }
        public virtual YabanciDil? YabanciDil { get; set; }
    }
}
