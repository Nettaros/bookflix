using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Bookflix.Models
{
    public class Contenido
    {
        [Column(Order=1)]
        public int Id { get; set; }
        [Required]
        public String Nombre { get; set; }

        [Required]
        public byte[] Dato { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

        [Column(Order = 2)]
        public int LibroId { get; set; }

      
        public Libro Libro { get; set; }

    }
}
