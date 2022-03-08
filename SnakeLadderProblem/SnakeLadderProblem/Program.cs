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


            while (Start_POSITION < 101)
            {
                if (Start_POSITION < 0)
                {
                    Start_POSITION = 0;
                }
                else
                {

                    Random random1 = new Random();
                    int checks = random1.Next(0, 3);

                    switch (checks)
                    {
                        case 0:
                            Start_POSITION = Start_POSITION;
                            break;
                        case 1:
                            Start_POSITION += num;
                            break;
                        case 2:
                            Start_POSITION -= num;
                            break;

                    }
                    Console.WriteLine("Number got by rolling a die: " + num + "position" + Start_POSITION);
                }
            }
        }
    }
}