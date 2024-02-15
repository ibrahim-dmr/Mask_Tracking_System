using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround;

class Program
{
    static void Main(string[] args)
    {
        //Degiskenler();

        Vatandas vatandas1 = new Vatandas(); //Instance

        SelamVer("Ahmet");
        SelamVer("Ali");
        SelamVer("Naz");
        SelamVer();

        int sonuc = Topla(6);

        //Diziler / Arrays
        string[] ogrenciler = new string[5];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "İbrahim";
        ogrenciler[2] = "Kerem";
        ogrenciler[3] = "Berkay";
        ogrenciler[4] = "Ahmet";
        
        //Array, Class, Inteface, Abstract Referans tiptir. (Stack-Heap)
        ogrenciler = new string[6];
        ogrenciler[5] = "Celil";

        //Console.WriteLine(ogrenciler[1]);

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        //Referans tip
        string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = { "Diyarbakır", "Balıkesir", "Samsun" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";

        Person person1 = new Person();
        person1.FirstName = "İBRAHİM HALİL";
        person1.LastName = "DEMİR";
        person1.DateOfBirthdayYear = 2001;
        person1.NationalIdentity = 11122233344;

        Console.WriteLine(sehirler2[0]);

        foreach (string sehir in sehirler2)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler = new List<string> { "Aydın", "Antalya", "Diyarbakır" };
        yeniSehirler.Add("İzmir");
        foreach(string sehir2 in yeniSehirler)
        {
            Console.WriteLine(sehir2);
        }


        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
        
            
        //Değer tip
        int sayi1 = 10;
        int sayi2 = 20;

        sayi2 = sayi1;
        sayi1 = 30;
        Console.WriteLine(sayi2);


        Console.ReadLine();
    }

    static void SelamVer(string isim = "isimsiz") 
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1, int sayi2 = 14)  //Default parametreler sona yazılır.
    {
        int sonuc = sayi1+ sayi2;
        Console.WriteLine("Toplam: "+ sonuc);
        return sonuc;
    }
    private static void Degiskenler()
    {
        string mesaj = "merhaba";
        double tutar = 10000; //db'den gelir
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "İbrahim halil";
        string soyad = "Demir";
        int dogumYili = 2001;
        long tcNo = 11122233344;

        Console.WriteLine(tutar * 1.18);
    }
}

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}