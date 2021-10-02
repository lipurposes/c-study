using System;

namespace firstStudy
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numArray1 = { { 2, 3 }, { 4, 5 } };
            int[,] numArray2 = new int[,] { { 8, 9 }, { 10, 11 } };
            int length = numArray1.Length;
            int firstLength = numArray1.GetLength(0);
            int[][] numArray = { new int[] { 1 }, new int[] { 3, 4 }, new int[] { 5, 6, 7 } };
            Console.WriteLine("Hello World");
            int total = Sum(5, 6, 7);

            void Method(ref int refArgument)
            {
                refArgument = refArgument + 44;
            }

            int number = 1;
            Method(ref number);

            Man man = new Man();
            man.test();
        }

        static int Sum(params int[] nums)
        {
            int sum = 0;
            foreach (var x in nums)
            {
                sum += x;
            }
            return sum;
        }
    }
}
