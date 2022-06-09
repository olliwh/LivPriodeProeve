using System;

namespace LivAktivitetPrøve
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aktivitet a1 = new Aktivitet(1, 10, 13, new DateTime(2022, 07, 01, 09, 00, 00), new DateTime(2022, 07, 01, 12, 00, 00));
            Aktivitet a2 = new Aktivitet(2, 11, 13, new DateTime(2022, 07, 02, 09, 00, 00), new DateTime(2022, 07, 02, 12, 00, 00));
            Aktivitet a3 = new Aktivitet(3, 10, 11, new DateTime(2022, 07, 03, 09, 00, 00), new DateTime(2022, 07, 03, 10, 00, 00));
            Aktivitet a4 = new Aktivitet(4, 15, 14, new DateTime(2022, 07, 04, 09, 00, 00), new DateTime(2022, 07, 04, 12, 00, 00));
            Aktivitet a5 = new Aktivitet(5, 10, 14, new DateTime(2022, 07, 04, 13, 00, 00), new DateTime(2022, 07, 04, 15, 00, 00));
            Console.WriteLine("5 styks Aktiviter:");
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine();

            Aktivitetskatalog ak1 = new Aktivitetskatalog("Fodbold", "Fodboldbanen");
            ak1.Aktiviteter.Add(a1);
            ak1.Aktiviteter.Add(a2);
            ak1.Aktiviteter.Add(a3);
            ak1.AddAktivitet(a4);
            Console.WriteLine("AktivitetsKat med 4 aktiviteter");
            Console.WriteLine(ak1);

            ak1.DeleteAktivitet(4);
            ak1.DeleteAktivitet(3);
            ak1.DeleteAktivitet(1);
            ak1.DeleteAktivitet(2);
            ak1.DeleteAktivitet(50);
            Console.WriteLine("Deleted all");
            Console.WriteLine(ak1);

            Aktivitetskatalog ak2 = new Aktivitetskatalog("Fangeleg", "Legepladsen");
            ak2.AddAktivitet(a2);
            ak2.AddAktivitet(a4);
            ak2.AddAktivitet(a1);

            Console.WriteLine("AktivitetsKat med 3 aktiviteter");
            Console.WriteLine(ak2);

            ak2.DeleteAktivitet(1);
            ak2.DeleteAktivitet(12);
            ak2.DeleteAktivitet(4);

            Console.WriteLine("Deleted 2");
            Console.WriteLine(ak2);


            HoldAktivitet ha1 = new HoldAktivitet(1, 1, 12, 13, new DateTime(2022, 07, 01, 09, 00, 00), new DateTime(2022, 07, 01, 13, 00, 00));
            Console.WriteLine("HoldAktivitet");
            Console.WriteLine(ha1);

            Deltager d1 = new Deltager(1, "Bo", 12);
            Deltager d2 = new Deltager(2, "Ib", 11);
            Deltager d3 = new Deltager(3, "Ea", 10);
            Deltager d4 = new Deltager(4, "Åge", 14);
            Deltager d5 = new Deltager(5, "Liv", 13);


            ha1.AddDeltager(d1);
            ha1.AddDeltager(d2);
            ha1.AddDeltager(d3);
            ha1.AddDeltager(d4);
            ha1.AddDeltager(d5);

            //test om unikt id virker
            ha1.AddDeltager(d1);
            ha1.AddDeltager(d2);
            ha1.AddDeltager(d3);
            ha1.AddDeltager(d4);
            ha1.AddDeltager(d5);

            Console.WriteLine("HoldAktivitet");
            Console.WriteLine(ha1);

            ha1.DeleteDeltager(2);
            ha1.DeleteDeltager(4);
            ha1.SeeDeltagere();



            //Dictionary
            Console.WriteLine("------------------------------------------dictoinary virker kun når tostring ikke er kommenteret---------------------");
            Aktivitetskatalog akdic = new Aktivitetskatalog("Sten Maling", "Terracen");
            akdic.DicAddAktivitet(a5);
            akdic.DicAddAktivitet(a1);
            akdic.DicAddAktivitet(a3);
            Console.WriteLine(akdic);

            akdic.DicDeleteAktivitet(3);
            akdic.DicDeleteAktivitet(1);
            akdic.DicDeleteAktivitet(4);

            Console.WriteLine(akdic);
        }
    }
}
