using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace turybus.Models
{
    public class Revision
    {
        [Key]
        public int IdRevision { get; set; }
        [Required]
        [Display(Name ="Fecha")]
        public string Fecha { get; set; }
        [Required]
        [Display(Name = "Diagnostico")]
        public string Diagnostico { get; set; }
        [Required]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; }
        [Required]
        [Display(Name = "Tiempo")]
        public string Tiempo { get; set; }
        [Required]
        [Display(Name = "Observacion")]
        public string Observacion { get; set; }

        public Vehiculo Vehiculo { get; set; }
        [Required]
        [Display(Name = "Vehiculo ")]
        public int IdVehiculo { get; set; }
    }
}
