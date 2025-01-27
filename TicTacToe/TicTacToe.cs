using System;
namespace TicTacToe{
    
    public class TicTacToe{
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public char currentPlayer = 'X';   
 
        public void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine($"| {board[0]} | {board[1]} | {board[2]} |");
            Console.WriteLine("|---|---|---|");
            Console.WriteLine($"| {board[3]} | {board[4]} | {board[5]} |");
            Console.WriteLine("|---|---|---|");
            Console.WriteLine($"| {board[6]} | {board[7]} | {board[8]} |");
            Console.WriteLine("-------------");
            
        }
        public void PlayerMove()
        {
            int move;
            Console.WriteLine("Pick your move!, enter a number from 1-9 to make your move");
            bool validInput = int.TryParse(Console.ReadLine(), out move) && move>=1 && move<=9&& board[move -1]!='X'&& board[move - 1] != 'O';
            if(validInput)
            {
                board[move - 1] = currentPlayer;
            }
            else{
                Console.WriteLine("Invalid option, MUST BE BETWEEN 1-9");
                PlayerMove();
            }
        }
        public bool CheckWinner()
        {
            // Winning combinations
            int[,] winCombinations =
            {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // filas
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // columnas
                { 0, 4, 8 }, { 2, 4, 6 }  // diagonales
            };

            for (int i = 0; i < winCombinations.GetLength(0); i++)
            {
                if (board[winCombinations[i, 0]] == currentPlayer &&
                    board[winCombinations[i, 1]] == currentPlayer &&
                    board[winCombinations[i, 2]] == currentPlayer)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsBoardFull()
        {
            foreach (char space in TicTacToe.board)
            {
                if (char.IsDigit(space))
                {
                    return false;
                }
            }
            return true;
        }

        public void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }
    }
