using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tamrin 1

            //string Number1=Console.ReadLine();
            //float Number2=float.Parse(Number1);
            //if (Number2 % 2 == 0)
            //{
            //    Number2 = Number2 * 2;
            //}
            //else
            //{
            //    Number2 = Number2 / 2;
            //}
            //Console.WriteLine(Number2);
            //Console.ReadKey();

            //Tamrin 2

            //float Number1 = float.Parse(Console.ReadLine());
            //float Number2 = float.Parse(Console.ReadLine());
            //float Average=(Number1 + Number2)/2;
            //Console.WriteLine(Average);

            //Tamrin 3 
            Console.WriteLine("Enter number 1");
            float Number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            float Number2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            float Number3 = float.Parse(Console.ReadLine());
            float num1=0,num2=0,num3 = 0;

            
           if (Number1>=Number2 && Number1 >= Number3)
            {
                 num1 = Number1;
                if (Number2 >= Number3)
                {
                    num2 = Number2;
                    num3 = Number3;
                }
                else
                {
                    num2 = Number3;
                    num3 = Number2;

                }
            }
            if (Number2 >= Number1 && Number2 >= Number3)
            {
                num1 = Number2;
                if (Number1 >= Number3)
                {
                    num2 = Number1;
                    num3 = Number3;
                }
                else
                {
                    num2 = Number3;
                    num3 = Number1;

                }
            }
          
            if (Number3 >= Number1 && Number3 > Number2)
            {
                num1 = Number3;
                if (Number1 >= Number2)
                {
                    num2 = Number1;
                    num3 = Number2;
                }
                else
                {
                    num2 = Number2;
                    num3 = Number1;

                }
            }
            Console.WriteLine("");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();


        }
    }
}
