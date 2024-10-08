using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.Write("Merhaba Dünya\n");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            // string
            // Degisken_türü degisken_adi;

            //string name;
            //name = "Halil";
            //Console.Write(name);

            //string customerName; // Camel case örneği.İlk kelimenin baş harfi küçük, sonraki kelimelerin baş harfleri büyük.
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Halil";
            //customerSurname = "Erdigel";
            //customerPhone = "+90 554 293 54 23";
            //customerEmail = "deneme@gmail.com";
            //district = "Çamdibi";
            //city = "İzmir";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müşteri: " +customerName + " " +customerSurname);
            //Console.WriteLine("İletişim: " +customerPhone);
            //Console.WriteLine("Email adresi: " +customerEmail);
            //Console.WriteLine("Adres: " +district +"/" +city);
            //Console.WriteLine("---------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 52 78";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------");

            #endregion

            #region Int Değişkenler

            //int 

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("----Kola: " +cokePrice + " TL");
            Console.WriteLine("----Limonata: " +lemonadePrice + " TL");
            Console.WriteLine("----Kızartma Fiyatı: " + friesPrice + " TL");
            Console.WriteLine("----Su Fiyatı: " +waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount; 
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Total Hamburger Tutarı: " +totalHamburgerPrice + " TL");
            Console.WriteLine("Total Pizza Tutarı: " +totalPizzaPrice + " TL");
            Console.WriteLine("Total Kızartma Tutarı: " +totalFriesPrice + " TL");
            Console.WriteLine("Total Kola Tutarı: " +totalCokePrice + " TL");
            Console.WriteLine("Total Limonata Tutarı: " +totalLemonadePrice + " TL");
            Console.WriteLine("Total Su Tutarı: " +totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalFriesPrice + totalPizzaPrice + totalHamburgerPrice;
            Console.WriteLine("Total ödenecek tutar: " +totalPrice + " TL");


            #endregion


            Console.ReadKey();
        }
    }
}










// Yazdırma Komutları