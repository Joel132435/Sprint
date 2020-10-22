using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Program
    {

        static void Main()
        {

            double m, z, d, h, hf, ha, p, df, c, db, deg, w;



            Console.WriteLine("Bitte Geben Sie das Modul an.");
            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Bitte Geben Sie die Zähnezahl an.");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Bitte Geben Sie den Teilkreisdurchmesser an.");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            //Kopfspiel Unterprogramm

            c = Kopfspiel(m);

            //Eingriffswinkel Unterporgramm

            w = Eingriffswinkel();

            //Zahnhöhe

            h = 2 * m + c;

            Console.WriteLine("Zahnhöhe = " + h);
            Console.WriteLine();

            //Zahnfußhöhe

            hf = m + c;

            Console.WriteLine("Zahnfußhöhe = " + hf);
            Console.WriteLine();

            //Zahnkopfhöhe

            ha = m;

            Console.WriteLine("Zahnkopfhöhe = " + ha);
            Console.WriteLine();

            //Teilung

            p = Math.PI * m;

            Console.WriteLine("Teilung = " + p);
            Console.WriteLine();

            //Fußkreisdurchmesser

            df = d - 2 * (m + c);

            Console.WriteLine("Fußkreisdurchmesser = " + df);
            Console.WriteLine();

            //Grundkreisdurchmesser

            deg = (w * (Math.PI)) / 180;

            db = m * z * (Math.Cos(deg));

            Console.WriteLine("Grundkreisdurchmesser = " + db);
            Console.WriteLine();

            Console.ReadKey();

        }



        // UNTERPROGRAMME 

        static double Kopfspiel(double m)
        {

            double x, y, l, c;

            //häufig verwendete Wert

            l = m * 0.167;

            // x = unteres Kopfspiel / y = oberes Kopfspiel

            x = 0.1 * m;
            y = 0.3 * m;

            Console.WriteLine("KOPFSPIEL ANGABE");

            c = Wertabfrage(x, y, l);

            return c;
        }





        static double Eingriffswinkel()
        {
            double x, y, l, w;

            //norm Eingriffswinkel

            l = 20;

            // x = min Winkel / y = max Winkel

            x = 0;
            y = 90;

            Console.WriteLine("EINGRIFFSWINKEL ANGABE");

            w = Wertabfrage(x, y, l);

            return w;
        }



        static double Wertabfrage(double x, double y, double l)
        {
            double c;
            int n, k, q, s;
            string a;

            k = 0;
            s = 0;

            //do-while-Schleife 

            do
            {

                //Abfrage ob ein Kopfspiel/Eingriffswinkel angegeben werden soll

                Console.WriteLine("Wollen Sie einen Wert angeben ? Ja oder Nein ");
                a = Convert.ToString(Console.ReadLine());

                Console.WriteLine();



                // Abfrage des Kopfspiels/Eingriffswinkels
                switch (a)
                {
                    case "Ja":
                    case "JA":
                    case "ja":

                        do
                        {



                            Console.WriteLine("Bitte geben Sie das Kopfspiel an");
                            c = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine();

                            // Abfrage ob das Kopfspiel/der Eingriffswinkel zutreffen kann

                            n = 0;
                            q = 0;

                            do
                            {
                                //Wert wird 3 mal erneut abgefragt (falls falsch) und dann wird Programm von vorne gestartet.

                                if (q < 2)
                                {

                                    //Wenn das Kopfspiel/der Eingriffswinkel zutrifft beendung der while-Schleife

                                    if ((c >= x) & (c <= y))
                                    {

                                        n += 1;
                                        k += 1;
                                        s += 1;

                                    }

                                    //Falls das Kopfspiel/der Eingriffswinkel nicht zutrifft, Wert erneut abfragen

                                    else
                                    {

                                        Console.WriteLine("Der Angegebene Wert ist nicht korrekt.");
                                        Console.WriteLine();
                                        Console.WriteLine("Bitte geben Sie das Kopfspiel erneut an");
                                        c = Convert.ToDouble(Console.ReadLine());

                                        Console.WriteLine();

                                        q += 1;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Sie haben den Wert 3 mal falsch angegeben");
                                    Console.WriteLine();


                                    n += 1;
                                    s += 1;

                                }

                            } while (n < 1);

                        } while (s < 1);

                        break;

                    case "Nein":
                    case "NEIN":
                    case "nein":

                        //Falls mit NEIN genatwortet wird, wird mit dem häufig verwendeten Wert gerechnet

                        c = l;

                        k += 1;

                        break;

                    default:

                        //Falls man nicht ja oder nein schreibt

                        c = 0;

                        break;

                }

            } while (k < 1);

            return c;



        }
    }
}
