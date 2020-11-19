using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zahnrad_WPF
{
    class GeradverzahnungBerechnung
    {
        //Eigenschaften
        public double Zähnezahl { get; set; }
        public double Teilkreisdurchmesser { get; set; }        
        public double Modul { get; set; }
        public double Kopfspiel { get; set; }
        public double Eingriffswinkel { get; set; }



        //Methoden zur Kontrolle 
        internal void TestderModulEingabe(string ModulEingabe)
        {
            double KontrolliertesModul;
            int n;
            n = 0;
            do
            {

                if (double.TryParse(ModulEingabe, out KontrolliertesModul))
                {
                    n++;
                    Modul = KontrolliertesModul;
                }
                else
                {
                    MessageBox.Show("Falsche Modul Eingabe bitte Zahl eingeben");
                    return;
                }
            } while (n < 1);
           
        }

        internal void TestderZähnezahlEingabe(string ZähnezahlEingabe)
        {
            double KontrollierteZähnezahl;
            int n;
            n = 0;
            do
            {

                if (double.TryParse(ZähnezahlEingabe, out KontrollierteZähnezahl))
                {
                    n++;
                    Zähnezahl = KontrollierteZähnezahl;
                }
                else
                {
                    MessageBox.Show("Falsche Zähnezahl Eingabe bitte Zahl eingeben");
                    return;
                }
            } while (n < 1);
        }

        internal void TestdesTeilkreisdurchmessersEingabe(string TeilkreisdurchmesserEingabe)
        {
            double KontrollierterTeilkreisdurchmesser;
            int n;
            n = 0;
            do
            {

                if (double.TryParse(TeilkreisdurchmesserEingabe, out KontrollierterTeilkreisdurchmesser))
                {
                    n++;
                    Teilkreisdurchmesser = KontrollierterTeilkreisdurchmesser;
                }
                else
                {
                    MessageBox.Show("Falsche Teilkreisdurchmessereingabe Eingabe bitte Zahl eingeben");
                    return;
                }
            } while (n < 1);
        }

        internal void TestderEingriffswinkelEingabe(string EingriffswinkelEingabe)
        {
            double KontrollierterEigriffswinkel;
            int n;
            n = 0;
            do
            {

                if (double.TryParse(EingriffswinkelEingabe, out KontrollierterEigriffswinkel))
                {
                    Eingriffswinkel = KontrollierterEigriffswinkel;
                    n++;
                }
                else
                {
                    MessageBox.Show("Ihr Eingriffswinkel wurde auf 20 gesetzt da falsche Eingabe");
                    Eingriffswinkel = 20;
                    return;

                }
            } while (n < 1);
        }

        internal void TestderKopfspielEingabe(string KopfspielEingabe)
        {
            double KontrolliertesKopfspiel;
            int n;
            n = 0;
            do
            {

                if (double.TryParse(KopfspielEingabe, out KontrolliertesKopfspiel))
                {
                    n++;
                    Kopfspiel = KontrolliertesKopfspiel;
                }
                else
                {
                    
                    Kopfspiel = Modul * 0.167;
                    MessageBox.Show("Ihr Kopfspiel wurde auf " + Kopfspiel + " gesetzt da falsche Eingabe");
                    return;
                }

               
            } while (n < 1);
        }


        internal void KontrolleWertebereichEingriffswinkel()
        {

            int n;
            n = 0;
            do
            {

                if (Eingriffswinkel <= 90 && Eingriffswinkel > 0)
                {
                    n++;

                }
                else
                {

                    MessageBox.Show("Bitte geben sie Winkel im Wertebereich an (0 - 90) !", "Eingriffswinkel", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            } while (n < 1);
        }

        internal void KontrolleWertebereichKopfspiel()
        {
            int n;
            n = 0;
            do
            {

                if (Kopfspiel <= 0.3 * Modul && Kopfspiel >= 0.1 * Modul)
                {
                    n++;

                }
                else
                {
                    MessageBox.Show("Bitte geben sie Zahlen im Wertebereich an (" + 0.1 * Modul + " - " + 0.3 * Modul + ") !", "Kopfspiel" , MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            } while (n < 1);
        }

               
        //Methoden zur Berechnung


        internal double ZahnhöheBerechen()
        {
            double ZahnhöheAusgabe;

            ZahnhöheAusgabe = 2 * Modul + Kopfspiel;

            return ZahnhöheAusgabe;
        }

        internal double ZahnfußhöheBerechnen()
        {
            double ZahnfußhöheAusgabe;

            ZahnfußhöheAusgabe = Modul + Kopfspiel;

            return ZahnfußhöheAusgabe;
        }

        internal double ZahnkopfhöheBerechnen()
        {
            double ZahnkopfhöheAusgabe;

            ZahnkopfhöheAusgabe = Modul;

            return ZahnkopfhöheAusgabe;
        }

        internal double TeilungBerechnen()
        {
            double TeilungAusgabe;

            TeilungAusgabe = Math.PI * Modul;

            return TeilungAusgabe;
        }

        internal double FußkreisdurchmesserBerechnen()
        {
            double FußkreisdurchmesserAusgabe;

            FußkreisdurchmesserAusgabe = Teilkreisdurchmesser - (2 * (Modul + Kopfspiel));

            return FußkreisdurchmesserAusgabe;
        }

        internal double GrundkreisdurchmesserBerechnen()
        {
            double deg, GrundkreisdurchmesserAusgabe;
            deg = (Eingriffswinkel * (Math.PI)) / 180;
            GrundkreisdurchmesserAusgabe = Modul * Zähnezahl * (Math.Cos(deg));
            return GrundkreisdurchmesserAusgabe;
        }

        internal double KopfkreisdurchmesserBerechnen()
        {
            double KopfkreisdurchmesserAusgabe;


            KopfkreisdurchmesserAusgabe = Teilkreisdurchmesser + 2 * Modul;


            return KopfkreisdurchmesserAusgabe;
        }

        
        internal double GewichtBerechnen()
        {
            return 0;
        }

        internal double PreisBerechnen()
        {
            return 0;
        }
    }
}
