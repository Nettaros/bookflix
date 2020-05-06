using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookflix.Models
{
    public class Reseña : Comentario
    {
        public byte Puntaje { get; set; }
    }
}
