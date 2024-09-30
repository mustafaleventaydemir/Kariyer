using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class MulakatListe : IEntity
    {
        public int Id { get; set; }
        public int OzgecmisId { get; set; }
        public int MulakatId { get; set; }
        public int SirketId { get; set; }
        public int IlanId { get; set; }
        //public Ozgecmis? Ozgecmis { get; set; } = null!;
        //public Mulakat? Mulakat { get; set; } = null!;
        //public Sirket? Sirket { get; set; } = null!;
        //public Ilan? Ilan { get; set; } = null!;
    }
}
