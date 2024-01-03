using System;

namespace MyNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i=5; i>=1; i--)
            {
                int x = i * 2;
                int y = i * 3;

                for(int j = 1; j<x; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }

        }
    }
}
