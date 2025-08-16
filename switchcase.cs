//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace Ödev2 
//{
//    internal class Program1
//    {
//        static void Main(string[] args)
//        {
//            #region MyRegion
//            //Girilen sayının tek toplamı ve çift toplamını yazdıran program:

//            Console.WriteLine("Bir sayı giriniz:");
//            int sayi = int.Parse(Console.ReadLine());  
//            int ciftToplam = 0;  
//            int tekToplam = 0;   
//            int i = 1;  


//            while (i <= sayi)
//            {
//                if (i % 2 == 0)  
//                    ciftToplam += i; 
//                else  
//                    tekToplam += i;  

//                i++;  
//            }
//            Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);
//            Console.WriteLine("Tek sayıların toplamı: " + tekToplam);

//            Console.ReadKey();
//            #endregion


//            #region MyRegion

//            //122333444455555

//            int i = 1;

//            while (i <= 5)
//            {
//                int j = 1;

//                while (j <= i)
//                {
//                    Console.Write(i);
//                    j++;
//                }

//                Console.WriteLine();
//                i++;
//            }
//            #endregion



//            #region MyRegion

//            // ***
//            // ***
//            // ***
//            // ***

//            //4 dış döngü, 3 iç döngü

//           int i = 1;
//            while (i <= 4)
//            {
//                int j = 1;
//                while (j <= 3)
//                {
//                    Console.Write("*");
//                    j++;
//                }

//                Console.WriteLine();
//                i++;
//            }

//            #endregion



//            #region MyRegion
//            //    *
//            //   **
//            //  ***
//            // ****
//            //*****    3 olmalı. boşluk, yıldız, iç arttırma. dış döngü 5, iç artan, boşluk azalan.

//            int bosluk = 4;
//            while(bosluk <= 1)
//            {
//                Console.Write( " ");
//                bosluk--;

//                int j = 1;
//                while(j <= 5)
//                { Console.Write("*");
//                j++;
//                        }

//            }

//        }
//    }
//}

