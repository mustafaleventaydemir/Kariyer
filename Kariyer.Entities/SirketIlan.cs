using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class SirketIlan : IEntity
    {
        public int Id { get; set; }
        public int SirketId { get; set; }
        public int IlanId { get; set; }
        public Sirket? Sirket { get; set; }
        public Ilan? Ilan { get; set; }
    }
}
