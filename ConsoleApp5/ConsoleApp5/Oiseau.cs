using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMammifere
{
    public class Oiseau:Animal
    {
        private bool peutVoler;
        public bool PeutVoler
        {
            get { return peutVoler; }
            private set { peutVoler = value; }
        }
       
       
    }
}
