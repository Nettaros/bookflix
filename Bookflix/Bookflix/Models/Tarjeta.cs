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
        [Required(ErrorMessage = "Numero de tarjeta requerido")]
        [DataType(DataType.CreditCard)]
        public String Numero { get; set; }

        [Required(ErrorMessage = "Fecha de vencimiento requirido")]
        [DataType(DataType.Date)]
        public DateTime FechaVencimiento { get; set; }

        [Required(ErrorMessage = "Codigo de seguridadRequerido")]
        [RegularExpression(@"^[0-9]{1,3}+$")]
        public byte CodigoSeguridad { get; set; }

        public String SubscriptorId { get; set; }
        public Subscriptor Subscriptor { get; set; }
    }
}
