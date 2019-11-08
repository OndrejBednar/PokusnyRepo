using System;

namespace _01ukol
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int step = 2;
            int count = 5;

            while (count > 0) 
            {
                start += step;
                count -= 1;
                Console.WriteLine(start);
            }
        }
    }
}
