﻿
static int DieRoll(int sides)
{
    Random rnd = new Random();
    int result = rnd.Next(1, sides);

    return result;
}
}
int die1;
int die2;

Console.WriteLine("How many sides to the dice? 2 or 6");
if input = Console.ReadLine();

{
    Random random = new Random();
    Console.WriteLine("Press any key to roll the die");
    Console.ReadLine();
    die1 = random.Next(1, 3);
    Console.WriteLine("You rolled a " + die1);
    Console.ReadLine();
    Console.WriteLine("Press any key to roll the other die");
    Console.ReadLine();
    die2 = random.Next(1, 3);
    Console.WriteLine("You rolled a " + die2);
    Console.ReadLine();
    Console.WriteLine("Your total is " + (die1 + die2));
}
Console.ReadKey();

static int DiceRoll(int )
{