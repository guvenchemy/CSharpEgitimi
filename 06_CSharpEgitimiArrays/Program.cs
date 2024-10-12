using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CSharpEgitimiArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri
            //2,4,6,8
            //sari,kirmii,turuncu,mavi
            //adana,ankara,diyarbakir,istanbul
            //DegiskenTipi[] diziAdi = new DegiskenTipi[ElemanSayisi];
            //string[] colors = new string[4];
            //colors[0] = "sari";
            //colors[1] = "kirmizi";
            //colors[2] = "turuncu";
            //colors[3] = "mavi";
            //Console.WriteLine(colors[0]);

            //string[] cities = new string[5] { "adana", "ankara", "diyarbakir", "istanbul","budapeşte" };
            //Console.WriteLine(cities[3]);
            //int[] numbers = new int[6];
            //numbers[0] = 2;
            //numbers[1] = 4;
            //numbers[2] = 6;
            //numbers[3] = 8;
            //numbers[4] = 10;
            //numbers[5] = 12;
            //Console.WriteLine(numbers[5]);
            //string[] cities = { "adana", "ankara", "diyarbakir", "istanbul", "budapeşte" };
            //Console.WriteLine(cities[4]);
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //int[] numbers = { 2, 4, 6, 8, 10, 12 ,235,34,66,78,97,96,46,93,63,56,78,21,23};
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' ,'*','/','_','?'};
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //        Console.WriteLine(symbols[i]); 
            //}

            //int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,532,4634,57,45,65,234,6764,5674,9769,234,122,852,722,345};

            //int maxNumber = myArray[0];

            //for (int i = 0; i< myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine("En büyük sayı: " + maxNumber);


            //string[] persons = { "ali", "veli", "ayse", "fatma", "mehmet", "deniz" };
            //Console.WriteLine(persons.Length);
            //int[] numbers = { 2, 4, 6, 8, 10, 12, 235, 34, 66, 78, 97, 96, 46, 93, 63, 56, 78, 21, 23 };

            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} 
            //int[] numbers = { 2, 4, 6, 8, 10, 12, 235, 34, 66, 78, 97, 96, 46, 93, 63, 56, 78, 21, 23 };

            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);

            //}
            #endregion



            #region ArrayMetotlari
            //string[] customers = { "ali", "veli", "ayse", "fatma", "mehmet", "deniz" };
            //int index = Array.IndexOf(customers, "ayse");
            //Console.WriteLine(index);

            //int[] numbers = { 2, 4, 6, 8, 10, 12, 235, 34, 66, 78, 97, 96, 46, 93, 63, 56, 78, 21, 23 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());



            #endregion


            #region KullanicidanDegerAlma
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. şehir adını giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            #endregion


            Console.Read();
        }
    }
}
