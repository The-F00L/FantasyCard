using System;

namespace Fantasycard
{
    class Program
    {
        static void Main(string[] args)
        {
            Cards cards = new Cards();
            cards.beolvas();
            Console.WriteLine("3.feladat:"+cards.leeroy());
            Console.WriteLine("4.feladat:");
            Console.WriteLine(cards.powerMinSearch());
            Console.WriteLine(cards.powerMaxSearch());
            Console.WriteLine("5.feladat:"+cards.compSearchDwarf());
            Console.WriteLine("6.feladat:\n"+cards.compSearchOrc());
            Console.WriteLine("7.feladat:\n"+cards.raceSearch());

        }
    }
}
