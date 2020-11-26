using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zahnrad_WPF
{
    class GeradverzahnungaußenBerechnung
    {
        //Eigenschaften
        public double Zähnezahl { get; set; }
        public double Teilkreisdurchmesser { get; set; }        
        public double Kopfspiel { get; set; }
        public double Eingriffswinkel { get; set; }
        public double Breite { get; set; }
        public double Modul { get; set; }


        //Methoden zur Kontrolle 

        //Test der Modul Eingabe
        internal void TestderModulEingabe(string ModulEingabe)
        {
           
                double KontrollierteModul;
                int n;
                n = 0;
                do
                {

                    if (double.TryParse(ModulEingabe, out KontrollierteModul))
                    {
                        n++;
                        Modul = KontrollierteModul;
                    }
                    else
                    {
                        MessageBox.Show("Falsche Zähnezahl Eingabe bitte Zahl eingeben", "Modul", MessageBoxButton.OK, MessageBoxImage.Error);
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
                    MessageBox.Show("Falsche Zähnezahl Eingabe bitte Zahl eingeben","Zähnezahl", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            } while (n < 1);
        }

        //Test der Breiteneingabe
        internal void TestderBreiteEingabe(string BreiteEingabe)
        {
            double KontrollierteBreite;
            int n;
            n = 0;
            do
            {

                if (double.TryParse(BreiteEingabe, out KontrollierteBreite))
                {
                    n++;
                    Breite = KontrollierteBreite;
                }
                else
                {
                    MessageBox.Show("Falsche Breite Eingabe bitte Zahl eingeben","Breite", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            } while (n < 1);
        }
        //Test der Teilkreisdurchmessereingabe

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
                    MessageBox.Show("Falsche Teilkreisdurchmessereingabe Eingabe bitte Zahl eingeben","Teilkreisdurchmesser", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            } while (n < 1);
        }
        //Test der Eingriffswinkeleingabe

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
                    MessageBox.Show("Ihr Eingriffswinkel wurde auf 20 gesetzt da falsche/keine Eingabe","Eingriffswinkel");
                    Eingriffswinkel = 20;
                    return;

                }
            } while (n < 1);
        }
        //Test der Kopfspieleingabe

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
                    
                    Kopfspiel = (Teilkreisdurchmesser/Zähnezahl) * 0.167;
                    MessageBox.Show("Ihr Kopfspiel wurde auf " + Kopfspiel + " gesetzt da falsche/keine Eingabe","Kopfspiel");
                    return;
                }

               
            } while (n < 1);
        }

        //Kontrolle des Wertebereiches für Eingriffswinkel

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
        //Kontrolle des Wertebereiches für Kopfspiel

        internal void KontrolleWertebereichKopfspiel()
        {
            int n;
            n = 0;
            do
            {

                if (Kopfspiel <= 0.3 * (Teilkreisdurchmesser / Zähnezahl) && Kopfspiel >= 0.1 * (Teilkreisdurchmesser / Zähnezahl))
                {
                    n++;

                }
                else
                {
                    MessageBox.Show("Bitte geben sie Zahlen im Wertebereich an (" + 0.1 * (Teilkreisdurchmesser / Zähnezahl) + " - " + 0.3 * (Teilkreisdurchmesser / Zähnezahl) + ") !", "Kopfspiel" , MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            } while (n < 1);
        }


        //Methoden zur Berechnung

        //Berechnung Zahnhöhe
        internal double ZahnhöheBerechen()
        {
            double ZahnhöheAusgabe;

            ZahnhöheAusgabe = 2 * (Teilkreisdurchmesser / Zähnezahl) + Kopfspiel;

            return Math.Round(ZahnhöheAusgabe, 3);
        }
        //Berechnung Zahnfußhöhe

        internal double ZahnfußhöheBerechnen()
        {
            double ZahnfußhöheAusgabe;

            ZahnfußhöheAusgabe = (Teilkreisdurchmesser / Zähnezahl) + Kopfspiel;

            return Math.Round(ZahnfußhöheAusgabe, 3);
        }
        //Berechnung Zahnkopfhöhe

        internal double ZahnkopfhöheBerechnen()
        {
            double ZahnkopfhöheAusgabe;

            ZahnkopfhöheAusgabe = (Teilkreisdurchmesser / Zähnezahl);

            return Math.Round(ZahnkopfhöheAusgabe, 3);
        }
        //Berechnung Teilung

        internal double TeilungBerechnen()
        {
            double TeilungAusgabe;

            TeilungAusgabe = Math.PI * (Teilkreisdurchmesser / Zähnezahl);

            return Math.Round(TeilungAusgabe, 3);
        }
        //Berechnung Fußkreisdurchmesser

        internal double FußkreisdurchmesserBerechnen()
        {
            double FußkreisdurchmesserAusgabe;

            FußkreisdurchmesserAusgabe = Teilkreisdurchmesser - 2 * ((Teilkreisdurchmesser / Zähnezahl) + Kopfspiel);

            return Math.Round(FußkreisdurchmesserAusgabe, 3);
        }
        //Berechnung Grundkreisdurchmesser

        internal double GrundkreisdurchmesserBerechnen()
        {
            double deg, GrundkreisdurchmesserAusgabe;
            deg = (Eingriffswinkel * (Math.PI)) / 180;
            GrundkreisdurchmesserAusgabe = (Teilkreisdurchmesser / Zähnezahl) * Zähnezahl * (Math.Cos(deg));
            return Math.Round(GrundkreisdurchmesserAusgabe, 3);
        }
        //Berechnung Kopfkreisdurchmesser

        internal double KopfkreisdurchmesserBerechnen()
        {
            double KopfkreisdurchmesserAusgabe;


            KopfkreisdurchmesserAusgabe = Teilkreisdurchmesser + 2 * (Teilkreisdurchmesser / Zähnezahl);


            return Math.Round(KopfkreisdurchmesserAusgabe, 3);
        }
        //Berechnung Volumen

        internal double VolumenBerechnen()
        {
            double VolumenAusgabe;

            VolumenAusgabe = Math.Pow(Teilkreisdurchmesser + 2 * (Teilkreisdurchmesser / Zähnezahl) / 2, 2) * Breite;

            return Math.Round(VolumenAusgabe, 2);
        }


      

    }
}
