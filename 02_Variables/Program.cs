using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            /*
            double number;
            number = 4.85;
            Console.WriteLine(number);

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();
            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- Elma Birim Fiyatı: " +applePrice + " TL");
            Console.WriteLine("---- Portakal Birim Fiyatı: " +orangePrice + " TL");
            Console.WriteLine("---- Çilek Birim Fiyatı: " +strawberryPrice + " TL");
            Console.WriteLine("---- Patates Birim Fiyatı: " +potatoPrice + " TL");
            Console.WriteLine("---- Domates Birim Fiyatı: " +tomatoPrice + " TL");

            Console.WriteLine();
            Console.WriteLine();
            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar : " +appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar : " +orangeTotalPrice);
            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar : " +strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar : " +potatoTotalPrice);
            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar : " +tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Alışveriş Toplam Tutar: " +shoppingTotalPrice + " TL");

            
            */
            #endregion

            #region Char Değişkenler
            /*
            Console.WriteLine();

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            */
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            /*
            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            Console.Write("Yolcu adı: ");
            passangerName = Console.ReadLine();
            Console.Write("Yolcu soyadı: ");
            passangerSurname = Console.ReadLine();
            Console.Write("İlçe Bilgisi: ");
            passangerDistrict = Console.ReadLine();
            Console.Write("İl Bilgisi: ");
            passangerCity = Console.ReadLine();
            Console.Write("Yolcu Yaşı: ");
            passangerAge = Console.ReadLine();
            Console.Write("Yolcu TC Kimlik: ");
            passangerIdentityNumber = Console.ReadLine();

            Console.WriteLine();
            

            Console.WriteLine("---------------------");
            Console.WriteLine("Yolcu TC Kimlik: " +passangerIdentityNumber + " " +"Yolcu Ad Soyad: " +passangerName + " " + passangerSurname + " " + "İlçe Bilgisi: " + passangerDistrict + " " + passangerCity + " " + passangerAge);
            */
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            /*
            int shoesPrice, computerPrice, chairPrice, televisionPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            televisionPrice = 12000;

            int shoesCount, computerCount, chairCount, televisionCount;
            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            televisionCount = int.Parse(Console.ReadLine());

            int totalPrice = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (televisionPrice * televisionCount);
            Console.WriteLine();
            Console.WriteLine("Toplam Tutar: " +totalPrice);
            */
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            /*
            double exam1, exam2, exam3, result;
            Console.Write("Lütfen birinci sınav notunu giriniz: ");
            exam1 = Double.Parse(Console.ReadLine());

            Console.Write("Lütfen ikinci sınav notunu giriniz: ");
            exam2 = Double.Parse(Console.ReadLine());

            Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
            exam3 = Double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
           
            Console.WriteLine();
            Console.Write("Ortalama notunuz: " + result);
            


            */

            #endregion

            #region Klavyeden Karakter Girişleri
            /*
            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.Write("Seçtiğiniz cinsiyet: " +gender);
            */
            #endregion


            Console.ReadKey();
        }
    }
}
