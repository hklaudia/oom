using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            var zylinder = new Zylinder[]
            {
                new Doppelzylinder("messing", 30, 50),
                new Doppelzylinder("nickel", 35, 35),
                new Doppelzylinder("nickel", 40, 45),
                new Knaufzylinder("messing", 65, 30, 6),
                new Knaufzylinder("messing", 40, 40, 1)
            };

            foreach (var x in zylinder)
            {
                Console.Write($"Zylinder {i++}: ");
                x.Print();
            }

            zylinder[1].LaengeAendern(55, 55);
            zylinder[3].Faerbung = "nickel";       
            Console.WriteLine("\n!! Aenderung: Zylinder 2 Laenge 55/55; Zylinder 4 Faerbung nickel !!\n");

            i = 1;
            foreach (var x in zylinder)
            {
                Console.Write($"Zylinder {i++}: ");
                x.Print();
            }
        }
    }
}
