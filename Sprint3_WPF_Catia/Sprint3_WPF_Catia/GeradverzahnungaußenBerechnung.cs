using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sprint3_WPF_Catia
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
        public double Kopfkreisdurchmesser { get; set; }
        public double Fußkreisdurchmesser { get; set; }
        public double Zahnhöhe { get; set; }
        public double Volumen { get; set; }
        public double Zahnfußhöhe { get; set; }
        public double Zahnkopfhöhe { get; set; }     
        public double TeilkreisRadius { get; set; }
        public double Grundkreisdurchmesser { get; set; }
        public double Teilung { get; set; }





        //Methoden zur Kontrolle 

        //Test der Modul Eingabe
        internal int TestderModulEingabe(string ModulEingabe)
        {


            double KontrollierteModul;

            if (double.TryParse(ModulEingabe, out KontrollierteModul))
            {

                Modul = KontrollierteModul;

                return 1;

            }

            else
            {

                MessageBox.Show("Falsche Modul Eingabe bitte Zahl eingeben", "Modul", MessageBoxButton.OK, MessageBoxImage.Error);

                return 0;

            }

        }

        internal int TestderZähnezahlEingabe(string ZähnezahlEingabe)
        {

            double KontrollierteZähnezahl;

            if (double.TryParse(ZähnezahlEingabe, out KontrollierteZähnezahl))
            {

                Zähnezahl = KontrollierteZähnezahl;
                return 1;

            }

            else
            {
                MessageBox.Show("Falsche Zähnezahl Eingabe bitte Zahl eingeben", "Zähnezahl", MessageBoxButton.OK, MessageBoxImage.Error);

                return 0;

            }

        }

        //Test der Breiteneingabe
        internal int TestderBreiteEingabe(string BreiteEingabe)
        {
            double KontrollierteBreite;

            if (double.TryParse(BreiteEingabe, out KontrollierteBreite))
            {

                Breite = KontrollierteBreite;
                return 1;

            }
            else
            {
                MessageBox.Show("Falsche Breite Eingabe bitte Zahl eingeben", "Breite", MessageBoxButton.OK, MessageBoxImage.Error);

                return 0;

            }

        }
        //Test der Teilkreisdurchmessereingabe

        internal int TestdesTeilkreisdurchmessersEingabe(string TeilkreisdurchmesserEingabe)
        {
            double KontrollierterTeilkreisdurchmesser;

            if (double.TryParse(TeilkreisdurchmesserEingabe, out KontrollierterTeilkreisdurchmesser))
            {

                Teilkreisdurchmesser = KontrollierterTeilkreisdurchmesser;
                return 1;

            }
            else
            {

                MessageBox.Show("Falsche Teilkreisdurchmessereingabe Eingabe bitte Zahl eingeben", "Teilkreisdurchmesser", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;

            }

        }
        //Test der Eingriffswinkeleingabe

        internal int TestderEingriffswinkelEingabe(string EingriffswinkelEingabe)
        {
            double KontrollierterEigriffswinkel;



            if (double.TryParse(EingriffswinkelEingabe, out KontrollierterEigriffswinkel))
            {
                Eingriffswinkel = KontrollierterEigriffswinkel;
                return 1;
            }
            else
            {
                MessageBox.Show("Ihr Eingriffswinkel wurde auf 20 gesetzt da falsche/keine Eingabe", "Eingriffswinkel");

                Eingriffswinkel = 20;

                return 1;

            }

        }
        //Test der Kopfspieleingabe

        internal int TestderKopfspielEingabe(string KopfspielEingabe)
        {
            double KontrolliertesKopfspiel;


            if (double.TryParse(KopfspielEingabe, out KontrolliertesKopfspiel))
            {

                Kopfspiel = KontrolliertesKopfspiel;

                return 1;

            }
            else
            {

                Kopfspiel = Modul * 0.167;

                MessageBox.Show("Ihr Kopfspiel wurde auf " + Kopfspiel + " gesetzt da falsche/keine Eingabe", "Kopfspiel");

                return 1;

            }



        }

        //Kontrolle des Wertebereiches für Eingriffswinkel

        internal int KontrolleWertebereichEingriffswinkel()
        {

            if (Eingriffswinkel <= 90 && Eingriffswinkel > 0)
            {
                return 1;
            }
            else
            {

                MessageBox.Show("Bitte geben sie Winkel im Wertebereich an (0 - 90) !", "Eingriffswinkel", MessageBoxButton.OK, MessageBoxImage.Error);

                return 0;

            }

        }
        //Kontrolle des Wertebereiches für Kopfspiel

        internal int KontrolleWertebereichKopfspiel()
        {



            if (Kopfspiel <= 0.3 * Modul && Kopfspiel >= 0.1 * Modul)
            {
                return 1;
            }
            else
            {

                MessageBox.Show("Bitte geben sie Zahlen im Wertebereich an (" + 0.1 * Modul + " - " + 0.3 * Modul + ") !", "Kopfspiel", MessageBoxButton.OK, MessageBoxImage.Error);

                return 0;

            }

        }


        //Methoden zur Berechnung

        //Berechnung Zahnhöhe
        internal double ZahnhöheBerechen()
        {
            

            Zahnhöhe = 2 * Modul + Kopfspiel;

            return Math.Round(Zahnhöhe, 3);
        }
        //Berechnung Zahnfußhöhe

        internal double ZahnfußhöheBerechnen()
        {
            

            Zahnfußhöhe = Modul + Kopfspiel;

            return Math.Round(Zahnfußhöhe, 3);
        }
        //Berechnung Zahnkopfhöhe

        internal double ZahnkopfhöheBerechnen()
        {
            

            Zahnkopfhöhe = Modul;

            return Math.Round(Zahnkopfhöhe, 3);
        }
        //Berechnung Teilung

        internal double TeilungBerechnen()
        {
            

            Teilung = Math.PI * Modul;

            return Math.Round(Teilung, 3);
        }
        //Berechnung Fußkreisdurchmesser

        internal double FußkreisdurchmesserBerechnen()
        {
           

            Fußkreisdurchmesser = Teilkreisdurchmesser - 2 * (Modul + Kopfspiel);

            return Math.Round(Fußkreisdurchmesser, 3);
        }
        //Berechnung Grundkreisdurchmesser

        internal double GrundkreisdurchmesserBerechnen()
        {
            double deg;
            deg = (Eingriffswinkel * (Math.PI)) / 180;
            Grundkreisdurchmesser = Modul * Zähnezahl * (Math.Cos(deg));
            return Math.Round(Grundkreisdurchmesser, 3);
        }
        //Berechnung Kopfkreisdurchmesser

        internal double KopfkreisdurchmesserBerechnen()
        {

            Kopfkreisdurchmesser = Teilkreisdurchmesser + 2 * Modul;


            return Math.Round(Kopfkreisdurchmesser, 3);
        }
        //Berechnung Volumen

        internal double VolumenBerechnen()
        {           

            Volumen = Math.Pow(Teilkreisdurchmesser + 2 * Modul / 2, 2) * Breite;

            return Math.Round(Volumen, 2);
        }

    }
}
