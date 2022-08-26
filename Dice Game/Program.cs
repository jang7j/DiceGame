int playerRandomNumber;
int enemyRandomNumber;
int playerPoints = 0;
int enemyPoints = 0;

Random random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any key to roll the dice.");
    Console.ReadKey();

    playerRandomNumber = random.Next(1, 7);
    Console.WriteLine($"You rolled {playerRandomNumber}.");

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000); //thread waits 1 second before going to the next line

    enemyRandomNumber = random.Next(1, 7);
    Console.WriteLine($"Your enemy rolled {enemyRandomNumber}.");

    if (playerRandomNumber > enemyRandomNumber)
    {
        playerPoints++;
        Console.WriteLine("Player wins this round!");
    }
    else if (playerRandomNumber < enemyRandomNumber)
    {
        enemyPoints++;
        Console.WriteLine("Enemy wins this round!");
    }
    else
    {
        Console.WriteLine("It's a draw!");
    }

    Console.WriteLine($"The score is now - \n" +
        $"Player: {playerPoints}, Enemy: {enemyPoints}.");
    Console.WriteLine();
}
if (playerPoints > enemyPoints)
{
    Console.WriteLine("You win!!!");
}
else if (playerPoints < enemyPoints)
{
    Console.WriteLine("You lose :(");
}
else
{
    Console.WriteLine("It's a draw.");
}
Console.ReadKey();



