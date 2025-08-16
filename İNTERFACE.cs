using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;using System;


namespace ConsoleApp1
{
    public class Ders
    {
        //Interfaces: Temel amaç operasyonu oluşturup diğer nesnelerin bundan faydalanmasını sağlamak.interface içerisine implement ederiz ortakları. birbirine bağladım
        //Interface içerisinde nesne türetemezsin. CLASS NESNE TÜRETİR. 
        //erişimler static void içerisinde yapılır.
        //bir sınıfa birden fazla interface yapısı implement edilebilir.
        //interface Iinsan, IinsanMetot
        //İnterface interfacedan miras alabilir mi? Alabilir.


        //Musteri musteri = new Musteri
        //{
        //    Id = 1,
        //    Name = "Mehmet",
        //    Soyadı = "Akkuş",
        //    FirmaAdı = "Abc",
        //};

        //Ogrenci ogrenci = new Ogrenci
        //{
        //    Id = 1,
        //    Name = "Mehmet",
        //    Soyadı = "Akkuş",
        //    No = 85633

        //};

        //Manager manager = new Manager();//dolaylı olarak erişebilirim
        //Manager.Add(Ogrenci);
        //console.readline();
    }
}
    //interface Iinsan //temel olayı miras almaktır. interface oluşturduğun her yapı başına I koyuyoruz. İçeriye public olmaz.
    //{
    //    int Id { get; set; }
    //    string Name { get; set; }
    //    string Soyadı { get; set; }
    //}

//    class Ogrenci:Iinsan //interfacedan bilgi alacaksın diyorum
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Soyadı { get; set; }
//        public string No {  get; set; }
//    }


//    class Musteri:Iinsan 

//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Soyadı { get; set; }
//        public string FirmaAdı { get; set; }

//        //id, name,soyad musteri ve ogrenci classında ortak. o zaman onları tekrar tekrar yazmama gerek yok.
//        //Ortak operasyonların bulunduğu bir class oluşturacağız üste.    
    
//    }


//    class Manager
//    {
//        public void Add(Iinsan x)  //metoda sınıfı verip nesne türetebiliyoruz
//        {
//            Console.WriteLine(x.name);
//        }

//        public void Add2
    
//    }
//}

////ben sql değil oracle kullanıyorum dediğini düşünelim


//interface IOrtak
//{
//    void Add();
//    void Update();
//    void Delete();
//}

//public interface IMusteri
//{

//}
//class SqlServer
//{
//    public void Add()
//    { 
//        Console.WriteLine("SQLServer ADD");

//    }

//    public void Update()
//    { 
//        Console.WriteLine("SQLServer UPDATE");

//    }

//    public void Delete()
//    { 
//        Console.WriteLine("SQLServer DELETE");

//    }
//}

//class OracleServer
//{
//    public void Add()
//    {
//        Console.WriteLine("OracleServer ADD");

//    }

//    public void Update()
//    {
//        Console.WriteLine("OracleServer UPDATE");


//    }

//    public void Delete()
//    {
//        Console.WriteLine("OracleServer DELETE");

//    }
//}

//class MSSQLserver
//{
//    public void Add()
//    {
//        Console.WriteLine("MSSQLserver ADD");
//    }

//    public void Update()
//    {
//        Console.WriteLine("MSSQLserver UPDATE");

//    }

//    public void Delete()
//    {
//        Console.WriteLine("MSSQLserver DELETE");

//    }
//}

//class Manager
//{

//    public void Add(IOrtak o)
//    {
//        o.Add();
//    }
//}












//            //kullanıcı 0 girene kadar

//            Console.WriteLine("Bir sayı giriniz");
//            sayi=int.Parse(Console.ReadLine());

//            int sayi = 1;
//            while (sayi!=0)
//            {
//                toplam += sayi;
//            }
//        }
//        //10'a 10 çarpım tablosu

//        int i = 1;
//        int k = 1;
//        while (i<=10)
//{
//        while (k<=10)
//{
//        Console.WriteLine($"{i} X {k}= {i*k}");
//        k++;
//}
//        k =1;
//        i++;
//        if (i==11)
//{
//        break;
//}
//        Console.WriteLine("------------");
//}
//        //10 a kadar sayıları yazdır ama 8 i yazdırmayalım
//          int i = 1;
//          while(i != 8) //continue da kullanabiliriz
//{       
//    Console.WriteLine(i)
//}


