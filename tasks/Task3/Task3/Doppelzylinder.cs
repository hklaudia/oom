using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Doppelzylinder : Zylinder
    {
        private int _laenge1, _laenge2;
        private string _faerbung;

        // Constructor
        public Doppelzylinder(string Faerbung, int Laenge1, int Laenge2)
        {
            if (Faerbung != "messing" && Faerbung != "nickel") throw new Exception("Falsche Faerbung!");
            if (Laenge1 < 30 || Laenge1 > 80) throw new Exception("Laenge nicht moeglich!");
            if (Laenge2 < 30 || Laenge2 > 80) throw new Exception("Laenge nicht moeglich!");

            _faerbung = Faerbung;
            _laenge1 = Laenge1;
            _laenge2 = Laenge2;
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

        public void LaengeAendern(int Laenge1, int Laenge2)
        {
            _laenge1 = Laenge1;
            _laenge2 = Laenge2;
        }

        public void Print()
        {
            Console.WriteLine("Doppelzylinder " + Laenge1 + "/" + Laenge2 + ", Faerbung: " + Faerbung);
        }
    }
}
