using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookflix.Models
{
    public class Perfil
    {
        [Key]
        [Column(Order = 1)]
        public String Nombre { get; set; }

        [Column(Order = 2)]
        public String SubscriptorId { get; set; }

        
        public Subscriptor Subscriptor { get; set; }

        
#nullable enable
        public byte[]? Imagen { get; set; }
        public List<PerfilLibros>? LibrosLeidos { get; set; }

#nullable disable
    }
}
