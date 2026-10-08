using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KiaraC_naamGebruiker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kiara Cassiman
             * 08/10/2026
             * Project naamGebruiker
             */

            //Velden
            string _plaats = null;
            string _dier = null;
            string _karakter = null;
            string _euro = null;
            string _zinnen = null;

            //Programma
            //Stap 1: Vraag een plaats + opslaan
            Console.Write("Geef een plaats: ");
            _plaats = Console.ReadLine();

            //Scherm wissen
            Console.Clear();

            //Stap 2: Vraag een dier + opslaan
            Console.Write("Geef een dier: ");
            _dier = Console.ReadLine();

            //Scherm wissen
            Console.Clear();

            //Stap 3: Vraag een karakter + opslaan
            Console.Write("Geef een karakter: ");
            _karakter = Console.ReadLine();

            //Scherm wissen
            Console.Clear();

            //Stap 4: Vraag een bedrag + opslaan
            Console.Write("Geef een bedrag: ");
            _euro = Console.ReadLine();

            //Scherm wissen
            Console.Clear();

            //Maak zin
            _zinnen = $"Jan en Ali gingen naar de {_plaats} \n Ze zagen daar een {_dier} \n Jantje zei: Kijk Ali die vind ik zo {_karakter} \n Hoeveel zou dit kosten? Ali zei: het kost waarschijnlijk {_euro} euro";

            //Geef het weer
            Console.WriteLine(_zinnen);







        }
    }
}
