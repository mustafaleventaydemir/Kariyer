using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class OzgecmisYazilimDil : IEntity
    {
        public int Id { get; set; }
        public byte BilgiOrani { get; set; }
        public int OzgecmisId { get; set; }
        public int YazilimDilId { get; set; }
        //public virtual Ozgecmis Ozgecmis { get; set; }
       // public virtual YazilimDil YazilimDil { get; set; }
    }
}
