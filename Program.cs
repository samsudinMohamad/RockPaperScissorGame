namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissor Game. Battle with your friend to show who has better move!");
            Game game = new Game();
            game.Run();
        }
    }
}
