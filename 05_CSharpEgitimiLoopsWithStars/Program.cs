using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CSharpEgitimiLoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            //for(int i = 0; i <= 10; i++){

            //    Console.WriteLine("*");
            //}

            //for (int i = 0; i <= 10; i++)
            //{

            //    Console.Write("*");
            //}


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}
