using System;
using System.ComponentModel;

namespace XOGame_Model
{
    public enum XO
    {
        X,
        O,
        Empty
    }

    public class Game
    {
        public int Size;
        private XO[,] Board;
        private XO Turn = XO.X;

        public Game(int size)
        {
            Size = size;
            Board = new XO[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Board[i, j] = XO.Empty;
                }
            }
        }

        public string CurrentTurn()
        {
            if (Turn == XO.X)
            {
                return "X";
            }
            else if (Turn == XO.O)
            {
                return "O";
            }
            else
            {
                return "";
            }
        }

        public void MakeMove(int row, int col)
        {
            Board[row, col] = Turn;
            Turn = (Turn == XO.X) ? XO.O : XO.X;
            if (CheckWin() != null)
            {
                Win.Invoke(GetWin(CheckWin()));
            }
        }

        private XO? CheckWin()
        {
            // Горизонтально
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col <= Size - 5; col++)
                {
                    if (CheckLine(Board[row, col], Board[row, col + 1], Board[row, col + 2], Board[row, col + 3], Board[row, col + 4]))
                    {
                        return Board[row, col];
                    }
                }
            }

            // Вертикально
            for (int col = 0; col < Size; col++)
            {
                for (int row = 0; row <= Size - 5; row++)
                {
                    if (CheckLine(Board[row, col], Board[row + 1, col], Board[row + 2, col], Board[row + 3, col], Board[row + 4, col]))
                    {
                        return Board[row, col];
                    }
                }
            }

            // Слева сверху вправо вниз
            for (int row = 0; row <= Size - 5; row++)
            {
                for (int col = 0; col <= Size - 5; col++)
                {
                    if (CheckLine(Board[row, col], Board[row + 1, col + 1], Board[row + 2, col + 2], Board[row + 3, col + 3], Board[row + 4, col + 4]))
                    {
                        return Board[row, col];
                    }
                }
            }

            // Слева снизу вправо вверх 
            for (int row = 0; row <= Size - 5; row++)
            {
                for (int col = 4; col < Size; col++)
                {
                    if (CheckLine(Board[row, col], Board[row + 1, col - 1], Board[row + 2, col - 2], Board[row + 3, col - 3], Board[row + 4, col - 4]))
                    {
                        return Board[row, col];
                    }
                }
            }

            // Ничья
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (Board[row, col] == XO.Empty)
                    {
                        return null;
                    }
                }
            }
            return XO.Empty;
        }

        public delegate void WinHandler(string message);
        public event WinHandler Win;

        private string GetWin(XO? winner)
        {
            if (winner == XO.Empty)
            {
                return "Ничья!";
            }
            else if (winner == XO.X)
            {
                return "Победил Х!";
            }
            else if (winner == XO.O)
            {
                return "Победил O!";
            }
            else
            {
                return "Ошибка!";
            }
        }

        private bool CheckLine(params XO[] values)
        {
            return values[0] != XO.Empty && 
                values[0] == values[1] && 
                values[1] == values[2] && 
                values[2] == values[3] && 
                values[3] == values[4];
        }
    }
}
