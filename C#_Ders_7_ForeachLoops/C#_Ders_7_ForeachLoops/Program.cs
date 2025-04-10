using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ders_7_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü 

            //1:Değişken türü
            //2:Değişken adı
            //3: İçinden, in
            //4: Liste, Koleksiyon, Dizi

            //string [] cities = { "trabzon", "adana", "batman", "van", "istanbul" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6 , 45 , 456, 123,98};
            //foreach (int x in numbers)
            //{
            //    Console.WriteLine(x);
            //}

            //örn1 çift sayıları bul

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 45, 456, 123, 98 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //örn2  toplama foreach ile
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 45, 456, 123, 98 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //string word = "Merhaba";
            //foreach (char x in word)
            //{
            //    Console.WriteLine(x);
            //}




            #endregion

            #region Örnek Sınav Sistemi
            Console.WriteLine("------------------------");
            Console.Write(" Sınıfınızda kaç öğrenci var? : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");

            //öğrenci notlarını ve ortalamalarını tanımlayacak dizileri oluşturacağız

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");

                studentNames[i] = Console.ReadLine();

                double TotalExamResult = 0;


                //öğrencilerin notlarının girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {studentNames[i]} adlı öğrencinin {j + 1}.sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    TotalExamResult += value; //notları toplamak
                }
                studentExamAvg[i] = TotalExamResult / 3;


                // ortalamaları ekrana yazma
                Console.WriteLine("------------------------");


                Console.WriteLine($" {studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                
                //öğrencilerin kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($" {studentNames[i]} adlı öğrenci dersten geçti!");
                }
                else
                {
                    Console.WriteLine($" {studentNames[i]} adlı öğrenci dersten kaldı :(");
                }
                Console.WriteLine("------------------------");


            }


            #endregion  
            Console.Read();

        }
    }
}
