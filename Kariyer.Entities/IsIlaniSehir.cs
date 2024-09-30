using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class IsIlaniSehir : IEntity
    {
        public int Id { get; set; }
        public int SehirId { get; set; }
        public virtual Sehir? Sehir { get; set; }
        public int IlanId { get; set; }
        public virtual Ilan? Ilan { get; set; }
    }
}
