using System;

namespace TicTacToe{
    class Program{    
        static void Main(string[] args)
        {
            TicTacToe ticTacToe = new TicTacToe();
            while (true){
                ticTacToe.DisplayBoard();
                ticTacToe.PlayerMove();
                if(ticTacToe.IsBoardFull())
                {
                    ticTacToe.DisplayBoard();
                    Console.WriteLine("Yall both failed the vibe check, it's a tie womp womp.");
                    break;
                }
                if(ticTacToe.CheckWinner()){
                    ticTacToe.DisplayBoard();
                    Console.WriteLine($"Congratz!, player {ticTacToe.currentPlayer} passed the vibe check.");
                    break;
                }
                
                ticTacToe.SwitchPlayer();
            }
        }
    }
}
