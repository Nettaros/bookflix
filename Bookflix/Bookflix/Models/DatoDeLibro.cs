﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bookflix.Models
{
    public abstract class DatoDeLibro
    {
        [Key]
        public String Nombre { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
