using System;

namespace TicTacToe
{
    public class Board
    {
        private char[] array = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

        public Board()
        {
        }
        
        public char GetIndex(int choice)
        {
            return array[choice];
        }

        public void Guess(int choice, char marker)
        {
            array[choice] = marker;
        }

        public void DisplayBoard()

        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);

            Console.WriteLine("     |     |      ");
        }
    }
}