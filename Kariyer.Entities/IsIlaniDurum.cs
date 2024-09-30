using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class IsIlaniDurum : IEntity
    {
        public int Id { get; set; }
        public int IlanId { get; set; }
        public virtual Ilan? Ilan { get; set; }
        public int IlanDurumId { get; set; }
        public virtual IlanDurumu? IlanDurumu { get; set; }
    }
}
