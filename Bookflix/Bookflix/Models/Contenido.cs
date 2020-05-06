using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DateTime FechaPublicacion { get; set; }


        public int LibroISBN { get; set; }

        [ForeignKey("LibroISBN")]
        [Column(Order = 2)]
        public Libro Libro { get; set; }

    }
}
