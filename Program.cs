using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc zad = new Calc();
            bool end = false;

            while (!end)
            {

                Console.Write("Ender first number:");
                zad.num1 = double.Parse(Console.ReadLine());
                Console.Write("Ender second number :");
                zad.num2 = double.Parse(Console.ReadLine());
                Console.Write("Ender operation :");
                zad.oper = char.Parse(Console.ReadLine());
               // zad.getResult(zad.num1, zad.num2, zad.oper);
                Console.WriteLine("result: {0}", zad.getResult(zad.num1, zad.num2, zad.oper));
                if (Console.ReadLine() == "end") end = true;


               


            }
        }
    }
}
