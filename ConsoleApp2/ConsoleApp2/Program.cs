using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ArrayList ListeContact = new ArrayList();
            bool actif = true;
            while (actif)
            {
                
                afficherMenu();

                string saisie = Console.ReadLine();
                Console.WriteLine("Votre choix: " + saisie);

                switch (saisie)
                {
                    case "4":
                        actif= false;
                        Console.WriteLine("votre liste:");
                        liste(ListeContact);
                        break;

                    case "1":
                        liste(ListeContact);
                        break;

                    case "2":
                        Console.WriteLine("Contact à ajouter :");
                        string nouveauContact = Console.ReadLine();
                        ListeContact.Add(nouveauContact);
                        Console.WriteLine("votre liste:");
                        liste(ListeContact);
                        ;

                        break;


                    case "3":
                        Console.WriteLine("Contact à supprimer :");
                        string supprimerContact = Console.ReadLine();
                        ListeContact.Remove(supprimerContact);
                        Console.WriteLine("votre liste:");
                        liste(ListeContact);
                        
                        break;

                }



                //Console.ReadKey();


            }
        }

        private static void liste(ArrayList ListeContact)
        {
            for (int i = 0; i < ListeContact.Count; i++)
            {
                Console.WriteLine(ListeContact[i]);
            }
        }

        private static void afficherMenu()
        {
            Console.WriteLine("1: Liste des contacts");
            Console.WriteLine("2: Ajouter un contact");
            Console.WriteLine("3: Supprimer un contat");
            Console.WriteLine("4:Quitter");
            Console.WriteLine();
            Console.WriteLine("Entrez votre choix:");
        }
    }
}
