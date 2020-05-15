using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookflix.Models
{
    public class Novedad
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Titulo requerido")]
        [StringLength(50, ErrorMessage = "La longitud maxima del titulo es 50 caracteres")]
        [DisplayName("Titulo")]
        public String Titulo { get; set; }

        [Required(ErrorMessage = "Descripción requerida")]
        [StringLength(250, ErrorMessage = "La longitud maxima de la descripcion es 250 caracteres")]
        [DisplayName("Descripcion")]
        public String Descripcion { get; set; }

        [DisplayName("Fecha de Publicación")]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

        [Required(ErrorMessage = "Una Fecha de Ocultación es Requerida")]
        [DisplayName("Fecha de Ocultación")]
        [DataType(DataType.Date)]
        public DateTime? FechaOcultacion { get; set; }

#nullable enable
        [DisplayName("Imagen")]
        public byte[]? Imagen { get; set; }
        [DisplayName("Video")]
        public String? Video { get; set; }
#nullable disable

        public Novedad()
        {
            FechaPublicacion = DateTime.Now;
        }
    }
}
