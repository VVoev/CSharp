using System;
using System.Collections.Generic;
using System.Linq;
public class RubickMmm
{
    public static void Main()
    {
        string [] dimensions = Console.ReadLine().Split();
        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);

        int[,] rubikMatrix = new int[rows,cols];
        for (int index = 0; index < rows * cols; index++)
        {
            rubikMatrix[index / cols,index % cols] = index + 1;
        }

        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            String[] commandArgs = Console.ReadLine().Split();
            int arrayIndex = int.Parse(commandArgs[0]);
            int moves = int.Parse(commandArgs[2]);
            switch (commandArgs[1])
            {
                case "left":
                    moveRow(rubikMatrix, arrayIndex, moves % cols, cols);
                    break;
                case "right":
                    moveRow(rubikMatrix, arrayIndex, cols - moves % cols, cols);
                    break;
                case "up":
                    moveCol(rubikMatrix, arrayIndex, moves % rows, rows);
                    break;
                case "down":
                    moveCol(rubikMatrix, arrayIndex, rows - moves % rows, rows);
                    break;
            }

        }

        rearrange(rubikMatrix, rows, cols);
    }

    private static void moveRow(int[,] matrix, int row, int moves, int cols)
    {
        int[] tempArr = new int[cols];
        for (int index = 0; index < cols; index++)
        {
            tempArr[index] = matrix[row,(index + moves) % cols];
        }

        //Array.Copy(tempArr, 0, matrix, 0, tempArr.Length);
    }

    private static void moveCol(int[,] matrix, int col, int moves, int rows)
    {
        int[] tempArr = new int[rows];
        for (int index = 0; index < rows; index++)
        {
            tempArr[index] = matrix[(index + moves) % rows,col];
        }

        for (int i = 0; i < tempArr.Length; i++)
        {
            matrix[i,col] = tempArr[i];
        }
    }

    private static void rearrange(int[,] matrix, int rows, int cols)
    {
        int expected = 1;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (matrix[row,col] != expected)
                {
                    for (int x = 0; x < rows; x++)
                    {
                        for (int y = 0; y < cols; y++)
                        {
                            if (matrix[x,y] == expected)
                            {
                                Console.WriteLine("Swap ({0}, {1}) with ({2}, {3})", row, col, x, y);
                                int temp = matrix[x,y];
                                matrix[x,y] = matrix[row,col];
                                matrix[row,col] = temp;
                            }
                        }
                    }
                }
                else {
                    Console.WriteLine("No swap required");
                }
                expected++;
            }
        }
    }
}