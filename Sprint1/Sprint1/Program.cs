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
            double a, m, z, d, h, hf, ha, p, df, c, db, deg, x, y; //c1, c2, b,
            int n;
            

            Console.WriteLine("Bitte Geben Sie das Modul an.");
            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Bitte Geben Sie die Zähnezahl an.");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Bitte Geben Sie den Teilkreisdurchmesser an.");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            //Kopfspiel

            Console.WriteLine("Wollen Sie eine Kopfspiel angeben? (1 für JA und 2 für NEIN) ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            if (a < 2)
            {
                // x = unteres Kopfspiel / y = oberes Kopfspiel
                x = 0.1 * m;
                y = 0.3 * m;


                n = 0;
                                

                // Abfrage des Kopfspiels

                Console.WriteLine("Bitte geben Sie das Kopfspiel an");
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                // Abfrage ob das Kopfspiel zutreffen kann

                while (n < 1)
                {

                    
                    //Wenn das Kopfspiel zutrifft beendung der while-Schleife
                    if ((c >= x) & (c <= y)) 
                    {

                        n += 1;

                    }
                    //Falls das Kopfspiel nicht zutrifft, Wert erneut abfragen
                    else
                    {

                        Console.WriteLine("Der Angegebene Wert ist nicht korrekt.");
                        Console.WriteLine();
                        Console.WriteLine("Bitte geben Sie das Kopfspiel an");
                        c = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine();

                        
                    }

                }

            }
            //Falls mit NEIN genatwortet wird, wird mit dem häufig verwendeten Wert gerechnet
            else
            {
                c = m * 0.167;
            }


            //________________________________________________________________

            //Folgenes wird nicht gebraucht


            //Console.WriteLine("Bitte Geben Sie die Breite an.");

            //b = Convert.ToDouble(Console.ReadLine());


            //________________________________________________________________


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

            deg = (20 * (Math.PI)) / 180;

            db = m * z * (Math.Cos(deg));

            Console.WriteLine("Grundkreisdurchmesser = " + db);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
