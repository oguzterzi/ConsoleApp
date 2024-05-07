using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int Topla(int a = 0, int b = 0, int c = 0, int d = 0)
        {
            return a + b + c + d;
        }
        //static int[] Fib(int n)
        //{
        //    int[] d = new int[n];

        //    d[0] = d[1] = 1;

        //    for (int i = 2; i < n; i++)
        //    {
        //        d[i] = d[i - 1] + d[i - 2];
        //    }
        //    return d;
        //}
        //static int[] Yeni()
        //{
        //    int[] d = new int[3];
        //    d[0] = 1;
        //    d[1] = 4;
        //    d[2] = 9;
            
        //    return d;
        //}
        static void Main(string[] args)
        {
            //int[] a = Yeni();
            //int[] a = Fib(5);
            //foreach (int e in a)
            //{
            //    Console.WriteLine(e);
            //}
            Console.WriteLine(Topla());
            Console.ReadKey();
        }
    }
}
