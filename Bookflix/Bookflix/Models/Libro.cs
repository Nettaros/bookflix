using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookflix.Models
{
    public class Libro
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ISBN { get; set; }

        [Required]
        public String Nombre { get; set; }

        
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
