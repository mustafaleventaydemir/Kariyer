using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Basvuran : IEntity
    {
        public int Id { get; set; }
        public int IlanId { get; set; }
        public virtual Ilan? Ilan { get; set; }
        public int OzgecmisId { get; set; }
        public virtual Ozgecmis? Ozgecmis { get; set; }
    }
}
