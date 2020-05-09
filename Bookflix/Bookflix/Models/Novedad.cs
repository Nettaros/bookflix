using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookflix.Models
{
    public class Novedad
    {
        public int Id { get; set; }
        [Required]
        public String Titulo { get; set; }

#nullable enable
        public String? Descripcion { get; set; }
        public byte[]? Imagen { get; set; }
        public String? Video { get; set; }
#nullable disable
    }
}
