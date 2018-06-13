using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Voiture : Vehicule
    {
        public int NombrePortes { get; set; } = 5;
        
        public CategorieVoiture Categorie { get; set; }

        public override decimal GetPrixJour()
        {
            return Categorie.PrixJour;
        }
    }
}
