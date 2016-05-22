﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Knaufzylinder : Zylinder
    {
        private int _laenge1, _laenge2;
        private string _faerbung;

        public Knaufzylinder(string fb, int l1, int l2)
        {
            if (fb != "messing" && fb != "nickel") throw new Exception("Falsche Faerbung!");

            _faerbung = fb;
            _laenge1 = l1;
            _laenge2 = l2;
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

        public void LaengeAendern(int l1, int l2)
        {
            _laenge1 = l1;
            _laenge2 = l2;
        }

        public void Print()
        {
            Console.WriteLine("Knaufzylinder " + Laenge1 + "/" + Laenge2 + "K, Fb: " + Faerbung);
        }
    }
}
