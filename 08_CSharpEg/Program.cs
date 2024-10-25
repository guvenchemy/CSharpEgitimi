using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CSharpEg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //() ile kapanıyorsa metotdur.
            // metotlar ikiye ayrılır: geriye değer döndüren ve döndürmeyen.
            // geriye değer döndürmeyen metotlar  void ile tanımlanır.

            //void CustomerList()
            //{
            //    Console.WriteLine("Güven Yılmaz");
            //    Console.WriteLine("Bekir Yılmaz");
            //    Console.WriteLine("İbrahim Yücel");
            //    Console.WriteLine("Hakan Beyler");
            //}
            //CustomerList(); //metot çağrısı

            //void Sum()
            //{
            //    int number1 = 5;
            //    int number2 = 10; 
            //    int result = number1 + number2;
            //    Console.WriteLine("Toplam: " + result);
            //}

            //Sum();



            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void Yazdir(string customerName)
            //{
            //    Console.WriteLine("Müşteri Adı: " + customerName);
            //}

            //Yazdir("Mehmet Yildirim");
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Güven Yılmaz";
            //}

            //CustomerName();

            #endregion

            Console.Read();
        }
    }
}
