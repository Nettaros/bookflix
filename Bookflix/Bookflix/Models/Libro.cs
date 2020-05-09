using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Razor.TagHelpers;

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
        public Editorial Editorial { get; set; }
        [Required]
        public Autor Autor { get; set; }
        [Required]
        public DateTime FechaPublicacion { get; set; }
        [Required]
        public String Sinopsis { get; set; }
        [Required]
        public Genero Genero { get; set; }
#nullable enable
        public byte[]? Imagen { get; set; }
        public List<Contenido>? Contenidos { get; set; }
        public List<Reseña>? Reseñas { get; set; }
        public List<PerfilLibros>? Lectores { get; set; }
#nullable disable


    }
}
