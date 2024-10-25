using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Alt alta ve yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <=10 ; i++)
            //{
            //    Console.WriteLine("*");
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region 10x10luk bir yıldız oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int x = 0; x < 10; x++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine("");

            //}

            #endregion

            #region Dik üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yarım Baklava Dilimi

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            //Console.Write("Boyut değeri giriniz: ");
            //int size = int.Parse(Console.ReadLine());

            ////üst kısım

            //for (int i = 1; i <= size; i++)
            //{
            //    for (int k = size; k >= i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            ////alt kısım

            //for (int i = size - 1; i >= 1; i--)
            //{
            //    for (int k = size; k >= i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}




            #endregion

            #region Piramit

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluklar için
            //    for (int j = n; j >= i ; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar için
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //DÜZ PİRAMİT YAZMAYA ÇALIŞ KENDİ KENDİNE

            #endregion

            


            Console.Read();



        }
    }
}
