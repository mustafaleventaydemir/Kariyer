using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class SirketSektor : IEntity
    {
        public int Id { get; set; }
        public int SektorId { get; set; }
        public int SirketId { get; set; }
        public Sektor? Sektor { get; set; }
        public Sirket? Sirket { get; set; }
    }
}
