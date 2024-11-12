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
            float Number1 = float.Parse(Console.ReadLine());
            float Number2 = float.Parse(Console.ReadLine());
            float Number3 = float.Parse(Console.ReadLine());
            if (Number1 > Number2 &&  Number1>Number3)
            {
                if (Number2 > Number3)
                {
                    Console.WriteLine("");
                    Console.WriteLine(Number1);
                    Console.WriteLine(Number2);
                    Console.WriteLine(Number3);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine(Number1);
                    Console.WriteLine(Number3);
                    Console.WriteLine(Number2);
                }
            }
            if (Number3 > Number1 && Number3 > Number2)
            {
                if (Number1 > Number2)
                {
                    Console.WriteLine("");
                    Console.WriteLine(Number3);
                    Console.WriteLine(Number1);
                    Console.WriteLine(Number2);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine(Number3);
                    Console.WriteLine(Number2);
                    Console.WriteLine(Number1);
                }
            }
            if (Number2 > Number1 && Number2 > Number3)
            {
                if (Number1 > Number3)
                {
                    Console.WriteLine("");
                    Console.WriteLine(Number2);
                    Console.WriteLine(Number1);
                    Console.WriteLine(Number3);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine(Number2);
                    Console.WriteLine(Number3);
                    Console.WriteLine(Number1);
                }
            }
         

         
           

        }
    }
}
