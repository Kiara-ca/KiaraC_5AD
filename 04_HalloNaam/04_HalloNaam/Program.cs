using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HalloNaam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kiara Cassiman
             * 22/09/2026
             * Hallo Naam
             */

            // Velden
            String _naamGebruiker = null;
            string _bewerking = null;

            // Programma

            // Stap 1: Vraag naam van de gebruiker + opslaan
            Console.Write("Geef uw naam: ");
            _naamGebruiker = Console.ReadLine();

            // Stap 2: Maak de juiste tekst
            //_bewerking = "Hallo" + _naamGebruiker (kan ook)
            _bewerking = $"Hallo {_naamGebruiker}";

           
            //Scherm wissen
            Console.Clear();


            // Stap 3: Toon de tekst in de juiste vorm
            Console.WriteLine(_bewerking);


        }
    }
}
