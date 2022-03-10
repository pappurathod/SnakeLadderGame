// See https://aka.ms/new-console-template for more information

namespace SnakeLadderProblem
{
    class SnakeLadder
    {
        int position = 0;
        const int NO_PLAY = 0;
        const int LADDER = 1;
        const int SNAKE = 2;        
      
        static int diceRoll()
        {
            Random randomNumber = new Random();
            int die = randomNumber.Next(1, 7);
            return die;
        }


        public void PlayerTurns(string player)
        {        
            int rollDice = diceRoll();           
            Random playoption = new Random();
            int option = playoption.Next(0, 3);
            //Console.WriteLine("Dice is " + rollDice + " And Option is " + option);
           
            switch (option)
            {
                case NO_PLAY:
                    position = position;
                    break;
                
                case LADDER:
                    if (position + rollDice > 100)
                    {
                        position = position;
                    }
                    else
                    {
                        position += rollDice;
                    }                   
                        break;

                case SNAKE:
                    if (position < 0)
                    {
                        position = 0;
                    }
                    else
                    {
                        position -= rollDice;
                    }
                    
                    break;
            }        
              
            
        }

        static void Main(string[] args)
        {
            
            
            SnakeLadder player1 = new SnakeLadder();
            SnakeLadder player2 = new SnakeLadder();

            Random toss = new Random();
            int coin = toss.Next(0, 2);
            //int rollDice1 = diceRoll();

            while ((player1.position <= 100 ) && (player2.position <= 100))
            {
                if (coin == 0)
                {
                    if(player1.position == 100)
                    {
                        Console.WriteLine("Player one is winner");
                        break;
                    }
                    player1.PlayerTurns("player 1");                    
                    coin = 1;
                    Console.WriteLine("player 1 position " + player1.position);

                }
                else if (coin == 1)
                {
                    if (player2.position == 100)
                    {
                        Console.WriteLine("Player two is winner");
                        break;
                    }
                    player2.PlayerTurns("player 2");                    
                    coin = 0;
                    Console.WriteLine("player 2 position " + player2.position);
                }
            }          

        }
    }
}