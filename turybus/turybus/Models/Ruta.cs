using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace turybus.Models
{
    public class Ruta
    {
        [Key]
        public int IdRuta { get; set; }
        [Required]
        [Display(Name ="Nombre Ruta")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Descripciòn Ruta")]
        public string Descripcion { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public Boolean Estado { get; set; }

     
    }
}
