using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Reservation[] reservations { get; set; }

    }
}
