using System;

namespace RPS
{

    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            GameItem FirstPlayer = (GameItem)Enum.Parse(typeof(GameItem),
            player1);
            GameItem SecondPlayer = (GameItem)Enum.Parse(typeof(GameItem),
            player2);
            
            GameStatus d;
            

            if (FirstPlayer == SecondPlayer)
            {
                d = 0; // Draw
            }
            else if (((FirstPlayer == GameItem.Rock) &&
                (SecondPlayer == GameItem.Scissors)) ||
                ((FirstPlayer == GameItem.Scissors) &&
                (SecondPlayer == GameItem.Paper)) ||
                ((FirstPlayer == GameItem.Paper) &&
                (SecondPlayer == GameItem.Rock)))
            {
                d = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                d = GameStatus.Player2Wins; // Player 2 wins
            }
            return (int)d;
        }
    }
}
