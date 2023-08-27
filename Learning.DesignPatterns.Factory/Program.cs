using System.ComponentModel.DataAnnotations;

namespace Learning.DesignPatterns.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting game...");
            //var fighter = new GunFighter();
            //var fighter2 = new BazookaFighter();
            //var enemy = new Enemy(2);
            //var enemy2 = new Enemy(3);
            ////for (int i = 0; i < 10; i++)
            ////{
            ////    fighter.Fight(enemy);
            ////}
            //for (int i = 0; i < 10; i++)
            //{
            //    fighter2.Fight(enemy2);
            //}
            Console.WriteLine(" > choose fighter:");
            Console.WriteLine("   1. rifle");
            Console.WriteLine("   2. bazooka");
            var selectedOption = Console.ReadLine();
            //var fighterType = "";
            //if (selectedOption == "1")
            //    fighterType = "rifle";
            //else if (selectedOption == "2")
            //    fighterType = "bazooka";
            var playerBuilder = new PlayerBuilder();
            //var player = playerBuilder.WithContactInfo("yazd", "09982837", "345345")
            //    .WithIdentityInfo("alex", "doe", "abd123")
            //    .Build();
            var player = playerBuilder.WithIdentityInfo("", "", "")
                .WithContactInfo("", "", "")
                .Build();

            var gamePlay = new GamePlay();
            var enemy = new Enemy(2);
            var fighter = FighterFactory.Create(selectedOption);
            if(fighter != null)
            {
                gamePlay.StartGame(fighter, enemy);
            }
        }
    }
}