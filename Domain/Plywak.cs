using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{

    [Table("Plywacy")]
    public class Plywak
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string ImieNazwisko { get; set; } = string.Empty;
        [Column(TypeName = "NUMERIC(4,0)")]
        public int RokUrodzenia { get; set; }
        [Column(TypeName = "NUMERIC(5,2)")]
        public double NajlepszyCzas { get; set; }
        public bool CzyAktywnyZawodnik { get; set; }
        [Column(TypeName = "TINYINT")]
        public int? IloscZlotychMedali { get; set; }
    }
}