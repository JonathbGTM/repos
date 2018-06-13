using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Chambre
    {
        public string Numero { get; set; }
        public int NombreLits { get; set; }
        public decimal PrixNuitée { get; set; }

        public Hôtel Hôtel;
        public Reservation[] Reservations { get; set; }







        
    }
}
