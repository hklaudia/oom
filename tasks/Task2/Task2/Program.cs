using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zylinder z1 = new Zylinder("messing", 30, 50);
            Zylinder z2 = new Zylinder("nickel", 35, 35);
            Zylinder z3 = new Zylinder("nickel", 40, 45);

            Console.WriteLine("Zylinder 1: " + z1.Laenge1 + "/" + z1.Laenge2 + ", Fb: " + z1.Faerbung);
            Console.WriteLine("Zylinder 2: " + z2.Laenge1 + "/" + z2.Laenge2 + ", Fb: " + z2.Faerbung);
            Console.WriteLine("Zylinder 3: " + z3.Laenge1 + "/" + z3.Laenge2 + ", Fb: " + z3.Faerbung);

            z2.LaengeAendern(55, 55);
            z3.Faerbung = "messing";
            Console.WriteLine("!! Aenderung: Zylinder 2 Laenge 55/55; Zylinder 3 Faerbung messing !!");
            
            Console.WriteLine("Zylinder 2: " + z2.Laenge1 + "/" + z2.Laenge2 + ", Fb: " + z2.Faerbung);
            Console.WriteLine("Zylinder 3: " + z3.Laenge1 + "/" + z3.Laenge2 + ", Fb: " + z3.Faerbung);

        }
    }
}
