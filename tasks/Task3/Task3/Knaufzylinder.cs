using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Knaufzylinder : Zylinder
    {
        private int _laenge1, _laenge2, _knauf;
        private string _faerbung;

        public Knaufzylinder(string Faerbung, int Laenge1, int Laenge2, int Knauf)
        {
            if (Faerbung != "messing" && Faerbung != "nickel") throw new Exception("Falsche Faerbung!");
            if (Laenge1 < 30 || Laenge1 > 80) throw new Exception("Laenge nicht moeglich!");
            if (Laenge2 < 30 || Laenge2 > 80) throw new Exception("Laenge nicht moeglich!");

            _faerbung = Faerbung;
            _laenge1 = Laenge1;
            _laenge2 = Laenge2;
            _knauf = Knauf;
        }

        public string Faerbung
        {
            get
            {
                return _faerbung;
            }

            set
            {
                if (value != "messing" && value != "nickel") throw new Exception("Falsche Faerbung!");

                _faerbung = value;
            }
        }

        public int Laenge1
        {
            get
            {
                return _laenge1;
            }

            set
            {
                _laenge1 = value;
            }
        }

        public int Laenge2
        {
            get
            {
                return _laenge2;
            }

            set
            {
                _laenge2 = value;
            }
        }

        public int Knauf
        {
            get
            {
                return _knauf;
            }

            set
            {
                _knauf = value;
            }
        }

        public void LaengeAendern(int Laenge1, int Laenge2)
        {
            _laenge1 = Laenge1;
            _laenge2 = Laenge2;
        }

        public void Print()
        {
            Console.WriteLine("Knaufzylinder " + Laenge1 + "/" + Laenge2 + "K, Faerbung: " + Faerbung + ", Knauf K" + Knauf);
        }
    }
}
