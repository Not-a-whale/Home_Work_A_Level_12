using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    internal class Adder
    {
        public delegate void ResultHandler(int smth);
        public delegate void Summator(int a, int b);
        public static event ResultHandler? ShowResult;

        public static void ShowSum1(int sum) => Console.WriteLine($"The sum is {sum} #1");
        public static void ShowSum2(int sum) => Console.WriteLine($"The sum is {sum} #2");
        public static void GetResult1(int a, int b)
        {
            int c = a + b;
            ShowResult = ShowSum1;
            ShowResult?.Invoke(c);
        }

        public static void GetResult2(int a, int b)
        {
            int c = a + b;
            ShowResult = ShowSum2;
            ShowResult?.Invoke(c);
        }

        public static void trySum(Summator sm,int a,int b)
        {
            try
            {
                sm(a, b);
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
