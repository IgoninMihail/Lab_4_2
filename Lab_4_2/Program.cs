using System;

namespace Lab_4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] A = new int[5,5]
            {
                { 1,1,1,1,1},
                { 0,1,1,1,0},
                { 1,1,0,1,1},
                { 0,1,1,1,0},
                { 1,1,1,1,1}
            };

            int h = A.GetLength(0);
            int w = A.GetLength(1);

            for (int y = 0; y < h; y++)
            {
                for(int x = 0; x < w; x++)
                {
                    Console.Write(A[y,x] + "\t");
                }
                Console.WriteLine();
            }

        } 
    }
}
