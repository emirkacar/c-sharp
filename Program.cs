using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toplamTutar;
            double odenenMiktar;
            int kiyafet = 100;
            int sapka = 50;
            int pantalon = 200;
            int mont = 2600;
            int corap = 30;
            int kiyafetSayisi,sapkaSayisi,pantalonSayisi,montSayisi,corapSayisi;
            double indirim = 0.3;
            double paraUstu;

            Console.WriteLine("******* Magazaya hosgeldiniz. ********");
            Console.WriteLine();
            Console.WriteLine("Kac tane kiyafet istiyorsunuz=");
            kiyafetSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("Kac tane sapka istiyorsunuz=");
            sapkaSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("Kac tane pantalon istiyorsunuz=");
            pantalonSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("Kac tane mont istiyorsunuz=");
            montSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("Kac tane corap istiyorsunuz=");
            corapSayisi = int.Parse(Console.ReadLine());

            toplamTutar=kiyafet*kiyafetSayisi+sapka*sapkaSayisi+pantalon*pantalonSayisi+mont*montSayisi+corap*corapSayisi;

            

            if (toplamTutar >= 500)
            {
                toplamTutar -= toplamTutar * indirim;
                Console.WriteLine("Alisverisinizin toplam tutari = {0} TL", toplamTutar);
                Console.WriteLine("Kac lira vereceginizi giriniz: ");
                odenenMiktar = double.Parse(Console.ReadLine());
                paraUstu = odenenMiktar - toplamTutar;
                Console.WriteLine("Para ustunuz = {0} TL", paraUstu);
            }
            else if (toplamTutar<500 && toplamTutar>0)
            {
                Console.WriteLine("Alisverisinizin toplam tutari = {0} TL", toplamTutar);
                Console.WriteLine("Kac lira vereceginizi giriniz: ");
                odenenMiktar = double.Parse(Console.ReadLine());
                paraUstu = odenenMiktar - toplamTutar;
                Console.WriteLine("Para ustunuz = {0} TL", paraUstu);
            }
            else
            {
                Console.WriteLine("Hic urun satin almadiniz.Toplam tutariniz = {0}", toplamTutar);
            }

            
            
            

            
            

                


            Console.ReadLine();
        }
    }
}
