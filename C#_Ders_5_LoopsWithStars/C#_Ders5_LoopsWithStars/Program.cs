using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ders5_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 2; j++)
            //    {
            //        Console.WriteLine("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //        Console.Write("*");

            //}


            //Console.Read();
            #endregion


            #region Dik üçgen yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}


            //Console.Read();
            #endregion

            #region Tersten dik üçgen yıldız oluşturma

            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}


            //Console.Read();
            #endregion

            #region Yarım elmas oluşturma

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i;  j++)
            //    {
            //         Console.Write("*");

            //    }
            //    Console.WriteLine();

            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}   


            #endregion
            //    Console.Read();

            #region Baklava dilimi
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            //    for (int i = n - 1; i >= 1; i--)
            //    {   
            //        for (int j = n - 1; j > 0; j--)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int k = 1; k <= 2 * i - 1; k++)
            //        {
            //            Console.Write("*");

            //        }
            //        Console.WriteLine();



            #endregion

            #region Piramit 
            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters piramit 
            int n = 5;

            for (int i = n; i >= 1; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();

         
        }
    }
}

