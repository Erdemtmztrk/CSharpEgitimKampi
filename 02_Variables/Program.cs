using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            ////double number;

            ////number = 4.85;

            ////Console.WriteLine(number);

            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();

            //double applePrice, tomatoPrice, orangePrice, strawberryPrice, potatoPrice;

            //applePrice = 4.18;
            //tomatoPrice = 5.56;
            //orangePrice = 2.11;
            //strawberryPrice = 45;
            //potatoPrice = 15.48;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL ");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL ");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL ");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL ");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL ");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, tomatoGram, orangeGram, strawberryGram , potatoGram;

            //appleGram = 1.245;
            //tomatoGram = 2.5;
            //orangeGram = 0.75;
            //strawberryGram = 4.859;
            //potatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma / " + "Kilo Fiyatı: " + applePrice + " TL / " + 
            //    "Alınan Miktar: " + appleGram + " kg / " + "Ödenecek Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates / " + "Kilo Fiyatı: " + tomatoPrice + " TL / " +
            //    "Alınan Miktar: " + tomatoGram + " kg / " + "Ödenecek Tutar: " + tomatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal / " + "Kilo Fiyatı: " + orangePrice + " TL / " +
            //    "Alınan Miktar: " + orangeGram + " kg / " + "Ödenecek Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek / " + "Kilo Fiyatı: " + strawberryPrice + " TL / " +
            //    "Alınan Miktar: " + strawberryGram + " kg / " + "Ödenecek Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates / " + "Kilo Fiyatı: " + potatoPrice + " TL / " +
            //    "Alınan Miktar: " + potatoGram + " kg / " + "Ödenecek Tutar: " + potatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + tomatoTotalPrice + strawberryTotalPrice +
            //    orangeTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL ");



            #endregion

            #region Char Değişkenler

            //char formatı tek tırnaktır ''

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("CSharp Hava Yolları Yolcu Bilgisi");

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, 
            //    passengerAge, passengerIDNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcunun Yaşı: ");
            //passengerAge= Console.ReadLine();

            //Console.Write("TC No: ");
            //passengerIDNumber = Console.ReadLine();



            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yaşadığı İlçe/İl: " + passengerDistrict + " / " + passengerCity);
            //Console.WriteLine("Yaş: " + passengerAge);
            //Console.WriteLine("TC No: " + passengerIDNumber);
            //Console.WriteLine("--------------------");

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            ////     C# klavyeden girilen değerleri en başta hep string kabul eder biz int olarak almak
            ////  istediğimiz için stringi inte çeviren int.Parse metodunu kullanıyoruz.
            ////  Parse dönüştürmek için kullanılan bi metod

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //Console.WriteLine();

            //int totalShoesPrice, totalComputerPrice, totalChairPrice, totalTvPrice;

            //totalShoesPrice = shoesPrice * shoesCount;
            //totalComputerPrice = computerPrice * computerCount; 
            //totalChairPrice = chairPrice * chairCount;
            //totalTvPrice = tvPrice * tvCount;

            //int totalPrice = totalShoesPrice + totalComputerPrice + totalChairPrice + totalTvPrice; 

            //Console.WriteLine("Ayakkabıların toplam fiyatı : " + totalShoesPrice);
            //Console.WriteLine("Bilgisayarların toplam fiyatı : " + totalComputerPrice);
            //Console.WriteLine("Sandalyelerin toplam fiyatı : " + totalChairPrice);
            //Console.WriteLine("Televizyonun toplam fiyatı : " + totalTvPrice);

            //Console.WriteLine("----------------------");

            //Console.WriteLine("Ödenecek Toplam Tutar: " + totalPrice + " TL " );


            #endregion

            #region Klavyeden Double Değişken Girişleri

            //double exam1, exam2, exam3, exam4;

            //Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 4. sınav notunuzu giriniz: ");
            //exam4 = double.Parse(Console.ReadLine());

            //double average = (exam1 + exam2 + exam3 + exam4) / 4.0;
            //Console.WriteLine("Ortalamanız: " + average);





            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());
            //char'a çevirdiği için tek harfli bişi olması lazım girdinin yoksa hata verir
            if(gender == 'e')
            {
                string man = "erkek";
                Console.WriteLine("Seçtiğiniz Cinsiyet : " + man);
            }
            






            #endregion


            Console.Read();


        }

    }
}
