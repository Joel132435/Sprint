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

            Console.WriteLine("Bitte Geben Sie die Zähnezahl an.");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Bitte Geben Sie den Teilkreisdurchmesser an.");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            //Modul

            m = d / z;

            Console.WriteLine("Modul = " + m);
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

            double min, max, l, c;

            //häufig verwendete Wert

            l = m * 0.167;

            // min = unteres Kopfspiel / max = oberes Kopfspiel

            min = 0.1 * m;
            max = 0.3 * m;

            //Abfrage ob ein Kopfspiel Angegeben werden soll

            Console.WriteLine("Wollen Sie ein Kopfspiel angeben?");
            Console.WriteLine("min Wert: " + min  "max Wert: " + max);
            Console.WriteLine("Wenn Sie mit Nein antworten wird ein häufig verwendetes Kopfspiel benutzt");
            Console.WriteLine("Häufiges Kopfspiel:" + l);
            Console.WriteLine("");

            //Unterprogramm zum Kopfspiel

            c = Wertabfrage(min, max, l);

            return c;
        }





        static double Eingriffswinkel()
        {
            double min, max, l, w;

            //norm Eingriffswinkel

            l = 20;

            // min = min Winkel / max = max Winkel

            min = 0;
            max = 90;        
            
            //Abfrage ob ein Eingriffswinkel Angegeben werden soll

            Console.WriteLine("Wollen Sie den Eingriffswinkel angeben?");
            Console.WriteLine("min Winkel " + min  "max Winkel: " + max);
            Console.WriteLine(" Wenn Sie mit Nein antworten wird der norm Winkel benutzt");
            Console.WriteLine("Norm Eingriffswinkel: " +l);
            Console.WriteLine("");

            //Unterprogramm zum Eingriffswinkel

            w = Wertabfrage(min, max, l);

            return w;
        }



        static double Wertabfrage(double min, double max, double l)
        {
            double res;
            int n, k, q;
            string a;

            k = 0;
            
            //do-while-Schleife (Um nach 3 mal falsch eingegebenen Wert noch mal die Chance zu haben zu entscheiden ob man einen Wert angeben will))
            do
            {

                // Ja / Nein Abfrage

                Console.WriteLine("Bitte mit Ja oder Nein antworten");
                a = Convert.ToString(Console.ReadLine());

                Console.WriteLine();


                // Switch abfrage ( Ja oder Nein )
                switch (a)
                {
                    case "Ja":
                    case "JA":
                    case "ja":

                        // Abfrage des Kopfspiels/Eingriffswinkels

                        Console.WriteLine("Bitte Wert eingeben");                            
                        res = Convert.ToDouble(Console.ReadLine());
                           
                        Console.WriteLine();
                                                    
                        n = 0;                           
                        q = 0;

                        //while-do-Schleife (Um die Abfrage 3 mal wiederholen zu können und immer wieder die Möglichkeit zu geben den Wert zu korrigieren)/ nicht unbedingt nötig (benutzt man nur damit ein "erneut" im abfrage text steht) 
                        do
                        {                              
                            //if-else-Schleife (damit der Wert 3 mal abgefragt wird wenn falsch)  
                            if (q < 2)
                            {

                                //Abfrage, ob das Kopfspiel/der Eingriffswinkel zutreffen kann
                                //Wenn das Kopfspiel/der Eingriffswinkel zutrifft: Beendung der do-while-Schleife                  
                                if ((res >= min) & (res <= max))
                                {
                                        
                                    n += 1;
                                        
                                    k += 1;
                                        
                                }
                                //Falls das Kopfspiel/der Eingriffswinkel nicht zutrifft, soll der Wert 3 mal erneut abgefragt werden                              
                                else
                                {
                                        
                                    Console.WriteLine("Der Angegebene Wert ist nicht korrekt!");                                        
                                    Console.WriteLine();
                                        
                                    Console.WriteLine("Bitte geben Sie den Wert erneut ein");                                        
                                    res = Convert.ToDouble(Console.ReadLine());
                                        
                                    Console.WriteLine();
                                        
                                    q += 1;
                                }

                            }
                            //Wenn der Wert 3 mal neu abgefragt wurde, wird n und s = 1 gesetzt ,damit man neu entscheiden kann, ob man einen Wert angeben will oder nicht
                            else
                            {
                                           
                                Console.WriteLine("Sie haben den Wert 3 mal falsch angegeben!");
                                Console.WriteLine("Sind Sie sicher dass Sie einen Wert angeben wollen?");
                                                                   
                                n += 1;
                                    
                            }

                        } while (n < 1);
                      
                        break;

                    case "Nein":
                    case "NEIN":
                    case "nein":

                        //Falls mit NEIN geantwortet wird, wird mit dem häufig verwendeten Wert gerechnet

                        res = l;

                        k += 1;

                        break;

                    default:

                        //Falls man nicht JA oder NEIN schreibt

                        res = 0;

                        break;

                }

            } while (k < 1);

            return res;



        }
    }
}
