using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Egitim : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Açıklama")]
        [StringLength(600)]
        public string? Aciklama { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public int OzgecmisId { get; set; }
        //public int UniversiteId { get; set; }
        public int BolumId { get; set; }
    }
}
