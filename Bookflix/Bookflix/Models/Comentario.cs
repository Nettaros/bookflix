using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bookflix.Models
{
    public class Comentario
    {
        public String Texto { get; set; }
        [Key]
        [Column(Order = 1)]
        public DateTime FechaCreacion { get; set; }

        [ForeignKey("PerfilNombre")]
        [Column(Order = 2)]
        public Perfil Creador { get; set; }

        public String PerfilNombre { get; set; }

    }
}
