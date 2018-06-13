using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Email
    {
        public string Sujet { get; set; }

        public string Destinataire { get; set; }

        public string[] DestinataireEnCopie { get; set; }

        public string Contenu { get; set; }

        public PieceJointe[] PiecesJointes { get; set; }
    }

}