using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Hello World");
            //Console.Write("Hi");  // WriteLine imleci bir alt satıra Write ise sağa atar!!

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            // string 
            // Değişken_türü değişken_adi;

            //string name;
            //name = "Gökdeniz";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, customerDistrict, customerCity;

            //customerName = "Aleyna";
            //customerSurname = "Yıldız";
            //customerEmail = "deneme123@gmail.com";
            //customerPhone = "+90 500 400 30 20";
            //customerDistrict = "Büyükçekmece";
            //customerCity = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------------------");
            //Console.WriteLine("Müşteri :" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + customerDistrict +"/"+customerCity);
            //Console.WriteLine("--------------------------------------------------------------");

            //// Önce Aleynayı okur sonra Gökdenizi okur!!
            //customerName = "Gökdeniz";
            //customerSurname = "Tural";
            //customerEmail = "deneme321@gmail.com";
            //customerPhone = "+90 543 210 01 23";
            //customerDistrict = "Atakum";
            //customerCity = "Samsun";

            //Console.WriteLine("--------------------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + customerDistrict+"/"+customerCity);
            //Console.WriteLine("--------------------------------------------------------------");
            #endregion

            #region Int Değişkenler

            //int number = 20;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("-----Kola:" + cokePrice + "TL");
            Console.WriteLine("-----Su:" + waterPrice + "TL");
            Console.WriteLine("-----Kızartma:" + friesPrice + "TL");
            Console.WriteLine("-----Pizza:" + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata:" + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerCount, cokeCount, waterCount, friesCount, pizzaCount, lemonadeCount;

            int totalhamburgerPrice = 0;
            int totalcokePrice = 0;
            int totalwaterPrice = 0;
            int totalfriesPrice = 0;
            int totalpizzaPrice = 0;
            int totallemonadePrice =0;
            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totalfriesPrice = friesCount * friesPrice;
            totalpizzaPrice = pizzaCount * pizzaPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;
            totalPrice = totalhamburgerPrice+totalcokePrice+totalwaterPrice+totalfriesPrice+totalpizzaPrice+totallemonadePrice;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı :" + totalhamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı :" + totalcokePrice + "TL");
            Console.WriteLine("Su Tutarı :" + totalwaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı :" + totalfriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı :" + totalpizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı :" + totallemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Toplam Tutar :" + totalPrice + "TL");










            #endregion










            Console.Read();
        }
    }
}

// Yazdırma Komutları
