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
            double m, z, d, h1, h2, h3, hf, ha, p, df ,c1 , c2 , c3 ,da;

            Console.WriteLine("Bitte Geben Sie das Modul an.");

            m = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Bitte Geben Sie die Zähnezahl an.");

            z = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Bitte Geben Sie den Teilkreisdurchmesser an.");

            d = Convert.ToDouble(Console.ReadLine());


            c1 = m * 0.1;

            c2 = m * 0.3;

            c3 = m * 0.167;

            h1 = 2 * m + c1;

            h2 = 2 * m + c2;

            h3 = 2 * m + c3;

            ha = m;

            hf = m * c3;

            p = Math.PI * m;

            d = m * z;

            df = d + 2 * (m + c3);

            da = d - 2 * m ;

            Console.WriteLine();

            Console.WriteLine("Zahnhöhe ≈ " + h3);
            Console.WriteLine();

            Console.WriteLine("Zahnfußhöhe = " + ha);
            Console.WriteLine();

            Console.WriteLine("Zahnkopfhöhe ≈ " + hf);
            Console.WriteLine();

            Console.WriteLine("Teilung = " + p);
            Console.WriteLine();

            Console.WriteLine("Fußkreisdurchmesser ≈ " + df);
            Console.WriteLine();

            Console.WriteLine("Kopfkreisdurchmesser = " + da);
            Console.WriteLine();



            Console.ReadKey();


        }
    }
}
