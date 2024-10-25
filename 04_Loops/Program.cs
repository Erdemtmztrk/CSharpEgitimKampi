﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //For(x;y;z)
            //x: başlangıç değeri
            //y: bitiş değeri
            //z: artış azalış 

            // Kısayol : for yazıp iki kere taba bastığında döngüyü kurar

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //*********************************************

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //*********************************************

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //*********************************************

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Erdem");
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //*********************************************

            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //    Console.WriteLine(totalValue); // bu tüm işlem adımlarını gösterir
            //}

            //Console.WriteLine(totalValue); //bu sadece sonucu gösterir


            //*********************************************


            //20ye kadar olan Çift Sayıların Toplamı
            //int totalValue = 0;

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {

            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-----");
            //Console.WriteLine(totalValue);


            //*********************************************


            //int count = 0;

            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            //*********************************************


            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++) {

            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda Bakteri Sayısı: " + bacterium);

            //}


            #endregion

            #region While Döngüsü

            //while(şart)
            //{
            //işlemler
            //}


            //*********************************************


            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //*********************************************


            //1den 10a kadar 3e tam bölünen sayılar

            //int i = 1;

            //while (i<=10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }  
            //    i++;    
            //}


            //*********************************************


            //int sum = 0;
            //int i = 1;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Örnek Sınav Sorusu


            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.


            //Console.Write("3 basamaklı bir sayı giriniz: ");
            //int num = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = num % 10;
            //tens = (num % 100) / 10;
            //hundreds = num / 100;

            //Console.WriteLine(hundreds + "-" + tens + "-" + ones);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);



            #endregion

            Console.Read();






        }
    }
}