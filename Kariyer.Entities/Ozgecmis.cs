﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Kariyer.Entities
{
    public class Ozgecmis : IEntity
    {
        public int Id { get; set; }
        public int UyelikId { get; set; }
        public string? TelefonNo { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email { get; set; }
        public int CinsiyetId { get; set; }
        public int UyrukId { get; set; }
        public string? Adres { get; set; }
        public bool Durum { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime? DogumTarihi { get; set; }
        [ForeignKey("OzgecmisId")]
        public ICollection<Egitim> Egitim { get; set; } //
        [ForeignKey("OzgecmisId")]
        public ICollection<MulakatListe> MulakatListe { get; set; }
        [ForeignKey("OzgecmisId")]
        public ICollection<OzgecmisYazilimDil> ozgecmisYazilimDils { get; set; }
        [ForeignKey("OzgecmisId")]
        public ICollection<OzgecmisHavuzu> ozgecmisHavuzus { get; set; }
    }
}
