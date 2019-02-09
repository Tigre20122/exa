using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace turybus.Models
{
    public class Boleto
    {
        [Key]
        public int IdBoleto { get; set; }
        public Ruta Ruta { get; set; }
        [Required]
        [Display(Name ="Ruta")]
        public int IdRuta { get; set; }
        [Required]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }
        [Required]
        [Display(Name = "Hora de Salida")]
        public string HoraSalida { get; set; }
        [Required]
        [Display(Name = "Iva")]
        public double Importe { get; set; }
        [Required]
        [Display(Name = "Hora llegada")]
        public string HoraLLegada { get; set; }
        [Required]
        [Display(Name = "Actividad")]
        public string Actividad { get; set; }
        [Required]
        [Display(Name = "Parada")]
        public string Parada { get; set; }

        public Vehiculo Vehiculo { get; set; }
        [Required]
        [Display(Name = "Vehiculo")]
        public int IdVehiculo { get; set; }
    }
}
