Player Player1 = new Player();
Enemy Enemy = new Enemy();

System.Console.WriteLine("Please type the name you wish to be called.");

Player1.name = Console.ReadLine();

System.Console.WriteLine($"Greetings {Player1.name} what sort of enemy do you wish to fight?");

Enemy.name = Console.ReadLine();

System.Console.WriteLine($"Our brave warrior will fight the enemy called {Enemy.name}.");
System.Console.WriteLine("");
System.Console.WriteLine("Do you choose to attack your foe? yes/no");

string Attack = Console.ReadLine();

if (Attack == "yes")
{
    System.Console.WriteLine("You manage to hit the head of your foe rendering him unable to fight!");
    Enemy.hp -= 100;
}
else
{
    System.Console.WriteLine("Your foe surprises you with an attack and causes you to stumble down a ledge. This causes you to pass out.");
    System.Console.WriteLine("");
    System.Console.WriteLine("Your foe is declared the victor!");
}

if (Enemy.hp == 0)
{
    Enemy.dead = true;
}



Console.ReadLine();