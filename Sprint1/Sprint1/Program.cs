using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, z, d, h1, h2, h3, hf, ha, p, df ,c1 , c2 , c3 ,da ,b;

            Console.WriteLine("Bitte Geben Sie das Modul an.");

            m = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Bitte Geben Sie die Zähnezahl an.");

            z = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Bitte Geben Sie den Teilkreisdurchmesser an.");

            d = Convert.ToDouble(Console.ReadLine());

            //Wird nicht gebraucht

            //Console.WriteLine("Bitte Geben Sie die Breite an.");

            //b = Convert.ToDouble(Console.ReadLine());

            //c1 = m * 0.1;

            //c2 = m * 0.3;

            //h1 = 2 * m + c1;

            //h2 = 2 * m + c2;


            //Kopfspiel

            c3 = m * 0.167;

            Console.WriteLine();

            //Zahnhöhe
            h3 = 2 * m + c3;

            Console.WriteLine("Zahnhöhe ≈ " + h3);
            Console.WriteLine();

            //Zahnfußhöhe
            hf = m + c3;

            Console.WriteLine("Zahnfußhöhe = " + hf);
            Console.WriteLine();

            //Zahnkopfhöhe
            ha = m;

            Console.WriteLine("Zahnkopfhöhe ≈ " + ha);
            Console.WriteLine();

            //Teilung
            p = Math.PI * m;

            Console.WriteLine("Teilung = " + p);
            Console.WriteLine();

            //Fußkreisdurchmesser
            df = d - 2 * (m + c3);

            Console.WriteLine("Fußkreisdurchmesser ≈ " + df);
            Console.WriteLine();

            //Kopfkreisdurchmesser (Grundkreisdurchmesser ? )
            da = d + 2 * m;

            Console.WriteLine("Kopfkreisdurchmesser = " + da);
            Console.WriteLine();



            Console.ReadKey();


        }
    }
}
