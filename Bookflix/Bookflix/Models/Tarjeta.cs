using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Bookflix.Models
{
    public class Tarjeta
    {
        
        [Key]
        [Required(ErrorMessage = "DNI requerido")]
        [DisplayName("Dni del titular")]
        public String Dni { get; set; }
        
        [Required(ErrorMessage = "Numero de tarjeta requerido")]
        [RegularExpression(@"^[0-9]{16}$", ErrorMessage = "Numero de tarjeta invalido")]
        [DisplayName("Numero")]
        public String Numero { get; set; }

        [Required(ErrorMessage = "Fecha de vencimiento requirido")]
        [DataType(DataType.Date)]
        [DisplayName("Fecha de vencimiento")]
        public DateTime FechaVencimiento { get; set; }

        [Required(ErrorMessage = "Codigo de seguridadRequerido")]
        [RegularExpression(@"^[0-9]{3}$",ErrorMessage = "Debe tener exactamente 3 numeros")]
        [DisplayName("Codigo de seguridad")]
        public int CodigoSeguridad { get; set; }

        public String SubscriptorId { get; set; }
        public Subscriptor Subscriptor { get; set; }
    }
}
