using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BTKacademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strings ve Date

            #region cırt
            //var xf = 1;
            //Console.WriteLine(xf+2);

            //string msj = "Erdem Temiztürk abc";
            //var a = msj.Trim(); 
            //Console.WriteLine(a);

            //int x = msj.Length;

            //Console.WriteLine(a.Length);

            //var b = msj.Split()[1];
            //Console.WriteLine(b);

            //var y = msj.Substring(3, 2);
            //Console.WriteLine(y);
            #endregion

            #region 4.3_Uygulama: Strings

            /*
            string kursAdi = ".NET 7 ile C# Programlama Dili";

            //1- Kaç karaktere sahiptir?
            var karakterSayisi = kursAdi.Length;
            Console.WriteLine(karakterSayisi); //30

            //2- Hepsini küçük harf yapınız.
            var kucukHarf = kursAdi.ToLower();
            Console.WriteLine(kucukHarf);

            //3- '.' ile mi başlıyor?
            var nokta = kursAdi.StartsWith(".");
            Console.WriteLine("string . ile başlıyor: " + nokta);

            //4- C# bilgisi hangi konumda bulunmaktadır?
            var konum = kursAdi.IndexOf("C#");
            Console.WriteLine("konum: " + konum);

            //5-String 'C#' bilgisini içeriyor mu?
            var iceriyorMu = kursAdi.Contains("Cx");
            Console.WriteLine(iceriyorMu);

            //6- 'Dili' kelimesi yerine 'Dersleri' yazınız. (replace)
            var guncellenenString = kursAdi.Replace("Dili","Dersleri");
            Console.WriteLine(guncellenenString);
            */

            #endregion

            #region 4.4_DateTime

            //var simdi = DateTime.Now;

            //Console.WriteLine(simdi);
            //Console.WriteLine(simdi.Year);
            //Console.WriteLine(simdi.Minute);

            //DateTime dt = new DateTime(2018, 6, 10);
            //DateTime dt2 = dt.AddYears(1);  //önceki obje kalıcı olarak değiştirilemediği için
            //                                //yeni obje oluşturulup bilgiler onun üstüne aktarılır
            //Console.WriteLine(dt);
            //Console.WriteLine(dt2);
            //Console.WriteLine(dt2.Year);


            //var fark = simdi - dt;
            //Console.WriteLine(fark.TotalDays + " gün fark var");
            //Console.WriteLine(fark);

            #endregion

            //Diziler

            #region 5.2_Dizi Tanımlama

            //string kurum = "BTK AKADEMİ";
            //var x = kurum.IndexOf('A');
            //Console.WriteLine(x);

            //***************************

            //string[] isimler = new string[5];
            //isimler[0] = "Ahmet";
            //isimler[1] = "Ali";
            //isimler[2] = "Canan";
            //isimler[3] = "Çınar";
            //isimler[4] = "Esra";


            //int[] numaralar = { 100, 200, 300, 400, 500 };

            //Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");


            #endregion

            #region 5.3_Dizi Metotları

            //string[] sehirler = { "zonguldak", "rize", "kocaeli" };

            //sehirler[0] = "sakarya";
            //Console.WriteLine(sehirler[0]);

            ////alternatifi nedir

            //sehirler.SetValue("adana", 1);
            //Console.WriteLine(sehirler[1]);

            //Console.WriteLine(sehirler.GetValue(1));
            //Console.WriteLine(sehirler.Length);
            //Console.WriteLine(Array.IndexOf(sehirler, "kocaeli"));

            //Array.Sort(sehirler);

            //Console.WriteLine(string.Join(",", sehirler)); //bunun yerine for döngüsüyle de bastırabilirsin tek tek
            ////veya tek tek GetValue yazabilirdik

            //Array.Reverse(sehirler); // ters çevirir

            //Array.Clear(sehirler, 0, 1); // 0. indexten itibaren 1 tane eleman sil demek, silinen yer null değer alır
            //Console.WriteLine(sehirler[0]); // artık sehirler[0] ==> null            #endregion
            //Console.WriteLine(sehirler[1]);
            //Console.WriteLine(sehirler[2]);

            //int[] plakalar = { 67, 54, 41 };
            //Console.WriteLine(plakalar.GetValue(1));
            //Array.Clear(plakalar, 0, plakalar.Length);  //hepsini tek seferde siler
            //Console.WriteLine(plakalar[0] + "," + plakalar[1] + "," + plakalar[2]);

            #endregion

            #region 5.5_Uygulama: Diziler

            //var students = new string[3];
            //double[] notes = new double[3];

            //Console.Write("1. Öğrenci Adı : ");
            //students[0] = Console.ReadLine();

            //Console.Write("1. Öğrenci Notu : ");
            //notes[0] = double.Parse(Console.ReadLine());

            //Console.Write("2. Öğrenci Adı : ");
            //students[1] = Console.ReadLine();

            //Console.Write("2. Öğrenci Notu : ");
            //notes[1] = double.Parse(Console.ReadLine());

            //Console.Write("3. Öğrenci Adı : ");
            //students[2] = Console.ReadLine();

            //Console.Write("3. Öğrenci Notu : ");
            //notes[2] = double.Parse(Console.ReadLine());

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(students[i] + " isimli öğrencinin notu: " +
            //         notes[i]);
            //}

            //double ogrSayisi = students.Length;
            //Console.WriteLine("Sınıfta " + ogrSayisi + " öğrenci var.");

            //double avg = (notes[0] + notes[1] + notes[2]) / ogrSayisi;

            //Console.WriteLine("Sınıf Ortalaması : " + avg);

            #endregion

            #region 5.6_Çok Boyutlu Diziler

            //string[] students = { "ali", "ahmet", "canan" };

            //double[,] notes = new double[3, 3];

            ////ali
            //notes[0, 0] = 50;
            //notes[0, 1] = 60;
            //notes[0, 2] = 70;
            //double avg1 = (notes[0, 0] + notes[0, 1] + notes[0, 2]) / 3.0;

            ////ahmet
            //notes[1, 0] = 60;
            //notes[1, 1] = 80;
            //notes[1, 2] = 90;
            //double avg2 = (notes[1, 0] + notes[1, 1] + notes[1, 2]) / 3.0;

            ////canan
            //notes[2, 0] = 50;
            //notes[2, 1] = 70;
            //notes[2, 2] = 30;
            //double avg3 = (notes[2, 0] + notes[2, 1] + notes[2, 2]) / 3.0 ;


            //Console.WriteLine($"{students[0]} isimli öğrencinin not ortalaması: {avg1}");
            //Console.WriteLine($"{students[1]} isimli öğrencinin not ortalaması: {avg2}");
            //Console.WriteLine($"{students[2]} isimli öğrencinin not ortalaması: {avg3}");

            #endregion

            #region 8.3_Uygulama: For Döngüsü

            //int total = 0;

            //for (int i = 0; i <= 100; i++)
            //{
            //    total += i;

            //}
            //Console.WriteLine(total);


            //***********************************

            //Console.Write("Başlangıç değeri giriniz: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Bitiş değeri giriniz: ");
            //int finish = int.Parse(Console.ReadLine());

            //int toplam = 0;

            //for (int i = start; i <= finish; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);




            #endregion

            #region 8.4_While Döngüsü

            //var secim = "e";
            //var sayac = 1;
            //var toplam = 0;

            //while (secim == "e")
            //{
            //    Console.Write($"{sayac}. sayı: ");
            //    toplam += int.Parse(Console.ReadLine());

            //    Console.Write("devam etmek istiyor musunuz? (e/h)");
            //    secim = Console.ReadLine();
            //    sayac++;
            //}

            //Console.WriteLine($"{sayac-1} adet sayının toplamı: {toplam}");

            #endregion




            Console.WriteLine("doğum yılı: ");
            int yil = Convert.ToInt32(Console.ReadLine());
            var yas = DateTime.Now.Year - yil;
            Console.WriteLine(yas);


            Console.Read();
        }
    }
}
