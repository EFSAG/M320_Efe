/* string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(message);

if (message.Contains("fox"))
{
    Console.WriteLine("\nWhat does the fox say?");
}  */

using System;

Random dice = new Random();

int roll1 = dice.Next(1 ,4);
int roll2 = dice.Next(1, 4);
int roll3 = dice.Next(1 ,4);
int total = 0;

Console.WriteLine(total + ": Your points");
Console.WriteLine(roll1  + " " + roll2  + " "+ roll3);

if ((roll1 == roll2) & (roll2 == roll3) & (roll3 == roll1))
{
    Console.WriteLine("You rolled triples! +2 bonus to total");
    total += 2;
    Console.WriteLine($"You got 2 points, This is your new total {total}");
}

else
{
    if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
    {
        Console.WriteLine("You rolled doubles! +1 bonus to total!");
        total += 1;
        Console.WriteLine($"You got 1 points, This is your new total {total}");
    }
    else if ((roll1 != roll2) || (roll2 != roll3) || (roll3 != roll1))
    {
        {
            Console.WriteLine("Congratulation, nothing happend, you are a idiot ;)");
        }
    }
    }


