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
            double m, z, d, h, hf, ha, p, df, c, db, deg, c1, c2 ,b;

            Console.WriteLine("Bitte Geben Sie das Modul an.");

            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Bitte Geben Sie die Zähnezahl an.");

            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Bitte Geben Sie den Teilkreisdurchmesser an.");

            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            //Wird nicht gebraucht


            //Console.WriteLine("Bitte Geben Sie die Breite an.");

            //b = Convert.ToDouble(Console.ReadLine());


            //Kopfspiel

            //c1 = m * 0.1;

            //c2 = m * 0.3;


            //Kopfspiel

            c = m * 0.167;


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
