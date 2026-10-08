using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_KiaraC_Rekensom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kiara Cassiman
             * 08/10/2026
             * Project Rekensom
             */

            //Velden
            int _eersteGetal = 0;
            int _tweedeGetal = 0;
            int _opgeteldGetal = 0;
            int _plusVijfGetal = 0;
            int _vermenigvuldigGetal = 0;
            int _deelGetal = 0;

            //Programma
            try
            {

                //Stap 1: vraag een eerste natuurlijk getal + opslaan
                Console.Write("Geef een eerste natuurlijk getal: ");
                _eersteGetal = int.Parse(Console.ReadLine());
            }
                //scherm wissen
                Console.Clear();
            try
            {
                //Stap 3: vraag een tweede natuurlijk getal + opslaan
                Console.Write("Geef een tweede natuurlijk getal: ");
                _tweedeGetal = int.Parse(Console.ReadLine());

                //Stap 5: tel de 2 getallen op
                _opgeteldGetal = _eersteGetal + _tweedeGetal;

                //Stap 6: Tel bij deze getal 5 op
                _plusVijfGetal = +_opgeteldGetal + 5;

                //Stap 7: vermenigvuldig de uitkomst met 10
                _vermenigvuldigGetal = _plusVijfGetal * 10;

                //Stap 8: deel door 2
                _deelGetal = _vermenigvuldigGetal / 2;
            }

                    //Stap 9: toon de uitkomst op het beeld
                    Console.WriteLine("U gaf het getal " + _eersteGetal + " en " + _tweedeGetal + " in");
            Console.WriteLine("De som hiervan is " + _opgeteldGetal);
            Console.WriteLine("Dit getal werd vermeerdert met 5. Dit gaf als uitkomst " + _plusVijfGetal);
            Console.WriteLine("Dit getal werd vermenigvuldigt met 10. Dit gaf als uitkomst " + _vermenigvuldigGetal);
            Console.WriteLine("Als laatst werd er gedeeld door 2 " + _deelGetal);
            Console.WriteLine("Het uiteindelijke resultaat is " + _deelGetal);
        } }
            catch
            {
                //scherm leegmaken
                Console.Clear();

                //foutmelding
                Console.WriteLine("Uw eerste getal was fout!");


            }
                catch
                {
                 //scherm leegmaken
                Console.Clear();

                //foutmelding
                 Console.WriteLine("Uw eerste getal was fout!");
                }

        }
    }

}
