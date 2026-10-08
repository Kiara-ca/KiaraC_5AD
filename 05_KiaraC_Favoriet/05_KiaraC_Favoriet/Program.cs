using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_KiaraC_Favoriet
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          * Kiara Cassiman
          * 29/09/2026
          * Favoriet
          */


            //velden
            String _favorieteKleur = null;
            String _antwoordKleur = null;
            String _favorieteWeekDag = null;
            String _antwoordWeekDag = null;
            String _favorietSeizoen = null;
            String _antwoordSeizoen = null;

            //Stap 1: Vraag de kleur aan de gebruiker
            Console.Write("Kies een kleur: ");
            //Stap 2: Slaag het gegeven antwoord op
            _favorieteKleur = Console.ReadLine();

            //Stap 3: toon antwoord
            _antwoordKleur = $"Je koos {_favorieteKleur}";

            //scherm wissen
            Console.Clear();
            Console.WriteLine(_antwoordKleur);

            //Stap 3: Vraag de favoriete weekdag
            Console.Write("Wat is je favoriete weekdag?: ");
            //Stap 4: Slaag het gegeven antwoord op
            _favorieteWeekDag = Console.ReadLine();
            //Stap 5: toon antwoord
            _antwoordWeekDag = $"Je favoriete dag is {_favorieteWeekDag}";
            //scherm wissen
            Console.Clear();
            Console.WriteLine(_antwoordWeekDag);

            //Stap 6: Vraag het favoriete seizoen
            Console.Write("Wat is je favoriete seizoen?: ");
            //Stap 7: Slaag het gegeven op
            _favorietSeizoen = Console.ReadLine();
            //Stap 8: toon antwoord
            _antwoordSeizoen = $"Je favoriet seizoen is {_favorietSeizoen}";
            //scherm wissen
            Console.Clear();
            Console.WriteLine(_antwoordSeizoen);



        }
    }
}
