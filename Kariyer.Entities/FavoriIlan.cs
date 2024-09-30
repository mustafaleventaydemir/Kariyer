using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class FavoriIlan : IEntity
    {
        public int Id { get; set; }
        public int UyelikId { get; set; }
        public int IlanId { get; set; }
        // public Uyelik? Uyelik { get; set; }
        // public Ilan? Ilan { get; set; }
    }
}
