namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and Ladder game");
            Random random = new Random();
            int dice1 = random.Next(1, 6);
            Console.WriteLine("dice rolled we get:" + dice1);
        }
    }
}