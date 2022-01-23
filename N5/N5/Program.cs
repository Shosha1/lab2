using System;
using System.Collections.Generic;

namespace N5
{
    class Program
    {

        static List<int> LstInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        static Random R = new Random(DateTime.Now.Millisecond);

        static void NextRoundPos(int n)
        {
            if (n == 0) return;
            else
            {
                int now = R.Next(n);
                Console.WriteLine(string.Format("[{0},{1}]", n, LstInt[now]));
                LstInt.RemoveAt(now);
                NextRoundPos(n - 1);
            }
        }

        static void Main(string[] args)
        {
            NextRoundPos(8);
        }
    }
}