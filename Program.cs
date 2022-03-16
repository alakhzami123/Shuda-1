using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde_1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("i will die soon ");
            //Datentypen: ganze Zahlen; Dezimalzahlen, Zeichenketten, zeichnen,
            // Wahrheitswerte (Boolean)

            // ganze Zahlen:
            int ganzeZahlA = 7;
            int ganzeZahlB;
            ganzeZahlB = 15;
            short kleineGanzeZahl;
            long großeGanzezahl;

            int ganzeZahlC = ganzeZahlA + ganzeZahlB;
            Console.WriteLine(ganzeZahlC);

            //Gleitkommazahlen (Dezimalzahlen)
            double gleitkommaZahlA = 1;
            double gleitkommaZahlB = 3;
            decimal großegleitkommazahl;
            Console.WriteLine(gleitkommaZahlA / gleitkommaZahlB);
            double gleitkommazahlC = ganzeZahlC + gleitkommaZahlA;
            // int zu double -> braucht Eingereifen
            Console.WriteLine(ganzeZahlC + gleitkommaZahlA);

            bool wahrheitswert = true;

            //Zeichnen und zeichnenketten
            char Zeichen = '&';
            string zeichenkette = "i will";
            string zeichenketteB = " die soon";

            //string + string := Kontakenation


        }

    }
}
