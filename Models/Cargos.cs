﻿using System.ComponentModel.DataAnnotations;

namespace GestionRecursosHumanos1.Models
{
    public class Cargos
    {
        [Key]
        public int IdCargos { get; set; }
        [Required]
        public string TituloCargo { get; set; }
        public string DescripcionCargos { get; set; }
    }
}
