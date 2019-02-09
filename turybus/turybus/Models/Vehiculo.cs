using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace turybus.Models
{
    public class Vehiculo
    {
        [Key]
        public int IdVehiculo { get; set; }
        [Required]
        [Display(Name ="Matricula")]
        public string Matricula { get; set; }
        [Required]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        [Required]
        [Display(Name = "Fabricante")]
        public string Fabricante { get; set; }
        [Required]
        [Display(Name = "Numero de Plazas")]
        public string NumeroPlazas { get; set; }
        [Required]
        [Display(Name = "Caracteristicas")]
        public string Caracteristicas { get; set; }

        public Conductor Conductor { get; set; }
        [Required]
        [Display(Name = "Conductor Asignado")]
        public int IdConductor { get; set; }

    }
}
