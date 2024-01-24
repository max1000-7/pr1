using System;
namespace Hello
{
    class Program
    {
        static void Main()
        {
            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y= ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine((Math.Sin(x)+ Math.Cos(y)/ Math.Cos(x) + Math.Sin(y))*Math.Tan(x*y));
      }
    }
}
