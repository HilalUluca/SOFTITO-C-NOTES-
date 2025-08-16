using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlkDers   // Namespace başlıyor
{
    internal class Program   // Program sınıfı tanımlanıyor
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" gel");
        }
    }  
}   

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
