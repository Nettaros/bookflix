using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Bookflix.Models
{
    public class Libro
    {
        [Required]
        public String Nombre { get; set; }

        [Key]
        public int ISBN { get; set; }
        [Required]
        public String Editorial { get; set; }
        [Required]
        public String Autor { get; set; }
        [Required]
        public DateTime FechaPublicacion { get; set; }
        [Required]
        public String Sinopsis { get; set; }
#nullable enable
        public byte[]? Imagen { get; set; }
        public List<Contenido>? Contenidos { get; set; }
        public List<Reseña>? Reseñas { get; set; }
#nullable disable


    }
}
