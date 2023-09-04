using System.Drawing;
namespace rectangle

{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rectangle = new rectangle (1, 2, Color.Blue, true);
            rectangle.WriteProperties();
            rectangle rectangle1 = new rectangle(5, 3, Color.Yellow, false);
            rectangle1.WriteProperties();
            rectangle rectangle2 = new rectangle(900, 22, Color.Blue, true);
            rectangle2.WriteProperties();
            rectangle rectangle3 = new rectangle(111, 234, Color.Black);
            rectangle3.WriteProperties();
        }
    }
}