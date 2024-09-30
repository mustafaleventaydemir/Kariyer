using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class SirketTakip : IEntity
    {
        public int Id { get; set; }
        public int UyelikId { get; set; }
        public int SirketId { get; set; }
       // public Uyelik? Uyelik { get; set; }
        //public Sirket? Sirket { get; set; }
    }
}
