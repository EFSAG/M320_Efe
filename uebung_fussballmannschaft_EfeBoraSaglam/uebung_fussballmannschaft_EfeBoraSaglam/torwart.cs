using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung_fussballmannschaft_EfeBoraSaglam
{
    internal class Torwart
    {
        readonly string name;

        private Fussballmannschaft fussballmannschaft;

        public void SetFussballmanschaft(Fussballmannschaft fussballmanschaft)
        {
            this.fussballmannschaft = fussballmannschaft;
        }
        public void Schusshalten()
        {
            Console.WriteLine($"{name} hält den Schuss vom Gegner!");
        }
        public void Abstoss()
        {
            Console.WriteLine($"{name} macht einen Abstoss!");
        }
        public Torwart()
        {

        }

        public Torwart(string name)
        {
            this.name = name;
        }
    }
}