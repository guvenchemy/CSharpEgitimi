using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CSharpEgitimiVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.06;
            //Console.WriteLine(number);
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, potatoPrice,strawberryPrice,tomatoPrice;
            //applePrice = 14.52;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 5.25;
            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //double appleGram, orangeGram, potatoGram, strawberryGram, tomatoGram, totalGram;
            //appleGram = 1.245;
            //orangeGram = 1.574;
            //potatoGram = 2.501;
            //strawberryGram = 1.437;
            //tomatoGram = 1.029;
            //totalGram = appleGram + orangeGram + potatoGram + strawberryGram + tomatoGram;
            //double appleTotalPrice, orangeTotalPrice, potatoTotalPrice, strawberryTotalPrice, tomatoTotalPrice,totalPrice;
            //appleTotalPrice = applePrice * appleGram;
            //orangeTotalPrice = orangePrice * orangeGram;
            //potatoTotalPrice = potatoPrice * potatoGram;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //tomatoTotalPrice = tomatoPrice * tomatoGram;
            //totalPrice= appleTotalPrice + orangeTotalPrice + potatoTotalPrice + strawberryTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("---- Elma Toplam Fiyatı: " + appleTotalPrice + " TL, Elma Gramaj: " + appleGram);
            //Console.WriteLine("---- Portakal Toplam Fiyatı: " + orangeTotalPrice + " TL, Portakal Gramaj: " + orangeGram );
            //Console.WriteLine("---- Çilek Toplam Fiyatı: " + strawberryTotalPrice + " TL, Çilek Gramaj: " + strawberryGram);
            //Console.WriteLine("---- Patates Toplam Fiyatı: " + potatoTotalPrice + " TL, Patates Gramaj: " + potatoGram);
            //Console.WriteLine("---- Domates Toplam Fiyatı: " + tomatoTotalPrice + " TL, Domates Gramaj: " + tomatoGram);
            //Console.WriteLine();
            //Console.WriteLine("Toplam Fiyat:" + totalPrice + "TL, Toplam Gramaj: " + totalGram);
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("***** Fiyat Listesi *****");

            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri

            //Console.Write("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();
            //Console.Write("Yolcu İlçe: ");
            //passangerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Şehir: ");
            //passangerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passangerAge = Console.ReadLine();
            //Console.Write("Yolcu T.C. Kimlik Numarası: ");
            //passangerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Yolcu: " + passangerName + " " + passangerSurname + " " + passangerDistrict + "/" + passangerCity + " " + passangerAge + " " + passangerIdentityNumber);
            //Console.WriteLine("----------------------------------------------------");
            #endregion

            #region Klavyeden Girilen İnt Değişkenleri ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice,shoesCount, computerCount, chairCount, tvCount;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //Console.Write("Ayakkabı Adet: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Bilgisayar Adet: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Sandalye Adet: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Televizyon Adet: ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //int totalPrice = shoesCount * shoesPrice + computerPrice * computerCount + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");


            #endregion

            #region Klavyeden Girilen Double Değişkenleri ve Dönüşümler

            //double exam1, exam2, exam3, result;
            //Console.Write("1. Sınav Notu: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notu: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Ortalama: " + result);

            #endregion

            #region Klavyeden Girilen Char Değişkenleri ve Dönüşümler

            //char gender;
            //Console.Write("Cinsiyet (E/K): ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion

            Console.Read();
        }
    }
}
