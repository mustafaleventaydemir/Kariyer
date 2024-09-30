using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class OzgecmisSehir : IEntity
    {
        public int Id { get; set; }
        public int SehirId { get; set; }
        // public virtual Sehir? Sehir { get; set; }
        public int OzgecmisId { get; set; }
        //  public virtual Ozgecmis? Ozgecmis { get; set; }
    }
}
