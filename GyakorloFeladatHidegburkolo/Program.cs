using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyakorloFeladatHidegburkolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Burkolas();

            Console.ReadKey();
        }

        private static void Burkolas()
        {
            //Szoba adatainak bekérése
            Console.Write("Kérem, írja be a szoba szélességét méterben!\t");
            double szelesseg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Írja be a szoba hosszúságát méterben!\t");
            double hosszusag = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A szoba magassága 1,5 méter...\n");
            double magassag = 1.5;

            //Számolás
            double Alapterulet = szelesseg * hosszusag;
            double HosszabbFal = (hosszusag * magassag) * 2;
            double RovidebbFal = (szelesseg * magassag) * 2;
            double SzobaTeljes = HosszabbFal + RovidebbFal + Alapterulet;
            Console.WriteLine(SzobaTeljes + " m^2 a szoba falainak területe");
            
            //1 csomag csempe
            double szukseges = 1.44;

            //Eredmény
            Console.WriteLine(Convert.ToInt32((SzobaTeljes / szukseges) *1.1) + " csomag csempe szükséges");
        }
    }
}
