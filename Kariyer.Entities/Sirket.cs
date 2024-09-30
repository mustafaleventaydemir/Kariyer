﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Entities
{
    public class Sirket : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Şirket Adı")]
        [StringLength(80)]
        public string? Adi { get; set; }
        [Display(Name = "Telefon")]
        [StringLength(80)]
        public string? TelefonNo { get; set; }
        [StringLength(250)]
        public string? Adres { get; set; }
        [Display(Name = "Hakkımızda")]
        [StringLength(800)]
        public string? Hakkimizda { get; set; }
        [Display(Name = "Web Adresi")]
        [StringLength(100)]
        public string? Link { get; set; }
        public int UyelikId { get; set; }
        public virtual Uyelik? Uyelik { get; set; }
        [ForeignKey("SirketId")]
        public ICollection<MulakatListe> MulakatListe { get; set; }
        [ForeignKey("SirketId")]
        public ICollection<OzgecmisHavuzu> ozgecmisHavuzus { get; set; }
        [ForeignKey("SirketId")]
        public ICollection<SirketTakip> sirketTakips { get; set; }
    }
}
