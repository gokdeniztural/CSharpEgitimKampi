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

            //double number;
            //number = 3.14;  // ondalıklı sayıları "." kullanarak yazıyoruz ve konsol ekranında "," ile gösteriliyor.
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("-----Elma Birim Fiyatı :" + applePrice + "TL");
            //Console.WriteLine("-----Portakal Birim Fiyatı :" + orangePrice + "TL");
            //Console.WriteLine("-----Çilek Birim Fiyatı :" + strawberryPrice + "TL");
            //Console.WriteLine("-----Patates Birim Fiyatı :" + potatoPrice + "TL");
            //Console.WriteLine("-----Domates Birim Fiyatı :" + tomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //Console.WriteLine();
            //Console.WriteLine();

            //double appletotalPrice = applePrice * appleGram;
            //double orangetotalPrice = orangePrice * orangeGram;
            //double strawberrytotalPrice = strawberryPrice * strawberryGram;
            //double potatototalPrice = potatoPrice * potatoGram;
            //double tomatototalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat:" + applePrice +" " + "-Gramaj:" + appleGram +"- " + "Toplam Tutar:" + appletotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat:" + orangePrice + " "  + "-Gramaj:" + orangeGram+" -" + "Toplam Tutar:" + orangetotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat:" + strawberryPrice + " " + "-Gramaj:" + strawberryGram+"- " + "Toplam Tutar:" + strawberrytotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat:" + potatoPrice+" " + "-Gramaj:" + potatoGram+" -" + "Toplam Tutar:" + potatototalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat:" + tomatoPrice+" " + "-Gramaj:" + tomatoGram+"- " + "Toplam Tutar:" + tomatototalPrice);
            //Console.WriteLine("------------------------------------------------------------------------------------------------------");


            //double shoppingtotalPrice = appletotalPrice + orangetotalPrice + strawberrytotalPrice + potatototalPrice + tomatototalPrice;
            //Console.WriteLine("Alışverişin Toplam Tutarı :" +shoppingtotalPrice + "TL");




            #endregion

            #region Char Değişkenler
            // ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20.00'DE
            // ' ' 


            //char symbol;
            //symbol = 'g';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi*****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Tc Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No: " + passengerIdentityNumber +   " -Yolcu Ad Soyad: " + passengerName + " " + passengerSurname+ " "
            //    +   passengerDistrict + "/" + passengerCity + " " +  passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 25000;
            //chairPrice = 3000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Adetini Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Adetini Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Adetini Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Adetini Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalCount = shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar :" + totalCount);



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunuzu giriniz :");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunuzu giriniz :");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunuzu giriniz :");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız :" + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz :");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet:" + gender);

            #endregion

            Console.Read();
        }
    }
}
