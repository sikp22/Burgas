using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calc
    {
        public double num1;
        public double num2;
        public char oper;




         public  double getResult(double num1,double num2, char oper)
        {
             double result = double.NaN;
            switch (oper)
            {
                case '+':result = num1 + num2; break;
                case '*': result = num1 * num2; break;
                case '-': result = num1 - num2; break;
                case '/':
                    {
                        if (num2!=0)
                        {
                        result = num1 / num2;
                        }
                       
                    
                    }  break;

                default:
                    break;
            }
            return result;
        }


    }
}
