﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Zylinder
    {
        private int _laenge1, _laenge2;
        private string _faerbung;

        // Constructor
        public Zylinder(string fb, int l1, int l2)
        {
            if (fb != "messing" && fb != "nickel") throw new Exception("Falsche Faerbung!");

            _faerbung = fb;
            _laenge1 = l1;
            _laenge2 = l2;
        }

        public int Laenge1
        {
            get {
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

        public void LaengeAendern(int l1, int l2)
        {
            _laenge1 = l1;
            _laenge2 = l2;
        }

    }
}
