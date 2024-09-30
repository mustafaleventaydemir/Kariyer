using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class IsIlaniCalismaSekli : IEntity
    {
        public int Id { get; set; }
        public int CalismaSekliId { get; set; }
        public virtual CalismaSekli? CalismaSekli { get; set; }
        public int IlanId { get; set; }
        public virtual Ilan? Ilan { get; set; }
    }
}
