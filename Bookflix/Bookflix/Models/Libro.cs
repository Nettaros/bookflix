﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel;

namespace Bookflix.Models
{
    public class Libro
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Required(ErrorMessage = "ISBN Requerido")]
        public int ISBN { get; set; }

        [Required(ErrorMessage = "Titulo Requerido")]
        public String Titulo { get; set; }

           
        public Editorial Editorial { get; set; }

      
        public Autor Autor { get; set; }

        [Required(ErrorMessage = "Fecha de Publicacion Requerida")]
        [DataType(DataType.Date)]
        [DisplayName("Fecha de Publicacion")]
        public DateTime FechaPublicacion { get; set; }

        [Required(ErrorMessage = "Sinopsis Requerida")]
        public String Sinopsis { get; set; }

        public Genero Genero { get; set; }
#nullable enable
        public byte[]? Imagen { get; set; }
        public List<Contenido>? Contenidos { get; set; }
        public List<Reseña>? Reseñas { get; set; }
        public List<PerfilLibros>? Lectores { get; set; }
#nullable disable


    }
}
