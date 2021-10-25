using System;
using System.Collections;
using System.Collections.Generic;

namespace firstStudy
{
    
    class Program
    {
        static Func<int, int> test1;
        static Action<int> test2;
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

            // Man man = new Man();
            // man.test();

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(444);
            myArrayList.Add("test1");
            myArrayList.Add(new Persion());
            Persion persion = myArrayList[2] as Persion;
            persion.test();

            List<int> list1 = new List<int>();

            Stack myStack = new Stack();
            Stack<int> testStack = new Stack<int>();

            TestDelegate delegateA = new TestDelegate();
            Console.WriteLine(delegateA.checkFunc(10));

            // Testdel1 test1 = delegate(int num){
            //     return num;
            // };
            test1 = num => num;
            Console.WriteLine(test1(12));

            test2 = num => Console.WriteLine(num);
            test2(99);
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
