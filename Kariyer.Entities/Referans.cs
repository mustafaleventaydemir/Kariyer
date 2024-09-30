using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Referans : IEntity
    {
        public int Id { get; set; }
        public string? SirketAdi { get; set; }
        public string? RefAdi { get; set; }
        public string? TelefonNo { get; set; }
        public int OzgecmisId { get; set; }
        public virtual Ozgecmis? Ozgecmis { get; set; }
    }
}
