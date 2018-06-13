using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   public abstract class Vehicule
    {
        public string Marque { get; set; }
        public string Modele { get; set; }

        public abstract decimal GetPrixJour();
   
    }
}
