using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Frist Number");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The End Number");
            int endnum = int.Parse(Console.ReadLine());
            Boolean f = true;
            for (int i = firstnum; i <= endnum; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        f = false;
                        break;
                    }
                    else
                    {
                        f = true;
                        continue;
                    }
                }
                if (f == true && i > 1)
                    Console.WriteLine(i);
            }
        }
    }
}