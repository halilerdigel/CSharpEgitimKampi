using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            /*
            Console.Write("Lütfen şifreyi giriniz: ");
            string password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şifre doğru.");
            }
            else
            {
                Console.WriteLine("Şifre yanlış.");
            }
            */


            /*
            string capital, country;
            Console.Write("Başkenti giriniz: ");
            capital = Console.ReadLine();
            Console.Write("Ülkeyi giriniz: ");
            country = Console.ReadLine();

            if (capital == "Ankara" & country == "Türkiye")
            {
                Console.WriteLine("Veriler doğrulandı");
            }
            else
            {
                Console.Write("Hatalı bilgi.");
            }
            
            */


            /*
            int number;
            Console.Write("Sayıyı giriniz.");
            number = int.Parse(Console.ReadLine());
            if (number == 5)
            {
                Console.WriteLine("Sayı doğru.");
            }
            else
            {
                Console.WriteLine("Sayı hatalı.");
            }
            */


            /*
            int exam1, exam2, exam3, average;

            string result = "Hata!";

            Console.Write("Sınav 1: ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("Sınav 2: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("Sınav 3: ");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine("Sınavların ortalaması: " +average);

            if (average > 0 & average <= 50)
            {
                result = "Sonuç vasat";
            }
            else if (average > 50 & average <= 70)
            {
                result = "Sonuç orta";
            }
            else if (average > 70 & average <= 84)
            {
                result = "Sonuç iyi";
            }
            else if (average > 84)
            {
                result = "Sonuç çok iyi";
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            }

            Console.WriteLine(result);
            */

            /*
            string city;
            Console.Write("Lütfen şehir ismi giriniz: ");

            city = Console.ReadLine();

            if (city == "Adana" | city == "Ankara" | city == "Bursa" | city=="Trabzon")
            {
                Console.WriteLine("Şehir mevcut.");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil.");
            }
            */


            /*
            Console.Write("Lütfen kullanıcı adını giriniz. ");
            string username =Console.ReadLine();
            if (username!="admin")
            {
                Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            }
            else
            {
                Console.WriteLine("Hoş geldiniz.");
            }
            */

            #endregion

            #region Mod İşlemleri

            /*
            int number;
            number = 26;
            int result = number % 5;
            Console.WriteLine(result);
            */


            /*
            Console.Write("Lütfen birinci sayıyı giriniz: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1%number2;

            Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);
            */


            /*
            Console.Write("Lütfen sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }
            */
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            /*
            char team;
            Console.Write("Lütfen takım sembolünü giriniz: ");
            team = char.Parse(Console.ReadLine());

            if(team == 'g' | team == 'G')
            {
                Console.WriteLine("Galatasaray!");
            }
            else if (team == 'f' | team == 'F')
            {
                Console.WriteLine("Şikebahçe.");
            }
            else if (team == 'b' | team == 'b')
            {
                Console.WriteLine("8taş.");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            }
            */

            #endregion

            #region Örnek Proje Uygulaması

            /*
            Console.WriteLine("****** C# EĞİTİM KAMPI RESTORAN ******");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            string menuItem;
            Console.Write("Detayını görmek istediğiniz menüyü seçiniz: ");            
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("------------Ana Yemekler------------");
                Console.WriteLine();
                Console.WriteLine("1-Köri Soslu Tavuk");
                Console.WriteLine("2-Kızartma Tabağı");
                Console.WriteLine("3-Fasülye Pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine();
                Console.WriteLine("------------Ana Yemekler------------");
                Console.WriteLine();
            }

            else if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("------------Çorbalar------------");
                Console.WriteLine();
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Ezogelin Çorbası");
                Console.WriteLine();
                Console.WriteLine("------------Çorbalar------------");
                Console.WriteLine();
            }
            else if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("------------Pizzalar------------");
                Console.WriteLine();
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2-Margarita Pizza");
                Console.WriteLine("3-Tavuklu Pizza");
                Console.WriteLine();
                Console.WriteLine("------------Pizzalar------------");
                Console.WriteLine();
            }
            else if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("------------İçecekler------------");
                Console.WriteLine();
                Console.WriteLine("1-Su");
                Console.WriteLine("2-Ayran");
                Console.WriteLine("3-Gazlı İçecekler");
                Console.WriteLine();
                Console.WriteLine("------------İçecekler------------");
                Console.WriteLine();
            }
            else if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("------------Tatlılar------------");
                Console.WriteLine();
                Console.WriteLine("1-Kazandibi");
                Console.WriteLine("2-Sütlaç");
                Console.WriteLine("3-Trileçe");
                Console.WriteLine();
                Console.WriteLine("------------Tatlılar------------");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            }

            */
            #endregion

            #region Switch Case
            /*
            
            Console.Write("Lütfen Ay Girişi Yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Ocak"); break;
                case 2:
                    Console.WriteLine("Şubat"); break;
                case 3:
                    Console.WriteLine("Mart"); break;
                case 4:
                    Console.WriteLine("Nisan"); break;
                case 5:
                    Console.WriteLine("Mayıs"); break;
                case 6:
                    Console.WriteLine("Haziran"); break;
                case 7:
                    Console.WriteLine("Temmuz"); break;
                case 8:
                    Console.WriteLine("Ağustos"); break;
                case 9:
                    Console.WriteLine("Eylül"); break;
                case 10:
                    Console.WriteLine("Ekim"); break;
                case 11:
                    Console.WriteLine("Kasım"); break;
                case 12:
                    Console.WriteLine("Aralık"); break;

                default: Console.WriteLine("Hatalı veri girişi."); break;
            }
            */
            #endregion

            #region Switch Case Hesap Makinesi Uygulaması

            /*
            int number1, number2, result;

            char symbol;

            Console.Write("Lütfen 1. sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sayıyı giriniz. ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam" + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Çıkartma: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
                default: Console.WriteLine("Lütfen geçerli bir değer giriniz."); break;
            }
            */
            #endregion

            Console.ReadKey();
        }
    }
}
