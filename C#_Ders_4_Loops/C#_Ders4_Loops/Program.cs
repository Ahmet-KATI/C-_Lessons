using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ders4_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For döngüsü 

            //örn1
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine("AK");
            //}
            //Console.Read();
            #endregion
            // örn2
            //for (int i = 4; i <= 50; i+=3 )
            //{
            //    Console.WriteLine(i);
            //}

            //örn3
            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("D");
            //}

            #region Döngülerin karar yapıları ile kullanımı

            // örn4
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            // örn 5 

            //int totalvalue = 0;
            //for (int i = 1; i <= 50 ; i++)
            //{
            //    if(i % 4 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("__________");
            //Console.WriteLine(totalvalue);
            //Console.WriteLine("__________");

            // örn7 1 ile 50  arasında 7'ye bölünen kaç tane sayı var
            //int sayac = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sayac++;

            //    }
            //}
            //Console.WriteLine(sayac);   


            //örn 8
            // bir bakteri örneği her saatin sonunde kendini 2 ye bölerek çoğalıyor
            // 1-2-4-8-16-32-64, 24 saatin sonunda ortamda kaç bakteri olacağını hesaplayan 
            //programı yazınız

            //int sayac = 1;
            //for (int saat = 1; saat <= 24; saat++)
            //{
            //    sayac = sayac * 2;
            //   Console.WriteLine(saat + ".Saatin sonunda: "+sayac);
            //}

            //    Console.Read();
            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 24)
            //{
            //    Console.WriteLine("D");
            //    i++;
            //}

            // örn 1 ile 10 arasında 3'e tam bölünen sayıları bul 
            //int i = 1;
            //int sayac = 0;
            //while (i <= 10 )
            //{
            //    if ( i % 3 == 0)
            //    {
            //        sayac++;
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //Console.WriteLine("Bu kadar sayı bölünüyor: " + sayac);

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum); 

            //Console.Read();
            #endregion

            #region Örnek Sınav Sorusu 
            // Örn 
            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını  hesaplayan kod

            int birler, onlar, yüzler;
            int sum;
            int sayi;

            Console.Write("3 basamaklı sayı giriniz: ");
            sayi = int.Parse(Console.ReadLine());

            birler = sayi % 10;
            onlar = (sayi % 100) / 10;
            yüzler = sayi / 100;

            sum = birler + onlar + yüzler;
            Console.WriteLine("Basamakları toplamı: " + sum);
            Console.WriteLine(birler + "-" + onlar + "-" + yüzler);
            Console.Read();
            #endregion  
        }

    }
}
