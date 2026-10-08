using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_KiaraC_Getallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kiara Cassiman
             * 02/10/2026
             * Getallen
             */

            //Velden
            int _getal1 = 0, _getal2 = 0, _getal3 = 0;

            //Programma

            try
            {
                //Stap 1: Vraag een eerste getal + opslaan
                
                Console.WriteLine("Geef een eerste natuurlijk getal: ");
                _getal1 = int.Parse(Console.ReadLine());

                //stap 2: Vraag tweede getal + opslaan
                Console.WriteLine("Geef een tweede natuurlijk getal: ");
                _getal2 = int.Parse(Console.ReadLine());

                //stap 3: Vraag 3 de getal + opslaan
                Console.WriteLine("Geef een derde natuurlijk getal: ");
                _getal3 = int.Parse(Console.ReadLine());

                //Scherm wissen
                Console.Clear();

                //stap 4: Toon de juiste tekst
                Console.WriteLine($"Dit was het 3de getal: {_getal1.ToString()} \nDit was het 2de getal: {_getal2.ToString()} \nDit was het 1ste getal {_getal1.ToString()}");
            }
            catch
            {
                //scherm wissen
                Console.Clear();

                //foutmelding
                Console.WriteLine("U gaf geen getal in.");
                Console.WriteLine("\nDruk op enter om af te sluiten.");



            }
        }
    }
}
