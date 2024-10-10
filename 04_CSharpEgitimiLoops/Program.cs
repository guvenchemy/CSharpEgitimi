using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_CSharpEgitimiLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler
            #region For Döngüsü
            //int i;
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region For Döngüleri ile Karar Yapıları

            //for (int i=1; i <= 12 ; i++) {
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + " Çift Sayıdır");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + " Tek Sayıdır");
            //    }
            //}

            #endregion

            #region ornekbakterisorusu
            //int bacterium = 1;
            //for (int i= 1; i <=24 ; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saatte bakteri sayısı: " + bacterium);
            //}
            #endregion

            #region While Döngüsü
            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i+". Merhaba döngüler");
            //    i++;
            //}



            #endregion

            #region orneksınavsorusu
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını bulan programı yazınız.
            Console.WriteLine("3 basamaklı bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones,tens, hundreds , sum;

            hundreds = number / 100;
            tens = (number % 100) / 10;
            ones = number % 10;
            
            Console.WriteLine(hundreds+ "--" +tens+ "--" +ones);
            sum = hundreds + tens + ones;
            Console.WriteLine("Girilen sayının basamakları toplamı: " + sum);


            #endregion


            Console.Read();
        }
    }
}
