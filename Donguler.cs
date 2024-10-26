using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0'dan 10'a kadar olan i degerlerini yazdirma.
            /*
            int i;
            for(i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }*/

            //int i;
            //3'er 3'er giden sayilari ekrana bastirma.
            /*
            for(i=0;i<=50;i+=3)
            {
                Console.WriteLine(i);
            }*/

            /*int baslangic;
            int bitis;

            Console.WriteLine("Baslangic degeri: ");
            baslangic=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitis degeri: ");
            bitis=Convert.ToInt32(Console.ReadLine());

            for(i=baslangic;i<bitis;i++)
            {
                Console.WriteLine(i);
            }*/

            /*for(i=0;i<100;i++)
            {
                if(i%5==0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*int toplam = 0;

            for(i=0;i<10;i++)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);*/

            /*int i;
            int sayac;

            sayac = 0;
            for(i=0;i<50;i++)
            {
                if(i%7==0)
                {
                    Console.WriteLine(i);
                    sayac++;
                }
            }
            Console.WriteLine("***************");
            Console.WriteLine(sayac);*/

            //Bakteri problemi.
            /*int bakteriSayisi = 1;
            int i;
            int saat = 1;

            for(i= saat;i<=24; i++)
            {
                bakteriSayisi *= 2;
                Console.WriteLine("{0}.saat sonundaki bakteri sayisi = {1}",i,bakteriSayisi);
            }
            Console.WriteLine("24 saatin sonunda olusan bakteri sayisi = {0}", bakteriSayisi);*/

            /*int i = 1;

            while(i<10)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/

            //Klavyeden girilen bir sayinin basamak degerleri toplama algoritmasi.
            /*int sayi = 1234;
            int gecici;
            int kalan = 0;
            int toplam = 0;
            gecici = sayi;

            while(gecici!=0)
            {
                kalan = gecici % 10;
                toplam += kalan;
                gecici /= 10;
            }
            Console.WriteLine(toplam);*/



            /*int i;
            int j;*/

            /*for(i=1;i<5;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }*/
            //Ters Dik Ucgen.
            /*for(i=1;i<=10;i++)
            {
                for(j=10;j>=i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/


            /*for (i = 1; i <= 10; i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(i = 1;i<=10;i++)
            {
                for(j=10;j>=i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            //Baklava dilimi algoritması

            /*for(i=1;i<=3;i++)
            {
                for(j=i+1;j<5;j++)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=2*i-1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(i=2;i>=1;i--)
            {
                for(j=i;j<=3;j++)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=2*i-1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            //Diziler Konusu


      
      





            Console.ReadLine();
        }
    }
}
