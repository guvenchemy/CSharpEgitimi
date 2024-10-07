using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CSharpEgitimiMakingDesicions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "ab12")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}



            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı... İyi günler dileriz...");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi ...");
            //}


            //int number;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //number  = int.Parse(Console.ReadLine());

            //if (number > 0)
            //{
            //    Console.WriteLine("Sayı pozitif");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("Sayı negatif");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı sıfır");
            //}


            //int exam1, exam2, exam3, average;
            //string result;
            //Console.Write("1. sınav notunu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sınav notunu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. sınav notunu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalama: " + average);
            //Console.WriteLine();

            //if (exam1 < 0 | exam1 > 100 | exam2 < 0 | exam2 > 100 | exam3 < 0 | exam3 > 100)
            //{
            //    result = "Hatalı not girişi";
            //}
            //else if (average > 0 & average <=49) // 0-50
            //{
            //    result = "Kaldınız";
            //}
            //else if (average > 49 & average <= 69) // 51-70
            //{
            //    result = "Geçtiniz";
            //}
            //else if (average > 69 & average <= 84) // 71-85
            //{
            //    result = "İyi";
            //}
            //else if (average > 84 & average <= 100) // 86-100
            //{
            //    result = "Çok İyi";
            //}
            //else
            //{
            //    result = "Hatalı not girişi";
            //}

            //Console.WriteLine("Durum: " + result);
            #endregion

            #region Mod işlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            #endregion

            #region ornekproje

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Sarımsak Kenarlı Pizza");
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //else if (menuItem == "4")s
            //{
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçcecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İçcecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}


            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Baklava");
            //    Console.WriteLine("2-San Sebastian");
            //    Console.WriteLine("3-Triliçe");
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber= int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş yaptınız");
            //        break;
            //}

            #endregion


            #region Switch Case HesapMakinesiOrnek
            
            //int number1, number2, result;
            //Console.Write("1. Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("İşlemi giriniz (+,-,*,/): ");
            //char operation = char.Parse(Console.ReadLine());
            //switch (operation)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş yaptınız");
            //        break;
            //}








            #endregion


            Console.Read();
        }
    }
}
