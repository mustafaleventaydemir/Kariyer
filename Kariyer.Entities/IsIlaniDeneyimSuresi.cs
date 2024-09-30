using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class IsIlaniDeneyimSuresi : IEntity
    {
        public int Id { get; set; }
        public int DeneyimSureId { get; set; }
        //public virtual DeneyimSure? DeneyimSure { get; set; }
        public int IlanId { get; set; }
        //public virtual Ilan? Ilan { get; set; }
    }
}
