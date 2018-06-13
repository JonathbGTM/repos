using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Camionette:Vehicule
    {
        public int PoidsMaxEnKilo { get; set; }
        public decimal PrixJour { get; set; }

        public override decimal GetPrixJour()
        {
            return PrixJour;
        }
    }
}
