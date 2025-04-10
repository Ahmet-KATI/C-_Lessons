using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ders_3_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region If Else

            //Console.Write("Lütfen bir şifre girin: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "Ahmet")
            //{
            //    Console.WriteLine("Şifre Doğru ");
            //}
            //else {
            //    Console.WriteLine("Şifre Yanlış ");

            //    Console.Read();


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Girdiğiniz veriler doğru ");
            //}
            //else {
            //    Console.WriteLine("Girdiğiniz veriler yanlış");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}



            //Console.Write("Lutfen kullanicı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{ 
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz");
            // }
            //    Console.Read();
            #endregion
            #region Mod İşlemleri

            //int number;

            //Console.Write("Sayi girin: ");
            //number = int.Parse(Console.ReadLine());
            //int result = number % 5;
            //Console.WriteLine("Girdiğiniz sayidan kalan= "+result);

            //Console.Read();
            #endregion

            #region Örnek1 

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 't' | team == 'T')
            //{ 
            //    Console.Write("Trabzonspor");
            //}


            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            // }

            //Console.Read();
            #endregion

            #region Örnek2 
            //Console.WriteLine(" ******Restoran ****** ");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-İçecekler");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menüyü seçin: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //Console.WriteLine();
            //Console.WriteLine(" ****ANA YEMEKLER****");
            //Console.WriteLine();
            //Console.WriteLine("1-Kori Soslu Tavuk");
            //Console.WriteLine("2-Kızartma Tabağı");
            //Console.WriteLine("3-Fasulye Pilav");
            //Console.WriteLine("4-Firinda Somon");
            //Console.WriteLine("5-Patlican Musakka");
            //Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(" ****ÇORBALAR****");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek çorbası");
            //    Console.WriteLine("2-Yayla çorbası");
            //    Console.WriteLine("3-Ezogelin ");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(" ****İÇECEKLER****");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Soğuk çay");
            //    Console.WriteLine("4-Şerber");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(" ****TATLILAR****");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kemalpaşa");
            //    Console.WriteLine("2-Baklava");
            //    Console.WriteLine("3-Şekerpare");
            //    Console.WriteLine();
            //}
            //Console.Read();
            #endregion
            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak");break;    
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    default: Console.Write("Hatalı veri girişi yaptınız."); break;
            //}



            //Console.Read();
            #endregion

            #region Switch Case Hesap Makinesi
            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch(symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;

                case '*':
                result = number1 * number2;
                    Console.WriteLine("Çarpım: "+ result);
                break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;

                  
            }



            Console.Read();
            #endregion
        }
    }
}

