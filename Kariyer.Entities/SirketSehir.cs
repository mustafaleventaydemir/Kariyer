using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class SirketSehir : IEntity
    {
        public int Id { get; set; }
        public int SirketId { get; set; }
        public int SehirId { get; set; }
        public Sirket? Sirket { get; set; }
        public Sehir? Sehir { get; set; }
    }
}
