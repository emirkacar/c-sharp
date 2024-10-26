using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach dongusu

            //string[] cities = { "milano", "bursa", "ankara" };

            //foreach (string i in cities)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 100, 200, -37,35,300, 400, 500 ,-9,662};
            //int toplam = 0;
            //foreach(int i in numbers)
            //{
            //    if(i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //foreach(int i in numbers)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            //List<int> liste = new List<int>()
            //{
            //    1,2,3, 4,5,6,7,8,9,
            //};

            //liste.Add(100);

            //foreach(int i in liste)
            //{
            //    Console.WriteLine(i);
            //}

            //int ogrenciSayisi;
            //List<string> ogrenciListesi = new List<string>();
            //string ogrenci;
            //int toplam = 0;
            //int sinavNotu;

            //Console.WriteLine("Ogrenci sayisi giriniz: ");
            //ogrenciSayisi=int.Parse(Console.ReadLine());
            //Console.WriteLine("Ogrenci isimlerini giriniz: ");

            //for(int i=0; i<ogrenciSayisi; i++)
            //{
            //    Console.WriteLine($"{i + 1}. ogrenciyi giriniz: ");
            //    ogrenci= Console.ReadLine();
            //    ogrenciListesi.Add( ogrenci );
            //}

            //Console.WriteLine("Ogrenci listesi: ");
            //foreach(string i in ogrenciListesi)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine("Ogrenci sayisini giriniz: ");

            int ogrenciSayisi = int.Parse(Console.ReadLine());
            int i;
            int j;
            int toplam;
            string[] ogrenciIsimleri = new string[ogrenciSayisi];
            int[,] sinavNotlari = new int[ogrenciSayisi,3];

            for(i=0;i<ogrenciSayisi;i++)
            {
                Console.WriteLine($"{i + 1}.ogrencinin adini giriniz: ");
                ogrenciIsimleri[i]=Console.ReadLine();
                for(j=0;j<3;j++)
                {
                    Console.WriteLine($"{ogrenciIsimleri[i]} adli ogrencinin {j + 1}. sinav notunu giriniz: ");
                    sinavNotlari[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine(); 
            for(i=0;i<ogrenciSayisi;i++)
            {
                toplam = 0;
                Console.WriteLine($"{ogrenciIsimleri[i]} adli ogrencinin notlari : ");
                for(j=0;j<3; j++)
                {
                    Console.WriteLine($"{j+1}. sinav = {sinavNotlari[i,j]}");
                    toplam += sinavNotlari[i, j];
                }
                Console.WriteLine($"{ogrenciIsimleri[i]} adli ogrencinin sinav ortalamasi = {toplam/3}") ;
                Console.WriteLine() ;
            }
            Console.WriteLine();
            

        









            Console.ReadLine();
        }
    }
}
