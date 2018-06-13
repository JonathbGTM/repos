using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class CategorieVoiture
    {
        public string Nom { get; set; }
        public decimal PrixJour { get; set; }

        public Voiture[] Voitures { get; set; }

    }
}
