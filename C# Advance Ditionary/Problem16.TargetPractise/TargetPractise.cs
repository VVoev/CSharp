using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class TargetPractise
    {
        static void Main()
    {
        string[] dimensions = Console.ReadLine().Split(' ');
        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);
        char[,] matrix = new char[rows, cols];
        string snake = Console.ReadLine();

        //Filling Matrix in Snake Way
        FillingMatrix(rows, cols, matrix, snake);



        //Fire a shot
        string[] shotData = Console.ReadLine().Split(' ');
        int impactRow = int.Parse(shotData[0]);
        int impactCol = int.Parse(shotData[1]);
        int radius = int.Parse(shotData[2]);
        FireaShot(matrix,impactRow,impactCol,radius);



        //For start droping a chars
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            DropCharacters(matrix, col);
        }

        
        //Printing Matrix Normal Way
        PrintMatrix(matrix);
    }
    private static void DropCharacters(char[,] matrix,int col)
    {
        while (true)
        {
            bool Hasfallen = false;
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                char topChar = matrix[row - 1, col];
                char currectChar = matrix[row, col];
                if(currectChar==' ' && topChar !=' ')
                {
                    matrix[row, col] = topChar;
                    matrix[row - 1, col] = ' ';
                    Hasfallen = true;
                }
            } 
            if(!Hasfallen)
            {
                break;
            }
                    
        }

        
    }

    private static void FireaShot(char[,] matrix, int impactRow, int impactCol, int radius)
    {
        //(x - center_x)^2 + (y - center_y)^2 < radius^2
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if((col-impactCol)*(col-impactCol)+(row-impactRow) * (row-impactRow)<= radius*radius)
                {
                    matrix[row, col] = ' ';
                }
            }
        }
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void FillingMatrix(int numberofRows, int numberofCols, char[,] matrix, string snake)
    {
        bool isMovingLeft = true;
        int currentIndex = 0;
        for (int row = numberofRows - 1; row >= 0; row--)
        {
            if (isMovingLeft)
            {
                for (int col = numberofCols - 1; col >= 0; col--)
                {
                    if (currentIndex >= snake.Length)
                    {
                        currentIndex = 0;
                    }
                    matrix[row, col] = snake[currentIndex];
                    currentIndex++;
                }

            }
            else
            {
                for (int col = 0; col < numberofCols; col++)
                {
                    if (currentIndex >= snake.Length)
                    {
                        currentIndex = 0;
                    }
                    matrix[row, col] = snake[currentIndex];
                    currentIndex++;
                }
            }

            isMovingLeft = !isMovingLeft;
        }
    }
} 