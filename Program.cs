using System;

namespace csharp_RandomNumberGenerator
{
    class Program
    {
        private static void Print(int[,] array)
        {
            var rowLength = array.GetLength(0);
            var colLength = array.GetLength(1);

            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", array[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            const int n = 4, m = 4;
            
            var random = new Random();

            var array = new int[n, m];

            for (var i=0;i<n;++i)
            for (var j=0;j<m;++j)
                array[i, j] = random.Next();
            
            Print(array);
        }
    }
}