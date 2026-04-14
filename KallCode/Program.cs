using System.Linq;
using System;
using System.Linq.Expressions;

class Program
{

    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long res;
        if (n % 2 == 0)
        {
            res = n / 2;
            Console.WriteLine(res);
        }
        else
        {
            res = (n - 1) / 2 - n;
            res = -(n + 1) / 2;

            Console.WriteLine(res);
        } 
       
    }
}





