using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Push
    {
        public static void Run(Zylinder[] zylinder)
        {
            var source = new Subject<Zylinder>();

            //source
            //    .Sample(TimeSpan.FromSeconds(2.0))
            //    .Subscribe(x => Console.WriteLine($"received {x.Laenge1}/{x.Laenge2}, {x.Faerbung}"))
            //    ;

            source
                .Sample(TimeSpan.FromSeconds(1.2))
                .Where(x => x.Faerbung == "messing")
                .Subscribe(x => Console.WriteLine($"received {x.Laenge1}/{x.Laenge2}, {x.Faerbung}"))
                ;

            var t = new Thread(() =>
            {
                var i = 0;
                while (true)
                {
                    Thread.Sleep(450);
                    source.OnNext(zylinder[i]);
                    Console.WriteLine($"sent {zylinder[i].Laenge1}/{zylinder[i].Laenge2}, {zylinder[i].Faerbung}");
                    i++;
                    if (i == 5)
                    {
                        i = 0;
                    }
                }
            });
            t.Start();
        }
    }
}
