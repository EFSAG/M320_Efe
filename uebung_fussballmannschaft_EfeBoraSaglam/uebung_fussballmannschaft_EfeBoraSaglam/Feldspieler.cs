using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung_fussballmannschaft_EfeBoraSaglam
{

    internal class Feldspieler
    {


        public void AusTorSchiessen()
        {
            Console.WriteLine($"{name} schiesst aufs Tor!");
        }

        public void Greatschen()
        {
            Console.WriteLine($"{name} macht eine Blutgraetsche!");
        }

        public void Dribbeln()
        {
            Console.WriteLine($"{name} dribbelt den Gegner schwindlig!");
        }

        public void Torschiessen()
        {
            Console.WriteLine($"{name} schiesset ein Tor!");
        }

        public Feldspieler()
        {

        }

        public readonly string name;
        public Feldspieler(string name)
        {
            this.name = name;
        }
    }
}