using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class IsIlaniUlke : IEntity
    {
        public int Id { get; set; }
        public int UlkeId { get; set; }
        //public virtual Ulke? Ulke { get; set; }
        public int IlanId { get; set; }
        // public virtual Ilan? Ilan { get; set; }
    }
}
