using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ders_6_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü [Eleman Sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Mor";
            //colors[1] = "Beyaz";
            //colors[2] = "Yeşil";
            //colors[3] = "Mavi";

            //Console.Write("Bu numaralı indeks rengi: "+colors[1]);
            //Console.Read();
            #endregion


            #region Dizideki Tüm Elemanları Listeleme 
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Mor" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            // dizi içindeki 3'e bölünen sayılar 
            //int[] numbers = { 4, 12, 456,156,845,369 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '^' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            ////en büyük sayıyı bulma
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //    Console.WriteLine("En büyük sayı: "+maxNumber);

            //dizi uzunluğu
            //string[] persons = { "Damla", "Ahmet", "Rümeyse", "Hasan" };
            //Console.WriteLine(persons.Length);

            //sıralama SORT
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //Array.Sort(myArray);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]); 
            //}


            // reverse ile tersten sıralama
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //Array.Reverse(myArray);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            #endregion
            #region Dizi Metotlar 

            //index
            //string[] persons = { "Damla", "Ahmet", "Rümeyse", "Hasan" };
            //int index = Array.IndexOf(persons, "Damla"); 
            //Console.WriteLine(index);


            // max ve min metotları 
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //Console.WriteLine("Dizinin en büyük sayısı: "+ myArray.Max() + " Dizinin en küçük sayısı:" + myArray.Min()); 

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for(int i = 0; i <cities.Length; i++) 
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);  


            #endregion


            #region Klavyeden Girilen Tek Sayıları Ayrı Çift Sayıları Ayrı Listeleme

                int[] numbers = new int[5]; 

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Lütfen {i + 1}. Numarayı Giriniz: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine()); 
                }

                Console.WriteLine("\nÇift Sayılar:");
            for (int i = 0; i < numbers.Length; i++)
            {
                    if (numbers[i] % 2 == 0)
                    {
                    Console.WriteLine(numbers[i]);
                    }
                }

                Console.WriteLine("\nTek Sayılar:");
            for (int i = 0; i < numbers.Length; i++)
            {
                    if (numbers[i] % 2 != 0)
                    {
                    Console.WriteLine(numbers[i]);
                    }
                }

                Console.ReadKey();
            }
        }
    }




#endregion

        
    

