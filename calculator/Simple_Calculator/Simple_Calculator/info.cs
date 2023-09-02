using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class info
    {

        public double nummerone;
        //das brauche ich, damit ich das zugänglich in einer anderer Klasse
        public double Nummerone { 
            get {  return nummerone; }
            set { nummerone = value; }
        }

        public double method2()
        {
            Console.WriteLine("Gib nummer 1: ");
            Nummerone = Double.Parse(Console.ReadLine());
            return Nummerone;
        }
    }
    internal class tech
    {
        public double nummertwo;
        //das brauche ich, damit ich das zugänglich in einer anderer Klasse
        public double Nummertwo
        {
            get { return nummertwo; }
            set { nummertwo = value; }
        }

        public double method3()
        {
            Console.WriteLine("Gib nummer 2: ");
            Nummertwo = Double.Parse(Console.ReadLine());
            return Nummertwo;
        }
    }
    class ProgramName 
    {
        public string Pname;
        public ProgramName(string name) // Konstruktor
        {
            Pname = name;
        }
    }
    class Cal
    {
        public double antwort;
        public double antwort1;
        public double antwort2;
        public double antwort3;
        info num1 = new info();
        tech num2 = new tech();

        public void addieren()
        {
            antwort = (num1.method2() + num2.method3());
            Console.WriteLine("+ Antwort: ");
            Console.WriteLine(+antwort);
        }
        public void subtrahieren()
        {
            antwort = (num1.method2() - num2.method3());
            Console.WriteLine("- Antwort: ");
            Console.WriteLine(+antwort);
        }
        public void multiplizieren()
        {
            antwort = (num1.method2() * num2.method3());
            Console.WriteLine("* Antwort: ");
            Console.WriteLine(+antwort);
        }
        public void dividieren()
        {
            antwort = (num1.method2() / num2.method3());
            Console.WriteLine("/ Antwort: ");
            Console.WriteLine(+antwort);
        }
    }
}
