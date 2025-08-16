using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace ConsoleApp1
{
    internal static class Program
    {


        static void Main(string[] args)

        {
            //BUNLARIN HEPSİNİ OKUMAK İÇİN FOREACH DÖNGÜSÜ KULLANIRIZ.

            #region METOTLAR
            //Değer alan değer döndürmeyen metotla yap
            //Kullanıcı tarafından başlangıç ve bitiş noktaları verilen sayıların toplamını veren program.


            //Değer almayan döndürmeyen metotla (nesne türetmeden metot çalıştırmak amacımız)
            //Tek ve çift sayıların ayrı ayrı toplamlarını veren


            //public static void TekCift()
            //{

            //int tektoplam = 0;
            //int cifttoplam = 0;

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < sayi; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        cifttoplam += i;
            //    }

            //    else {
            //        tektoplam += i;
            //    }

            //    Console.WriteLine($"Çift toplamların değeri {cifttoplam}\n Tek toplamların değeri {tektoplam}");
            #endregion

            #region COLLECTIONS (ARRAY LIST):Type güvensiz
            //Kullanıcıya listenin kaç elemanlı olduğunu bildirip mevcudu yazdıran program

            //Console.WriteLine("Kaç kişilik sınıf olacak?");
            //int sınıf = int.Parse(Console.ReadLine());

            //string[] liste = new string[sınıf];
            //for (int i = 0; i < sınıf; i++)
            //{
            //    Console.WriteLine(i + 1 + ". değeri giriniz:");
            //    liste[i] = Console.ReadLine();
            //}
            //Console.WriteLine("-------------------------------------");

            //foreach (var item in liste)   //class collection foreach ile yazdırıyoruz
            //{
            //    Console.WriteLine(item);
            //}


            //ArrayList cityListesi = new ArrayList();
            //cityListesi.Add("Adana");
            //cityListesi.Add("Ankara");
            //cityListesi.Add("İstanbul");
            //cityListesi.Add("Bursa");
            //cityListesi.Add(5);
            //cityListesi.Add(5.5);
            //cityListesi.Add(true);
            // //ArrayList farklı türdeki verileri alabilir.SINIR YOK belirtmek zorunda değilsin.
            // //Ama arrayler, yani diziler aynı tipteki verileri alır.

            //foreach (var item in cityListesi)
            //{
            //    Console.WriteLine(item);
            //}



            /*
            ArrayList cityListesi = new ArrayList();


            Console.WriteLine("Sınıf listesi kaç elemanlı olsun?");
            int sınır = int.Parse(Console.ReadLine());

            for (int i = 0; i < sınır; i++)
            {
                Console.WriteLine(i+1 + ".öğrenci girin:");
                string kisi = Console.ReadLine();
                cityListesi.Add(kisi);
            }
            Console.WriteLine("------------------------");
            foreach (var item in cityListesi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            {

            } */



            //Kullanıcıdan sayı alalım; çift olanları toplayalım.

            //Console.WriteLine(  "Bir sayı giriniz" );
            //int sayi = int.Parse(Console.ReadLine());

            //ArrayList cifttopla = new ArrayList();
            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine("sayı girin");
            //    cifttopla.Add(Console.ReadLine());
            //}

            //for (int i = 0; i < sayi; i++)
            //{ 

            //}
            #endregion:Type

            #region GENERIC LISTS List<int vs.>
            //Type güvenliği istiyorsam kullanırız.

            /*

            List<string> isimListesi = new List<string>();
            isimListesi.Add("Ali");
            isimListesi.Add("Ayşe");
            isimListesi.Add("Sevda");
            isimListesi.Add("Ceyhun");
            isimListesi.Add("Eda");
            isimListesi.Add("Rahşan");

            foreach (var item in isimListesi)
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine(isimListesi.Contains("Ali"));

            List<Product> products = new List<Product>();
            //bunu classa atayınca, bu listin tipi class diyoruz. içerisinde int de string de var
            products.Add(new Product {Id=1,Name="Kalem",Description="kdmklfmk" });

            */







            /* (product buranın classı)
            //bir ürün ekledim liste ile classa.

            products.Add(new Product { Id = 2, Name = "çanta", Description = "kdmklfmk" });
            products.Add(new Product { Id = 3, Name = "telefon", Description = "kdmklfmk" });
            products.Add(new Product { Id = 4, Name = "yastık", Description = "kdmklfmk" });
            products.Add(new Product 
            
            { Id = 1, Name = "Kalem", Description = "kdmklfmk" }
            //böyle de yazabilirsin
            );
            Console.WriteLine("-------------------------------------");

            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
            }   */






            /*

            //Kullanıcıdan sayı iste. Kaç sayı girmek istiyorsun de
            // beş dedi mesela, içinde çift olanları yazdır.

            List<int> yazdır = new List<int>();

            Console.WriteLine("Kaç sayı gireceksiniz?");
            int sayiBoyutu = int.Parse(Console.ReadLine());

            for(int i=0;i<sayiBoyutu; i++)
            {
                Console.WriteLine($"{i+1}.sayıyı giriniz: ");
                //bunları alıp liste eklememiz gerekiyor hpsini int a değişkenine aktarıyorum

                int a = Convert.ToInt32(Console.ReadLine());
                yazdır.Add(a);

            }

            foreach (var item in yazdır)
            {
                Console.WriteLine(item);
            } */



            /*            private static void NewMethod3()
                    {
                        var ogrenciListesi = new List<Ogrenci>()
                   {
                       new Ogrenci(){Id=1,Name="Tufan",LastName="Akkuş"},
                       new Ogrenci(){Id=2,Name="Abdulbaki",LastName="Çelik"},
                       new Ogrenci(){Id=3,Name="Mert",LastName="Akgül"},
                       new Ogrenci(){Id=4,Name="Seyit",LastName="Akgül"},
                       new Ogrenci(){Id=5,Name="Efe",LastName="Akgül"},
                      new Ogrenci() { Id = 6, Name = "Mehmet", LastName = "akkuş" }

                   };
                        Console.WriteLine("----------------");
                        foreach (var item in ogrenciListesi)
                        {
                            Console.WriteLine(item.Name);
                        }
                        var ogren = ogrenciListesi[0];
                        ogrenciListesi.Remove(ogren);
                        Console.WriteLine("----------------");
                        foreach (var item in ogrenciListesi)
                        {
                            Console.WriteLine(item.Name);
                        }
                        Console.WriteLine("---------------");
                        var m = ogrenciListesi.Find(i => i.Name == "Mehmet");
                        if (ogrenciListesi.Contains(m))
                        {
                            Console.WriteLine("Bu öğrenci var....");
                        }
                        else
                        {
                            ogrenciListesi.Add(new Ogrenci() { Id = 5, Name = "Mehmet", LastName = "akkuş" });
                        }
                        Console.WriteLine("------------------");
                        foreach (var item in ogrenciListesi)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }

                    private static void NewMethod2()
                    {
                        List<int> sayilar = new List<int>();//int değerler alacaktır
                        List<string> isimListesi = new List<string>();//string değerler alacaktır
                        isimListesi.Add("Mehmet");
                        isimListesi.Add("Ahmet");
                        isimListesi.Add("Ali");
                        isimListesi.Add("Tufan");
                        isimListesi.Add("Kemal");
                        foreach (var item in isimListesi)
                        {
                            Console.WriteLine(item);//typ güvenlği varsa
                        }
                        Console.WriteLine("-----------------");
                        Console.WriteLine(isimListesi.Contains("Ali"));
                        Console.WriteLine("----------------");



                    private static void NewMethod1()
                    {
                        //Bir typ belirtilmediği zaman kullanılır.ancak typ güvenliği önemli olduğu için tercih edilmez..
                        ArrayList cityListesi = new ArrayList();//Sınır belirtilmez

                        Console.WriteLine("Sınıf listesi kaç elemanlı olsun ");
                        int sınır = int.Parse(Console.ReadLine());
                        for (int i = 0; i < sınır; i++)
                        {
                            Console.Write(i + 1 + ".Ogrenci girin: ");
                            string kisi = Console.ReadLine();
                            cityListesi.Add(kisi);
                        }
                        Console.WriteLine("-------------------------");
                        cityListesi.Add(5);
                        cityListesi.Add(90.9);
                        foreach (var item in cityListesi)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(cityListesi.IndexOf(1));
                    }

                    private static void NewMethod()
                    {
                        string[] sinifListesi = new string[2];
                        Console.Write("Sinif listesi kaç kişilik olacak ");
                        int deger = int.Parse(Console.ReadLine());
                        sinifListesi = new string[deger];
                        for (int i = 0; i < sinifListesi.Length; i++)
                        {
                            Console.WriteLine(1 + i + ".Kişi ");
                            sinifListesi[i] = Console.ReadLine();
                        }
                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        int k = 1;
                        foreach (var item in sinifListesi)
                        {
                            Console.WriteLine($"{k++}.{item}");
                        }
                    }*/
            // Console.ReadLine();

            #endregion

            #region LINQU
            //LINQU: Microsoft tarafından geliştirilmiştir.Sorgu dilidir. Diile enteegre edilmiş sorgudur.


            #region
            //int[] sayilar = { 5, 6, 7, 9, 10, 45, 88, 77 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > 5)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            //var sayiliste = from s1 in sayilar  //linqu
            //                where s1 > 5
            //                select s1;

            //foreach (var item in sayiliste)
            //    { 
            //    Console.WriteLine(item);
            //    }
            #endregion


            #region
            //int[] sayilar = { 5, 6, 7, 9, 10, 45, 88, 77 }; //5 ten büyük olan sayılara 5

            //var sayıartırma = from s1 in sayilar
            //                  //where s1 > 5
            //                  select s1 + 5;

            //foreach (var item in sayıartırma)
            //{
            //    Console.WriteLine((item));
            //}

            #endregion



            #region
            //int[] sayilar = { 5, 6, 7, 9, 10, 45, 88, 77 }; //5 ten büyük olan sayılara 5

            //var sayıartırma = from s1 in sayilar
            //                  //where s1 > 5
            //                  select s1 + 5;

            //foreach (var item in sayıartırma)
            //{
            //    Console.WriteLine((item));
            //}

            #endregion




            #region
            //            / isim listesi, kucuk buyuk harf karisik
            //string[] isimler = { "Mehmet", "alİ", "mert", "AbduLkAdiR", "AbdUllAh" };

            //            var kucuk = from isim in isimler
            //                        select new { kucuk = isim.ToLower(), buyuk = isim.ToUpper() };

            //            foreach (var item in kucuk)
            //            {
            //                Console.WriteLine($"{item.kucuk}\n{item.buyuk}\n");
            //            }
            #endregion



            #region
            //int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < sayılar.Length; i++)
            //{
            //    if (sayılar[i] == 4)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayılar[i]);
            //    }

            //}

            //var sayilar = sayılar.Take(4);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion



            #region
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };

            //var atla = sayilar.Skip(3);

            #endregion




            #region
            //int[] sayilar = { 12, 21, 3, 4, 5, 8, 1, 10, 47, 7, 0, 10 };

            //var siralama = from s in sayilar
            //               where s % 2 == 0   //çift olanları
            //               orderby s descending
            //               select s;

            //foreach (var item in siralama)
            //    Console.WriteLine(item);
            //{
            #endregion



            #region

            //string[] kirtasiye = { "DEFTERR", "SİLGGİ", "KALEEEM", "KAĞITT1", "KALEM UUCU", "RESİM DEEFTERİ", "talha", "talha" };
            //var kirtasiye2 = from s2 in kirtasiye
            //                 orderby s2.Length descending
            //                 select s2;
            //foreach (var s2 in kirtasiye2)
            //{
            //    Console.WriteLine(s2);
            //}
            #endregion



            #region
            //int[] sayilar = { 12, 12, 12, 21, 3, 4, 5, 5, 8, 1, 10, 47, 47, 47, 47, 7, 0, 10 };

            //var tekrar = sayilar.Distinct();
            //    tekrar =from s in tekrar
            //            orderby s descending
            //            select s;

            //foreach (var item in tekrar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion



            //except,union,insertsect
            #region
            //belli aralıkta çift değer üreteceğiz

            //var sayilar = from s in Enumerable.Range(1, 50)
            //              select new { sayi = s, tek = s % 2 == 1 ? "tek sayi" : "cift sayi" };
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi); 
            //}
            #endregion




            #region
            //int[] sayilar1 = { 12, 21, 3, 4, 5, 8, 1, 10, 47, 7, 0, 10 };
            //int[] sayilar2 = { 1, 2, 3, 4, 5, 6, 7, 80 };
            //var s1olupS2Olmayan = sayilar1.Except(sayilar2);
            //foreach (var item in s1olupS2Olmayan)
            //{
            // Console.WriteLine(item);
            //}
            #endregion



            #region
            //int[] sayilar1 = { 12, 21, 3, 4, 5, 8, 1, 10, 47, 7, 0, 10 };
            //int[] sayilar2 = { 1, 2, 3, 4, 5, 6, 7, 80 };
            //var ortakSayılar = sayilar1.Intersect(sayilar2);
            //foreach (var item in ortakSayılar)
            //{
            // Console.WriteLine(item);
            //}
            #endregion




            #region
            //int[] sayilar1 = { 12, 21, 3, 4, 5, 8, 1, 10, 47, 7, 0, 10 };
            //int[] sayilar2= { 1,2,3,4,5,6,7,80 };
            //var birlestir = sayilar1.Union(sayilar2);
            //Console.WriteLine("Birleştir...............");
            //foreach (var item in birlestir)
            //{
            // Console.WriteLine(item);
            //}
            #endregion




            #region
            //int[] sayilar = { 12, 21, 3, 4, 5, 8,1, 10, 47, 7, 0, 10 };
            //var siralama = from s in sayilar
            // where s%2==0 //çift olanları büyükten küçüğe sırala
            // orderby s descending// a-z ascending,z-a
            // select s;
            //foreach (var item in siralama)
            //{
            // Console.WriteLine(item);
            //}
            #endregion




            #region
            //int[] sayilar = { 2, 4, 6, 8, 10,7 };
            //var sadecift = sayilar.All(x => x % 2 == 0 );
            //Console.WriteLine( sadecift );
            #endregion



            #region MyRegion
            //string[] isimler = { "at","atıcı","atla","atmak"};
            //bool varmı = isimler.Contains("at"); //search işlemi:contains
            //Console.WriteLine(varmı);

            //string[] isimler = { "at", "atıcı", "atla", "atmak" };
            //bool varmı = isimler.Any(x=>x.Contains("at")); //bu da ikinci bir yol
            //Console.WriteLine(varmı);
            #endregion



            #region
            //int[] sayilar = { 1, 2, 3, 1, 5, 4, 4, 2, 6 };
            //var kactane = sayilar.Length;
            //Console.WriteLine(kactane); //kaç elemanlı dizi?

            //int[] sayilar = { 1, 2, 3, 1, 5, 4, 4, 2, 6 };
            //var kactane = sayilar.Distinct().Count();
            //Console.WriteLine(kactane); //kaç elemanlı dizi?aynı sayıları sayma.

            //int[] sayilar = { 1, 2, 3, 1, 5, 4, 4, 2, 6 };
            //var kactane = sayilat.Distinct();.Tolist();
            //foreach(var item in kactane)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*//benzin lpg dizel listele litresine göre ne kadar lazım veya ne kadar bakiyem kaldı
x:
Console.WriteLine("1) lpg\n 2) dizel\n 3) benzinden \n hangisini almak istediğini yazınız ");

double lpgfiyat = 23, dizelfiyat = 25, benzinfiyat = 20, bakiye = 500;
string seçenek;
double litre;

seçenek = Console.ReadLine();
Console.WriteLine(" sonra kaç litre alacağınızı giriniz");
litre = double.Parse(Console.ReadLine());

seçenek = seçenek.ToLower();// küçük harfe göre kontrol eder
if (seçenek == "1" || seçenek == "l" || seçenek == "lpg")
{
if (bakiye >= (lpgfiyat * litre))
{
    bakiye = bakiye - (lpgfiyat * litre);
    Console.WriteLine($"kalan bakiyeniz {bakiye}\n harcanan bakiye {(lpgfiyat * litre)} ");
}
else
{
    Console.WriteLine($"bakiyeniz yetersiz {(lpgfiyat * litre) - bakiye} kadar para lazım");

}

}
else if (seçenek == "2" || seçenek == "d" || seçenek == "dizel")
{
if (bakiye >= (dizelfiyat * litre))
{
    bakiye = bakiye - (dizelfiyat * litre);
    Console.WriteLine($"kalan bakiyeniz {bakiye}\n harcanan bakiye {(dizelfiyat * litre)} ");
}
else
{
    Console.WriteLine($"bakiyeniz yetersiz {(dizelfiyat * litre) - bakiye} kadar para lazım");

}
}
else if (seçenek == "3" || seçenek == "b" || seçenek == "benzin")
{
if (bakiye >= (benzinfiyat * litre))
{
    bakiye = bakiye - (benzinfiyat * litre);
    Console.WriteLine($"kalan bakiyeniz {bakiye}\n harcanan bakiye {(benzinfiyat * litre)} ");
}
else
{
    Console.WriteLine($"bakiyeniz yetersiz {(benzinfiyat * litre) - bakiye} kadar para lazım");

}
}
else
{
Console.WriteLine("elimizde sadece bu tür yakıtlar var üzgünüz");
goto x;
}
/* vücut kitle indeksi
#region
double boy;
double index;
double kilo;

Console.WriteLine("Boyunuzu Girin: ");
boy = double.Parse(Console.ReadLine());
Console.WriteLine("Kilonuzu Girin: ");
kilo = double.Parse(Console.ReadLine());

index = kilo / (boy * boy);

if (index < 18.5)
{
Console.WriteLine($"vücüt indexiniz {index}: Zayıf ");
}
else if (index >= 18.5 && index < 24.9)
{
Console.WriteLine($"vücüt indexiniz {index}: Sağlıklı ");
}
else if (index >= 24.9 && index < 30)
{
Console.WriteLine($"vücüt indexiniz {index}: Kilolu Azıcık Bir şey Olmaz Takma Kafaya ");
}
else if (index >= 30 && index < 39.9)
{
Console.WriteLine($"vücüt indexiniz {index}: Obez ");
}
else
{
Console.WriteLine($"vücüt indexiniz {index}: Açırı Obez ");
}
#endregion
*/
            #endregion


            //}


        }




        #region List<product> classı

        /*
        class Product  //(product buranın classı)
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }


        }
        */
        #endregion
    }
}
















































//}