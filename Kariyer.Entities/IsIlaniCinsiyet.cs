using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class IsIlaniCinsiyet : IEntity
    {
        public int Id { get; set; }
        public int CinsiyetId { get; set; }
        // public virtual Cinsiyet? Cinsiyet { get; set; }
        public int IlanId { get; set; }
        //public virtual Ilan? Ilan { get; set; }
    }
}
