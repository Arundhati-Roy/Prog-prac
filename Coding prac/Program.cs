using System;

namespace Coding_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            int emp_rate = 20;
            int emphrs;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == p)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            int empwage = emphrs * emp_rate;
            Console.WriteLine(empwage);

        }
    }

}
