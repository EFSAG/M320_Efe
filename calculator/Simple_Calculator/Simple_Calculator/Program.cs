namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramName show = new ProgramName("SIMPLE CALCULATOR");
            Console.WriteLine(show.Pname);
            Console.WriteLine("________________________\n");
            do
            {
                Console.WriteLine("_________________________________");
                Console.WriteLine("| Wählen sie eine Operation aus:|");
                Console.WriteLine("|                               |");
                Console.WriteLine("| (+) (-) (/) (*)               |");
                Console.WriteLine("|                               |");
                Console.WriteLine("|                               |");
                Console.WriteLine("|Operation eingeben:            |");
                Console.WriteLine("|_______________________________|");
                // char Operation = char.Parse(Console.ReadLine());
                info num1 = new info(); // Nummer 1 ist ein object von class info
                tech num2 = new tech(); // Nummer 2 ist ein object von class tech
                Cal ops = new Cal(); //ops ist ein Object von Class Cal
                switch(Console.ReadLine())
                {
                    case "+":
                        ops.addieren();
                        break;
                    case "-":
                        ops.subtrahieren();
                        break;
                    case "*":
                        ops.multiplizieren();
                        break;
                    case "/":
                        ops.dividieren();
                        break;
                    default:
                        System.Console.WriteLine("That was not a valid option");
                        break;
                }/*
                if (Operation == '+')
                {
                    ops.addieren();
                }
                if (Operation == '-')
                {
                    ops.subtrahieren();
                }
                if (Operation == '*')
                {
                    ops.multiplizieren();
                }
                if (Operation == '/')
                {
                    ops.dividieren();
                } */
                Console.WriteLine("Möchtest du weiter? (Y = yes, N = no):");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Tschüüüüssss");
        }
    }
}