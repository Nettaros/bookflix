using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookflix.Models
{
    public class Tarjeta
    {
        [Key]
        public String Numero { get; set; }
        [Required]
        public DateTime FechaVencimiento { get; set; }
        [Required]
        public byte CodigoSeguridad { get; set; }

        public String SubscriptorId { get; set; }
        public Subscriptor Subscriptor { get; set; }
    }
}
