using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Client:Personne
    { 
        public string Numero { get; set; }

        public ContratLocation[] Contrats { get; set; }

    }
}
