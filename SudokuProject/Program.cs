using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SudokuProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] atakan = DataAccess.Read();

            char[,] sudoku1 = new char[9, 9];
            char[,] sudoku1_n = new char[9, 9];
            char[,] sudoku2 = new char[9, 9];
            char[,] sudoku2_n = new char[9, 9];
            char[,] sudoku3 = new char[9, 9];
            char[,] sudoku3_n = new char[9, 9];
            char[,] sudoku4 = new char[9, 9];
            char[,] sudoku4_n = new char[9, 9];
            char[,] sudoku5 = new char[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku1_n[i, j] = atakan[i][j];
                    sudoku1[i, j] = atakan[i][j];
                }
            }

            for (int i = 9; i < 18; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku2_n[i % 9, j] = atakan[i + 3][j];
                    sudoku2[i % 9, j] = atakan[i + 3][j];
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 9; j < 18; j++)
                {
                    if (i < 6)
                    {
                        sudoku3_n[i % 9, j % 9] = atakan[i][j];
                        sudoku3[i % 9, j % 9] = atakan[i][j];
                    }
                    else
                    {
                        sudoku3_n[i % 9, j % 9] = atakan[i][j + 3];
                        sudoku3[i % 9, j % 9] = atakan[i][j + 3];
                    }

                }
            }

            for (int i = 12; i < 21; i++)
            {
                for (int j = 9; j < 18; j++)
                {
                    if (i >= 15)
                    {
                        sudoku4_n[i - 12, j % 9] = atakan[i][j];
                        sudoku4[i - 12, j % 9] = atakan[i][j];
                    }
                    else
                    {
                        sudoku4_n[i - 12, j % 9] = atakan[i][j + 3];
                        sudoku4[i - 12, j % 9] = atakan[i][j + 3];
                    }

                }
            }

            for (int i = 6; i < 15; i++)
            {
                for (int j = 6; j < 15; j++)
                {
                    if (i < 9 || i >= 12)
                    {
                        sudoku5[i - 6, j - 6] = atakan[i][j];
                    }
                    else
                        sudoku5[i - 6, j - 6] = atakan[i][j - 6];
                }
            }

            //solver.SolveForCenter(sudoku5, sudoku1, sudoku2, sudoku3, sudoku4, sudoku1_n, sudoku2_n, sudoku3_n, sudoku4_n);


            Console.ReadLine();
        }
    }
}
