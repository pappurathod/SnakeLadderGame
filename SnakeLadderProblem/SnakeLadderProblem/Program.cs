// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome to Snake And Ladder Game");
namespace SnakeLadderProblem
{
    class SnakeLadder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game");

            int Start_POSITION = 0;
            int NUMBER_OF_PLAYER = 1;
            Random random = new Random();
            int num = random.Next(1, 6);
            Console.WriteLine("Number got by rolling a die: " + num);
      
        }
    }
}
