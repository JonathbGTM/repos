using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class ContratLocation
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int KilometrageMaximum { get; set; }

        public Vehicule Vehicule { get; set; }
        public Client Client { get; set; }


        public decimal CalculerMontantLocation()
        {
            int nombreJours = (DateFin - DateDebut).Days;
            return nombreJours * Vehicule.GetPrixJour() ;

        }
    }
}
