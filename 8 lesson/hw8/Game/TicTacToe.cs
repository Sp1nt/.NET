using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class TicTacToe
    {
        private char[] table = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private char userSym, robotSym;
        private Random random = new Random();

        public void Play()
        {
            ChooseSymbols();

            while (true)
            {
                PrintBoard();

                UserMove(); 

                if (CheckWin(userSym))
                {
                    ClearInfo();
                    PrintBoard();
                    Console.WriteLine("Вы выиграли!");
                    break;
                }

                if (IsDraw())
                {
                    ClearInfo();
                    PrintBoard();
                    Console.WriteLine("Ничья!");
                    break;
                }

                RobotMove();

                if (CheckWin(robotSym))
                {
                    ClearInfo();
                    PrintBoard();
                    Console.WriteLine("Робот выиграл!");
                    break;
                }

                if (IsDraw())
                {
                    ClearInfo();
                    PrintBoard();
                    Console.WriteLine("Ничья!");
                    break;
                }
            }
        }

        public void ClearInfo()
        {
            Console.Clear();
        }

        public void PrintBoard()
        {
            Console.WriteLine($"{table[0]} {table[1]} {table[2]}");
            Console.WriteLine($"{table[3]} {table[4]} {table[5]}");
            Console.WriteLine($"{table[6]} {table[7]} {table[8]}");
        }

        private void ChooseSymbols()
        {
            Console.WriteLine("Выберите символ (X или O): ");
            userSym = Console.ReadLine().ToUpper() == "X" ? 'X' : 'O';
            robotSym = userSym == 'X' ? 'O' : 'X';
        }

        private void UserMove()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Ваш ход. Выберите позицию (1-9): ");
                choice = int.Parse(Console.ReadLine()) - 1;

                if (choice >= 0 && choice < 9 && table[choice] != 'X' && table[choice] != 'O')
                {
                    table[choice] = userSym;
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ход. Попробуйте снова.");
                }
            }
        }

        private void RobotMove()
        {
            int choice;
            while (true)
            {
                choice = random.Next(9);
                if (table[choice] != 'X' && table[choice] != 'O')
                {
                    table[choice] = robotSym;
                    break;
                }
            }
            Console.WriteLine($"Робот сделал ход: {choice + 1}");
        }

        private bool CheckWin(char sym)
        {
            int[,] winSituation = {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
                { 0, 4, 8 }, { 2, 4, 6 }
            };

            for (int i = 0; i < winSituation.GetLength(0); i++)
            {
                if (table[winSituation[i, 0]] == sym &&
                    table[winSituation[i, 1]] == sym &&
                    table[winSituation[i, 2]] == sym)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsDraw()
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] != 'X' && table[i] != 'O')
                {
                    return false;
                }
            }
            return true;
        }
    }

}
