using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Bookflix.Models
{
    public abstract class Comentario
    {
        public String Texto { get; set; }
        [Key]
        [Column(Order = 1)]
        [DataType(DataType.Date)]
        public DateTime FechaCreacion { get; set; }


        
        public Perfil Perfil { get; set; }
        [Column(Order = 2)]

        public String PerfilId { get; set; }

    }
}
