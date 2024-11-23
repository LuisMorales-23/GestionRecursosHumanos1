using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRecursosHumanos1.Models
{
    public class Beneficios
    {
        // variables de prueba sin uso//

        [Key]
        public int IdBeneficio { get; set; }

        [Required]
        public string DescripcionBeneficio { get; set; }
        public float CostoEmpresa { get; set; }
        public float CostoEmpleado { get; set; }
    }
}
