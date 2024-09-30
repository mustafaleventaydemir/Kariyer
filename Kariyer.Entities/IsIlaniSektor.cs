using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class IsIlaniSektor : IEntity
    {
        public int Id { get; set; }
        public int SektorId { get; set; }
        public int IlanId { get; set; }
        // public Sektor? Sektor { get; set; }
        //public Ilan? Ilan { get; set; }
    }
}
