using System;

namespace ProjetoConceitos
{
    public static class Matriz
    {
        public static void Declaration()
        {
            int[,] matrix = new int[2, 3];

            Console.WriteLine($"Column x Rows (Lenght) = {matrix.Length}");
            Console.WriteLine($"Lenght of Rows = {matrix.Rank}");
            Console.WriteLine($"Lenght Dimension 0 = {matrix.GetLength(0)}");
            Console.WriteLine($"Lenght Dimension 1 = {matrix.GetLength(1)}");
        }
        public static void ExemploOne()
        {
            Console.Write("\nInforme a Dimensão da sua Matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                Console.Write($"Informe os valores da linha {row + 1} separados por espaço:");
                string[] values = Console.ReadLine().Split(' ');

                for (int column = 0; column < n; column++)
                {
                    matrix[row, column] = int.Parse(values[column]);
                }
            }

            Console.WriteLine("\nMain Diagonal:");
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine($"{matrix[row,row]}");
            }

            int count = 0;
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    if (matrix[row, column] < 0)
                        count++;
                }
            }

            Console.WriteLine($"\nNegative Numbers: {count}");
        }
        public static void ExercicioMatriz()
        {
            Console.Write("Informe a quantidade de linhas e colunas da sua Matrix: ");
            string[] dimension = Console.ReadLine().Split(' ');
            int n = int.Parse(dimension[0]);
            int m = int.Parse(dimension[1]);
            int[,] matrix = new int[n,m];
            Console.WriteLine("");

            for (int row = 0; row < n; row++)
            {
                Console.Write($"Informe os {m} números da linha {row + 1} separados por espaço:");
                string[] values = Console.ReadLine().Split(' ');

                for (int column = 0; column < m; column++)
                {
                    matrix[row,column] = int.Parse(values[column]);
                }
            }

            Console.Write("Informe o número para pesquisa: ");
            int number = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < m; column++)
                {
                    if (number == matrix[row, column])
                    {
                        Console.WriteLine($"Position({row},{column}):");

                        if (row > 0)
                            Console.WriteLine($"Up:{matrix[row - 1, column]}");

                        if (column > 0)
                            Console.WriteLine($"Left:{matrix[row, column - 1]}");

                        if (column < n - 1)
                            Console.WriteLine($"Right:{matrix[row, column + 1]}");

                        if(row < m - 1)
                            Console.WriteLine($"Down:{matrix[row + 1, column]}");
                    }
                }
                Console.WriteLine("");
            }

        }

    }
}
