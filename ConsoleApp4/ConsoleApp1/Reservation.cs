using ConsoleApp4    ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reservation
    {
        public DateTime DateDEntree { get; set; }
        public int NbDeNuitee { get; set; }

        public Chambre chambres { get; set; }
        public Client Client { get; set; }
    }
}
