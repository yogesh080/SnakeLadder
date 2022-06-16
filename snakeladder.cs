using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class start
    {   // created player postion and ladder/snake
        static int Player1_Pos = 0;
        static int Player2_Pos = 0;
        static int[] Ladder = { 2, 16, 26, 52, 67, 75, 80 };
        static int[] Snake = { 99, 81, 60, 64, 52, 48, 40, 14 };
        static int flag = 0;
        static Random random = new Random();
        public static void GameStarted()
        {
            int die1 = 0, die2 = 0;
            Console.WriteLine("Player1 Position:" + Player1_Pos);
            Console.WriteLine("Player2 Position:"+ Player2_Pos);
            while (Player1_Pos < 100 && Player2_Pos < 100)
            {
                do
                {
                    Console.WriteLine("Player 1 is running, Position:"+ Player1_Pos);
                    Player1_Pos = playgame(Player1_Pos);
                    die1++;
                }
                while (flag == 1);

                {
                    Console.WriteLine("Player 2 is will run next" + Player2_Pos);
                    Player2_Pos = playgame(Player2_Pos);
                    die2++;
                }

            }

        }

        public static int playgame(int Player)
        {
            flag = 0;
            int RollDie = random.Next(0, 6);
            Console.WriteLine("Rolling Die:" + RollDie);

            if (Player + RollDie > 100)
            {
                Console.WriteLine("At 100 cannot play");
            }

            else if (isLadder(Player + RollDie))
            {
                int LadderEnd = random.Next(8, 12);
                Console.WriteLine("Lather increase by:" + LadderEnd);
                Player = (Player + RollDie) + LadderEnd;
                flag = 1;

            }
            else if (isSnake(Player1_Pos + RollDie))
            {
                int SnakeEnd = random.Next(8, 12);
                Console.WriteLine("Snake Eating of:" + SnakeEnd);
                Player = (Player + RollDie) - SnakeEnd;
            }
            else
            {
                Console.WriteLine("No snake No Ladder" + RollDie);
                Player += RollDie;
            }

            return Player;
        }

        public static bool isLadder(int position)
        {
            for (int i = 0; i<Ladder.Length; i++)
            {

                if (Ladder[i] == position)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool isSnake(int position)
        {
            for (int i = 0; i < Snake.Length; i++)
            {
                if (Snake[i] == position)
                {
                    return true;
                }
            }
            return false;
        }
    }
}