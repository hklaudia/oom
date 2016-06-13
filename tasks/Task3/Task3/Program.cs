using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            int i = 1;
            string path = @"C:\Users\Klaudia\Desktop\Json.txt";
            Zylinder[] zylinder;

            zylinder = new Zylinder[]
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

            //Serialize
            string s = JsonConvert.SerializeObject(zylinder, settings);
            File.WriteAllText(path, s);
           
            //Deserialize
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
            zylinder = JsonConvert.DeserializeObject<Zylinder[]>(text, settings);

            //Console.WriteLine("Push");
            //Push.Run(zylinder);

            Console.WriteLine("Tasks");
            Tasks.Run();
        }

        
    }
}
