using Bookflix.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Bookflix.Views.Usuario
{
    public class DatosCreacionViewModel
    {
        [DisplayName("Quiero ser premium")] 
        public Boolean quieroSerPremium{ get; set; }
         public Subscriptor Subscriptor { get; set; }
    }
}
