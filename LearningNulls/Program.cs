using System;

namespace LearningNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = null; // "hello";
            var s2 = s ?? "default";

            int ?ss = null; // 1;
            int ss2 = ss ?? 2;

            Console.WriteLine(s2);
            Console.WriteLine(ss2);

        }
    }
}
