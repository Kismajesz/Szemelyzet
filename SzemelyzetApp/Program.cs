using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyzetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var boss = new Szemely("Bölkény Zalán" , new DateTime(2000,04,19), "IT manager");
            var sz1 = new Szemely("Nagy Tamás" , new DateTime(2000,06,26), "WC manager");
            var sz2= new Szemely("Ben Dover" , new DateTime(1999,03,02), "Analitikus");
            var sz3 = new Szemely("Nick Gurr" , new DateTime(1980,12,06), "Rabló");
            var sz4 = new Szemely("Csöcsös Lujza" , new DateTime(1989,01,22), "Péni szakértő");
            Szemelyzet szemelyzet = new Szemelyzet(boss);

            boss.HozzaAd(sz1);
            boss.HozzaAd(sz2);
            boss.HozzaAd(sz3);
            boss.HozzaAd(sz4);

            Szemely keresett = szemelyzet.Keres("Ben Dover", new DateTime(1999, 03, 02));
            


            Console.WriteLine(keresett);
            Console.WriteLine(szemelyzet.Letszam);
            Console.ReadLine();
        }
    }
}
