using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Sertifika : IEntity
    {
        public int Id { get; set; }
        [StringLength(40)]
        public string Adi { get; set; }
        [StringLength(40)]
        public string KurumAdi { get; set; }
        public DateTime Tarih { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
        public int OzgecmisId { get; set; }
        public virtual Ozgecmis? Ozgecmis { get; set; }
    }
}
