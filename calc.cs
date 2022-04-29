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

        //public char Oper
        //{
        //    get { return oper; }
        //    set { oper = value; }
        //}

        //public double Num2
        //{
        //    get { return num2; }
        //    set { num2 = value; }
        //}


        //public double Num1      
        //{
        //    get { return num1; }
        //    set { num1 = value; }
        //}

        //public calc(double num1, double num2, char oper)
        //{
        //    this.Num1 = num1;
        //    this.Num2 = num2;
        //    this.oper = Oper;
        //}



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
