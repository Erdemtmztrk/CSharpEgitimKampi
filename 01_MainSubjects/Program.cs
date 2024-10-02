using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            /*Console.WriteLine("Selams");
            Console.Write("Hello World");*/

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion


            #region Değişkenler

            //string name;
            //name = "Erdem";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerEmail = "deneme@gmail.com";
            //customerPhone = "+90 513 518 45 46";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Reservation Card *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("Phone: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Address: " + district + "/" + city);
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine();


            //customerName = "Erdem";
            //customerSurname = "Temiztürk";
            //customerEmail = "fbg@gmail.com";
            //customerPhone = "+90 513 519 10 10";
            //district = "Bayraklı";
            //city = "İzmir";

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("Phone: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Address: " + district + "/" + city);
            //Console.WriteLine("-----------------------------");

            #endregion-+


            #region Int değişkenler

            //int 
            //int number = 42;
            //Console.WriteLine(number);  

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("-----Kola: " + cokePrice + " TL ");
            Console.WriteLine("-----Su: " + waterPrice + " TL ");
            Console.WriteLine("-----Patates: " + friesPrice + " TL ");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            
            
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount; 
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;
            
            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;    
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("---------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Patates Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("---------------------");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalWaterPrice
                + totalFriesPrice + totalCokePrice + totalLemonadePrice;

            Console.WriteLine("TOPLAM TUTAR : * " + totalPrice + "TL *");


            #endregion


            Console.Read();

        }
    }
}



//Yazdırma Komutları