using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CSharpEgitimiForeachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü
            //Foreach(1;2;3;+)
            //1:Değişken türü
            //2:Değişken adı
            //3: In
            //4: Liste,Koleksiyon, Dizi

            //string[] cities = { "Milano", "Paris", "London", "New York" }; //Dizi tanımlama
            //foreach (string city in cities) //Dizi içerisindeki her bir elemanı city değişkenine atar.
            //{
            //    Console.WriteLine(city);
            //}
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9,34535,682,56,5752,97,253,38,343,988,111,234,123,121,867 };
            //List<int> numbers = new List<int> 
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 34535, 682, 56, 5752, 97, 253, 38, 343, 988, 111, 234, 123, 121, 867 
            //};
            //Liste tanımlama



            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    }

            //string word = "Hello World";
            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}













            #endregion


            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("CSharp eğitimm kampı  sınav uygulamasına hoşgeldiniz.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            

            Console.WriteLine("---------------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");
            string[] studentNames = new string[studentCount];// studentCounttaki öğrenci sayısına göre dizi oluşturuldu.Öğrenci isimleri.
            double[] studentExamAvg = new double[studentCount];// studentCounttaki öğrenci sayısına göre dizi oluşturuldu.Öğrenci notları.

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin Adı: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her bir öğrencinin 3 sınav notunu alıyoruz.
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double examResult = double.Parse(Console.ReadLine());
                    totalExamResult += examResult;
                }
                studentExamAvg[i] = totalExamResult / 3;
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin sınav ortalaması: {studentExamAvg[i]}");
                // öğrencilerin geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci sınavı geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci sınavı geçemedi.");

                }

            }
            Console.WriteLine("---------------------------------------------");
                Console.Write("CSharp eğitimm kampı  sınav uygulaması iyi günler diler.");
            #endregion


            Console.Read();
        }
    }
}