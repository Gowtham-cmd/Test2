using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            countApplesAndOranges(7, 11, 5, 15, new List<int>() { -2, 2, 1 }, new List<int>() { 5, -6 });
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCount = 0;
            int orangesCount = 0;
            for(int i = 0;i<apples.Count;i++)
            {
                int val = apples[i] + a;
                if (val >= s && val <= t)
                {
                    ++applesCount;
                }
            }
            for (int i = 0; i < oranges.Count; i++)
            {
                int val = oranges[i] + b;
                if (val >= s && val <= t)
                {
                    ++orangesCount;
                }
            }
        }

    }
}
