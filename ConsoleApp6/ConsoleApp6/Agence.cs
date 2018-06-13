using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   public class Agence
    {
        public string Adresse { get; set; }
        public string Ville { get; set; }

        public Vehicule[] Parc { get; set; }
        public Employe[] Personnel { get; set; }
    }
}
