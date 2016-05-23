using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task3
{
    [TestFixture]

    class Tests
    {
        [Test]
        public void DoppelzylinderFaerbungMussNickelOderMessingSein()
        {
            Assert.Catch(() =>
            {
                var x = new Doppelzylinder("blau", 40, 45);
            });
        }

        [Test]
        public void KnaufzylinderFaerbungMussNickelOderMessingSein()
        {
            Assert.Catch(() =>
            {
                var x = new Knaufzylinder("rot", 30, 30, 1);
            });
        }

        [Test]
        public void KnaufzylinderLaengeMussZwischen30Und80Sein()
        {
            Assert.Catch(() =>
            {
                var x = new Knaufzylinder("messing", 30, 85, 2);
            });
            Assert.Catch(() =>
            {
                var x = new Knaufzylinder("messing", 25, 90, 2);
            });
        }

        [Test]
        public void DoppelzylinderLaengeMussZwischen30Und80Sein()
        {
            Assert.Catch(() =>
            {
                var x = new Doppelzylinder("nickel", 20, 45);
            });
        }

        [Test]
        public void DoppelzylinderKannAngelegtWerden()
        { 
            var x = new Doppelzylinder("nickel", 35, 60);
            Assert.IsTrue(x.Faerbung == "nickel");
            Assert.IsTrue(x.Laenge1 == 35);
            Assert.IsTrue(x.Laenge2 == 60);
        }

        [Test]
        public void KnaufzylinderKannAngelegtWerden()
        {
            var x = new Knaufzylinder("messing", 45, 50, 5);
            Assert.IsTrue(x.Faerbung == "messing");
            Assert.IsTrue(x.Laenge1 == 45);
            Assert.IsTrue(x.Laenge2 == 50);
            Assert.IsTrue(x.Knauf == 5);
        }

        [Test]
        public void DoppelzylinderMussFaerbungHaben()
        {
            Assert.Catch(() =>
            {
                var x = new Doppelzylinder("", 35, 60);
            });
           
        }

        [Test]
        public void LaengeKannGeandertWerden()
        {
            var x = new Knaufzylinder("messing", 45, 50, 5);
            x.LaengeAendern(50, 55);

            Assert.IsTrue(x.Laenge1 == 50);
            Assert.IsTrue(x.Laenge2 == 55);

        }

    }
}
