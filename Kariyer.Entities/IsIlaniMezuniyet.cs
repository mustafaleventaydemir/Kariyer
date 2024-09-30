using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class IsIlaniMezuniyet : IEntity
    {
        public int Id { get; set; }
        public int MezuniyetId { get; set; }
        public virtual Mezuniyet? Mezuniyet { get; set; }
        public int IlanId { get; set; }
        public virtual Ilan? Ilan { get; set; }
    }
}
