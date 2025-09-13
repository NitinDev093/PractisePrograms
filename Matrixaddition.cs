using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisePrograms
{
    internal class Matrixaddition
    {
        public void additionmatrix()
        {
            Console.WriteLine("Enter number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of columns");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrixA = new int[rows, columns];

            Console.WriteLine("Enter The value of matrix A");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The value of matrix A");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrixA[i, j] + " ");
                }
                Console.WriteLine();
            }


            int[,] matrixB = new int[rows, columns];
            Console.WriteLine("Enter The value of matrix B");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The value of matrix B");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrixB[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] result = new int[rows, columns];
            Console.WriteLine("The Addition of matrix A and B are:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }

            //use this for digonal addition

            //int sum = 0;
            //Console.WriteLine("The digonal sum is:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (i == j)
            //        {
            //            sum = sum + matrixA[i, j];
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(sum);


        }
    }
}
