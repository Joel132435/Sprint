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

            double m, z, d, h, hf, ha, p, df, c, db, deg ,w ;
            
            

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



        static double Kopfspiel(double m)
        {
            double x, y, c, a;
            int n, k ,q;

            k = 0;

            //do-while-Schleife 

            do
            {
               
                //Abfrage ob ein Kopfspiel angegeben werden soll

                Console.WriteLine("Wollen Sie ein genaues Kopfspiel angeben ? 1 für JA und 2 für NEIN ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                if (a < 2)
                {
                    // x = unteres Kopfspiel / y = oberes Kopfspiel

                    x = 0.1 * m;
                    y = 0.3 * m;

                    // Abfrage des Kopfspiels

                    Console.WriteLine("Bitte geben Sie das Kopfspiel an");
                    c = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();

                    // Abfrage ob das Kopfspiel zutreffen kann

                    n = 0;
                    q = 0;

                    while (n < 1)
                    {
                        //Wert wird 3 mal erneut abgefragt (falls falsch) und dann wird Programm von vorne gestartet.

                        if (q < 2)
                        {

                            //Wenn das Kopfspiel zutrifft beendung der while-Schleife

                            if ((c >= x) & (c <= y))
                            {
                               
                                n += 1;
                                k += 1;

                            }

                            //Falls das Kopfspiel nicht zutrifft, Wert erneut abfragen

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
                           
                        }
                    }                   
                }

                //Falls mit NEIN genatwortet wird, wird mit dem häufig verwendeten Wert gerechnet

                else
                {

                    c = m * 0.167;

                    k += 1;

                }

            } while (k < 1);

            return c;
        }





        static double Eingriffswinkel()
        {
            double a, x, y, w;
            int k, n, q;

            k = 0;

            //do-while-Schleife 

            do
            {

                //Abfrage ob ein Eingriffswinkel angegeben werden soll

                Console.WriteLine("Wollen Sie einen Eingriffswinkel angeben und nicht von dem Norm Eingriffswinkel ausgehen? 1 für JA und 2 für NEIN ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                if (a < 2)
                {
                    // x = max Winkel / y = min Winkel

                    y = 90;
                    x = 0;

                    // Abfrage des Eingriffwinkels

                    Console.WriteLine("Bitte geben Sie den Eingriffswinkel an");
                    w = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();

                    // Abfrage ob der Eingriffswinkel zutreffen kann

                    n = 0;
                    q = 0;

                    while (n < 1)
                    {
                        //Wert wird 3 mal erneut abgefragt (falls falsch) ,dann wird Programm von vorne gestartet.

                        if (q < 2)
                        {

                            //Wenn der Eingriffswinkel zutrifft beendung der while-Schleife

                            if ((w > x) & (w < y))
                            {

                                n += 1;
                                k += 1;

                            }

                            //Falls der Eingriffswinkel nicht zutreffen kann, Wert erneut abfragen

                            else
                            {

                                Console.WriteLine("Der Angegebene Winkel ist nicht korrekt.");
                                Console.WriteLine();
                                Console.WriteLine("Bitte geben Sie den Eingriffswinkel erneut an");
                                w = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine();

                                q += 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sie haben den Winkel 3 mal falsch angegeben");
                            Console.WriteLine();

                            n += 1;

                        }
                    }
                }

                //Falls mit NEIN genatwortet wird, wird mit dem norm Winkel gerechnet

                else
                {
                    w = 20;

                    k += 1;
                }

            } while (k < 1);

            return w;
        }




    }
}
