using System;

namespace Z_5
{
   
    class DoubleMatrix
    {
        private double[,] matrix;
        public int rows, cols;
        private int Length;
        int r = 0;
        bool a = true, t = false;
        public DoubleMatrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new double[this.rows, this.cols];
            Length = rows * cols;
        }
        public double this[int index1, int index2]
        {
            get { return matrix[index1, index2]; }
            set { matrix[index1, index2] = value; }
        }
        public void Zero()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 0)
                    { r = r + 1; }
                }
            }
            if (r == cols * rows)
            { Console.WriteLine("Матрица нулевая"); }
            else { Console.WriteLine("Матрица не нулевая"); }
        }
        public bool Method1()
        {
            if (cols == rows)
            {
                for (int i = 0; i < matrix.GetLength(0); ++i)
                {
                    for (int j = 0; j < matrix.GetLength(1); ++j)
                        if (matrix[i, j] != matrix[j, i])
                        {
                            a = false;
                            break;
                        }
                    if (!a) break;
                }
                return a;
            }
            else return false;
        }
        public void Square()
        {
            if (rows == cols)
            {
                Console.WriteLine("Матрица квадратная");
            }
            else Console.WriteLine("Матрица не квадратная");
        }
        public bool Single()
        {
            if (rows == cols)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i == j && matrix[i, j] != 1)
                        {
                            return false;
                        }
                        else if (i != j && matrix[i, j] != 0)
                        { return false; }
                    }
                }
                return true;
            }
            return false;
        }
        public bool Diagonal()
        {
            if (rows == cols)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i != j)
                        {
                            if (matrix[i, j] == 0)
                            {
                                t = true;
                            }
                            else t = false;
                            break;
                        }
                    }
                }
            }
            return t;
        }
        public bool Upper()
        {
            if (rows == cols)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] != 0 && i > j)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        public bool Lower()
        {
            if (rows == cols)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] != 0 && i < j)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();
                Console.WriteLine("Введите количество строк матрицы");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов матрицы");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Заполните матрицу");
                DoubleMatrix matrix = new DoubleMatrix(n, m);
                for (int i = 0; i < matrix.rows; i++)
                {
                    for (int j = 0; j < matrix.cols; j++)
                    {
                        matrix[i, j] = rnd.Next(1, 10) + rnd.NextDouble();
                    }
                }
                Console.WriteLine("Матрица :");
                for (int i = 0; i < matrix.rows; i++)
                {
                    for (int j = 0; j < matrix.cols; j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                matrix.Zero();
                if (matrix.Method1() == false)
                {
                    Console.WriteLine("Матрица не симметричная");
                }
                else Console.WriteLine("Матрица симметричная");
                matrix.Square();
                if (matrix.Single())
                {
                    Console.WriteLine("Матрица единичная");
                }
                else Console.WriteLine("Матрица не единичная");
                if (matrix.Diagonal() == true)
                {
                    Console.WriteLine("Матрица диагональная");
                }
                else Console.WriteLine("Матрица не диагональная");
                if (matrix.Upper())
                {
                    Console.WriteLine("Матрица верхняя треугольная ");
                }
                else Console.WriteLine("Матрица не верхняя треугольная ");
                if (matrix.Lower())
                {
                    Console.WriteLine("Матрица нижняя треугольная ");
                }
                else Console.WriteLine("Матрица не нижняя треугольная ");
                Console.WriteLine(matrix[0, 0]);
                Console.ReadLine();
            }
        }
    }
}
