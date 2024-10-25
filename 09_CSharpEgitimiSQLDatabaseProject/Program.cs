using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CSharpEgitimiSQLDatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("***** C# Veritabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1. Kategoriler");
            Console.WriteLine("2. Ürünler");
            Console.WriteLine("3. Siparişler");
            Console.WriteLine("4. Çıkış yap");
            Console.Write("Lütfen bir işlem seçiniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CQTO8CO;initial Catalog=CSharpEgitimiDB;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach(DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString()+" ");
                }
                Console.WriteLine();
            }

            connection.Close();


            Console.Read();
        }
    }
}
