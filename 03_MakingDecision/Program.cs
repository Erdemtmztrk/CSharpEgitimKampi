using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If ve Else

            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}



            //-----------------------------------------



            //string capital, country;

            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{

            //    Console.WriteLine("Veriler doğrulandı.");

            //}

            //else {

            //    Console.WriteLine("Hatalı Bilgi!!!");

            //}


            //-----------------------------------------


            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{

            //    Console.WriteLine("Sayı doğru.");

            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}


            //-----------------------------------------


            //int exam1, exam2, exam3;
            //string result;
            //result = "Hata!";
            ////else yazmak yerine baştan bi değer de atayabiliriz null durumuna düşmemesi için.

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());


            //double average = (exam1 + exam2 + exam3) / 3.0;
            //Console.WriteLine("Sınavların ortalaması: " + average);


            //if (average >= 80 & average < 100)
            //{
            //    result = "Çok iyi";
            //}
            //if (average >= 50 & average < 80)
            //{
            //    result = "Orta halli";
            //}
            //if (average >= 0 & average < 50)
            //{
            //    result = "Vasat";
            //}
            ////else
            ////{
            ////    result = "Geçerli bir değer giriniz.";
            ////}

            //Console.WriteLine(result);


            //-----------------------------------------


            //string city;
            //Console.Write("Şehir yazınız : ");
            //city = Console.ReadLine();

            //if (city == "izmir" | city == "ankara" | city == "istanbul")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}


            //-----------------------------------------


            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Admin harici giriş yapılamaz!!");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}




            #endregion

            #region Mod işlemleri


            // bölümünden kalan sayı

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //****************************************


            //Console.Write("1. Sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());   

            //Console.Write("2. Sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan sayı: " + result);


            //****************************************


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("ÇİFT");
            //}
            //else
            //{
            //    Console.Write("TEK");
            //}

            #endregion

            #region Char Değişkenler ile karar yapıları

            //char team;

            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            #endregion

            #region Örnek Proje Uygulamaları (Else if)

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Tavuk");
            //    Console.WriteLine("2-Et");
            //    Console.WriteLine("3-Balık");
            //    Console.WriteLine("4-Kuru fasulye");
            //    Console.WriteLine("5-Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("3-Domates");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Fanta");
            //    Console.WriteLine("4-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("-----İçecekler-----");
            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kemalpaşa");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //}
            //else
            //{
            //    Console.WriteLine("Geçerli bir değer giriniz!!!");
            //}


            #endregion

            #region Switch Case

            //Console.Write("Kaçıncı ayda olduğumuzu giriniz : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch yazıp 2 kere taba basınca kısayol

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("mart"); break;
            //    case 4: Console.WriteLine("nisan"); break;
            //    case 5: Console.WriteLine("mayıs"); break;
            //    case 6: Console.WriteLine("haziran"); break;
            //    case 7: Console.WriteLine("temmuz"); break;
            //    case 8: Console.WriteLine("ağustos"); break;
            //    case 9: Console.WriteLine("eylül"); break;
            //    case 10: Console.WriteLine("ekim"); break;
            //    case 11: Console.WriteLine("kasım"); break;
            //    case 12: Console.WriteLine("aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi!!"); break;
            //}



            //*******************************************************



            //int number1, number2, result;
            //char symbol;

            //Console.Write("Birinci Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz : ");
            //symbol = char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuç : " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç : " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç : " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuç : " + result);
            //        break;


            //    default:
            //        Console.WriteLine("Geçerli bir sembol giriniz!!!");
            //        break;

            //}


            #endregion


            Console.Read();



        }
    }
}
