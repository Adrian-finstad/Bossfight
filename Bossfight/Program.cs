// See https://aka.ms/new-console-template for more information

//HVORDAN LAGE RANDOM
//Random rand = new Random();
//var randomNumber = rand.Next(0, 3);

using Bossfight;
Console.WriteLine("Welcome to the bossfight!");
Random rand = new Random();
//var BossStrength = rand.Next(0, 31);
var Hero = new GameCharacter(100, 20, 40, "Herkules");
var Boss = new GameCharacter(400, 0, 10, "Erna Solberg");
void main()
{
    Console.WriteLine("Press 1 to fight!");
    Console.WriteLine("Press 2 to recharge Hero stamina");
    Console.WriteLine("Press 3 to recharge boss stamina. ");
    while (true) {
        Boss.Strength = rand.Next(0, 31);
        var playerChoice = Console.ReadLine();
        if (playerChoice == "1") {
            GameCharacter.Fight(Hero, Boss);
            main();    
        }
        else if(playerChoice == "2")
        {
            Hero.Recharge();
        }
        else if(playerChoice == "3")
        {
            Boss.Recharge();
        }
        
    }
}

main();


