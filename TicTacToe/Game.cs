using System;
using System.Threading;

namespace TicTacToe
{
    public class Game
    {
        private int player;
        private int choice;
        private int flag;
        private Board board;

        public Game()
        {
            player = 1;
            choice = 1;
            flag = 0;
            board = new Board();
        }

        public int GetPlayer()
        {
            return this.player;
        }

        public void NextPlayer()
        {
            this.player++;
        }

        public void Play()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1: O / Player 2: X\n");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 chance");
                }
                else
                {
                    Console.WriteLine("Player 1 chance");
                }

                board.DisplayBoard();

                choice = int.Parse(Console.ReadLine());

                if (board.GetIndex(choice) != 'O' && board.GetIndex(choice) != 'X')
                {
                    if (player % 2 == 0)
                    {
                        board.Guess(choice, 'X');
                        player++;
                    }
                    else
                    {
                        board.Guess(choice, 'O');
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, the row {0} is already marked with {1}\n", choice,
                        board.GetIndex(choice));
                    Console.WriteLine("Loading board...");
                    Thread.Sleep(2000);
                }

                flag = CheckWin();
                
            } while (flag != 1 && flag != -1);

            Console.Clear();

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }

        private int CheckWin()
        {
            #region Horizontal Winning Condition

            if (board.GetIndex(1) == board.GetIndex(2) && board.GetIndex(2) == board.GetIndex(3))
            {
                return 1;
            }
            else if (board.GetIndex(4) == board.GetIndex(5) && board.GetIndex(5) == board.GetIndex(6))
            {
                return 1;
            }
            else if (board.GetIndex(7) == board.GetIndex(8) && board.GetIndex(8) == board.GetIndex(9))
            {
                return 1;
            }

            #endregion

            #region Vertical Winning Condition

            else if (board.GetIndex(1) == board.GetIndex(4) && board.GetIndex(4) == board.GetIndex(7))
            {
                return 1;
            }
            else if (board.GetIndex(2) == board.GetIndex(5) && board.GetIndex(5) == board.GetIndex(8))
            {
                return 1;
            }
            else if (board.GetIndex(3) == board.GetIndex(6) && board.GetIndex(6) == board.GetIndex(9))
            {
                return 1;
            }

            #endregion

            #region Oblique Winning Condition
            
            else if (board.GetIndex(1) == board.GetIndex(5) && board.GetIndex(5) == board.GetIndex(9))
            {
                return 1;
            }
            else if (board.GetIndex(3) == board.GetIndex(5) && board.GetIndex(5) == board.GetIndex(7))
            {
                return 1;
            }

            #endregion

            #region Draw

            else if (board.GetIndex(1) != '1' && board.GetIndex(2) != '2' && board.GetIndex(3) != '3' &&
                     board.GetIndex(4) != '4' &&
                     board.GetIndex(5) != '5' && board.GetIndex(6) != '6' && board.GetIndex(7) != '7' &&
                     board.GetIndex(8) != '8' &&
                     board.GetIndex(9) != '9')
            {
                return -1;
            }

            #endregion

            else
            {
                return 0;
            }
        }
    }
}