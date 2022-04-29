using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Calc zad = new Calc();
            bool end = false;

            while (!end)
            {
               
                Console.Write("Enter first number:");
                zad.num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second number :");
                zad.num2 = double.Parse(Console.ReadLine());
                Console.Write("Enter operation / + , * , -, / : ");
                zad.oper = char.Parse(Console.ReadLine());
              
                Console.WriteLine("result: {0:f2}", zad.getResult(zad.num1, zad.num2, zad.oper));
                Console.WriteLine("If you want to continue press Enter, to close the calculator press End");
                if (Console.ReadLine() == "End") end = true;


               


            }
        }
    }
}
