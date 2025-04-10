using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Ders_8_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ahmet Katı");
            //    Console.WriteLine("Damla Ülkü");
            //    Console.WriteLine("Burak Aydoğdu");
            //    Console.WriteLine("Rıdvan Fırat Çınar");
            //}



            //CustomerList();

            //sum metodu
            //void sum ()
            //{
            //    int x = 2;
            //    int y = 4;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();




            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metodlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Ahmet Katı");


            // Müşteri Kartı
            //void CustomerCard(string name, string surName)
            //{
            // Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Ahmet", "Katı");
            //CustomerCard("Damla", "Ülkü");






            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metodlar


            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine("Cevabınız: "+result);
            //}
            //Sum(2, 4, 18);



            #endregion

            #region Geriye Değer Döndüren Metodlar 

            //string Customername()
            //{
            //    return "Ahmet Katı";
            //}
            //Customername();


            //string Customername()
            //{
            //    string name = "Ahmet";
            //    string surname = "Katı";

            //    return name + " " + surname;
            //}
            //Console.Write(Customername());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metodlar

            //string CountryCard(string CountryName, string capital, string CountryCode)
            //{
            //    string cardInfo = "Ülke: " + CountryName + "\n" + "Başkent: " + capital + "\n" + "Kodu: " + CountryCode;
            //    return cardInfo;
            //}
            //string a, b, c;

            //Console.Write("Ülke adını giriniz: ");
            //a = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //b = Console.ReadLine();

            //Console.Write("Ülke kodunu giriniz: ");
            //c = Console.ReadLine();

            //Console.WriteLine(CountryCard(a,b,c));







            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metodlar


            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(4, 24));
            //Console.WriteLine(Sum(4, 18));
            //Console.WriteLine(Sum(44, 360));
            //Console.WriteLine(Sum(14, 200));

            #endregion
            //Console.Read();



            #region Öğrenci notları hesaplama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student +" "+ "adlı öğrenci sınavı geçti" + " "+result ;
                }

                else
                {
                    return student + " " + "adlı öğrenci sınavdan kaldı" + " " + result;

                }


            }
            Console.WriteLine(ExamResult("Ahmet",100,90,100));
            Console.WriteLine(ExamResult("Damla",80,95,100));
            Console.WriteLine(ExamResult("Yakut",40,70,30));
            #endregion
            Console.Read();



        }
    }
}
