using System;
using GameScenario;
namespace ConsoleApp_Game {
    class Program {
        static void Main(string[] args) {
            IDice dice = new Dice();
            IPlayer p1 = new Player(dice);
            IPlayer p2 = new Player(dice);
            Game game = new Game(p1,p2);
            IPlayer p = game.Play();
            Console.WriteLine($"The winner is {p?.Name ?? "nobody"}");
        }
    }
}
