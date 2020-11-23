using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zahnrad_WPF
{
    /// <summary>
    /// Interaktionslogik für Auswahlfenster.xaml
    /// </summary>
    public partial class Auswahlfenster : Window
    {
              
        public Auswahlfenster()
        {
           
            
            InitializeComponent();
        }
        //Geradverzahnung innen Fenster öffnen und andere Fenster schließen und letzte eingaben löschen
        internal void trv_GeradverzahnunginnenStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Geradverzahnunginnen.Visibility = Visibility.Visible;
            grd_Geradverzahnungaußen.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
            grd_Pfeilverzahnung.Visibility = Visibility.Hidden;

            brd_StirnradGeradverzahnungaußenBild.Visibility = Visibility.Hidden;
            brd_StirnradGeradverzahnunginnenBild.Visibility = Visibility.Visible;
            brd_StirnradPfeilverzahnungBild.Visibility = Visibility.Hidden;
            brd_StirnradSchrägverzahnungBild.Visibility = Visibility.Hidden;

            txt_GeaVeBreite.Clear();
            txt_GeaVeZaehnezahl.Clear();
            txt_GeaVeEingriffswinkel.Clear();
            txt_GeaVeTeilkreisdurchmesser.Clear();
            txt_GeaVeKopfspiel.Clear();

            txt_GeiVeBreite.Clear();
            txt_GeiVeZaehnezahl.Clear();
            txt_GeiVeEingriffswinkel.Clear();
            txt_GeiVeTeilkreisdurchmesser.Clear();
            txt_GeiVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();

            txt_PfVeBreite.Clear();
            txt_PfVeEingriffswinkel.Clear();
            txt_PfVeKopfspiel.Clear();
            txt_PfVeSchrägungswinkel.Clear();
            txt_PfVeTeilkreisdurchmesser.Clear();
            txt_PfVeZaehnezahl.Clear();

        }
        //Geradverzahnung außen Fenster öffnen und andere Fenster schließen und letzte eingaben löschen
        internal void trv_GeradverzahnungaußenStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Geradverzahnunginnen.Visibility = Visibility.Hidden;
            grd_Geradverzahnungaußen.Visibility = Visibility.Visible;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
            grd_Pfeilverzahnung.Visibility = Visibility.Hidden;

            brd_StirnradGeradverzahnungaußenBild.Visibility = Visibility.Visible;
            brd_StirnradGeradverzahnunginnenBild.Visibility = Visibility.Hidden;
            brd_StirnradPfeilverzahnungBild.Visibility = Visibility.Hidden;
            brd_StirnradSchrägverzahnungBild.Visibility = Visibility.Hidden;

            txt_GeaVeBreite.Clear();
            txt_GeaVeZaehnezahl.Clear();
            txt_GeaVeEingriffswinkel.Clear();
            txt_GeaVeTeilkreisdurchmesser.Clear();
            txt_GeaVeKopfspiel.Clear();

            txt_GeiVeBreite.Clear();
            txt_GeiVeZaehnezahl.Clear();
            txt_GeiVeEingriffswinkel.Clear();
            txt_GeiVeTeilkreisdurchmesser.Clear();
            txt_GeiVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();

            txt_PfVeBreite.Clear();
            txt_PfVeEingriffswinkel.Clear();
            txt_PfVeKopfspiel.Clear();
            txt_PfVeSchrägungswinkel.Clear();
            txt_PfVeTeilkreisdurchmesser.Clear();
            txt_PfVeZaehnezahl.Clear();


        }
        //Pfeilverzahnung Fenster öffnen und andere Fenster schließen und letzte eingaben löschen
        internal void trv_PfeilverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Geradverzahnunginnen.Visibility = Visibility.Hidden;
            grd_Geradverzahnungaußen.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
            grd_Pfeilverzahnung.Visibility = Visibility.Visible;

            brd_StirnradGeradverzahnungaußenBild.Visibility = Visibility.Hidden;
            brd_StirnradGeradverzahnunginnenBild.Visibility = Visibility.Hidden;
            brd_StirnradPfeilverzahnungBild.Visibility = Visibility.Visible;
            brd_StirnradSchrägverzahnungBild.Visibility = Visibility.Hidden;

            txt_GeaVeBreite.Clear();
            txt_GeaVeZaehnezahl.Clear();
            txt_GeaVeEingriffswinkel.Clear();
            txt_GeaVeTeilkreisdurchmesser.Clear();
            txt_GeaVeKopfspiel.Clear();

            txt_GeiVeBreite.Clear();
            txt_GeiVeZaehnezahl.Clear();
            txt_GeiVeEingriffswinkel.Clear();
            txt_GeiVeTeilkreisdurchmesser.Clear();
            txt_GeiVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();

            txt_PfVeBreite.Clear();
            txt_PfVeEingriffswinkel.Clear();
            txt_PfVeKopfspiel.Clear();
            txt_PfVeSchrägungswinkel.Clear();
            txt_PfVeTeilkreisdurchmesser.Clear();
            txt_PfVeZaehnezahl.Clear();

        }
        //Schrägverzahnung Fenster öffnen und andere Fenster schließen und letzte eingaben löschen
        internal void trv_SchraegverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Geradverzahnunginnen.Visibility = Visibility.Hidden;
            grd_Geradverzahnungaußen.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Visible;
            grd_Pfeilverzahnung.Visibility = Visibility.Hidden;

            brd_StirnradGeradverzahnungaußenBild.Visibility = Visibility.Hidden;
            brd_StirnradGeradverzahnunginnenBild.Visibility = Visibility.Hidden;
            brd_StirnradPfeilverzahnungBild.Visibility = Visibility.Hidden;
            brd_StirnradSchrägverzahnungBild.Visibility = Visibility.Visible;

            txt_GeaVeBreite.Clear();
            txt_GeaVeZaehnezahl.Clear();
            txt_GeaVeEingriffswinkel.Clear();
            txt_GeaVeTeilkreisdurchmesser.Clear();
            txt_GeaVeKopfspiel.Clear();

            txt_GeiVeBreite.Clear();
            txt_GeiVeZaehnezahl.Clear();
            txt_GeiVeEingriffswinkel.Clear();
            txt_GeiVeTeilkreisdurchmesser.Clear();
            txt_GeiVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();

            txt_PfVeBreite.Clear();
            txt_PfVeEingriffswinkel.Clear();
            txt_PfVeKopfspiel.Clear();
            txt_PfVeSchrägungswinkel.Clear();
            txt_PfVeTeilkreisdurchmesser.Clear();
            txt_PfVeZaehnezahl.Clear();

        }      
  

       
      //Programm beenden
        private void btn_Schließen_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Soll das Programm beendet werden?", "Programmende", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                System.Environment.Exit(0);
        }
        //Geradverzahnung außen Berechnen
        private void btn_GeaVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            GeradverzahnungaußenBerechnung GaZahn = new GeradverzahnungaußenBerechnung();





            string ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, BreiteEingabe;

            BreiteEingabe = txt_GeaVeBreite.Text;
            ZähnezahlEingabe = txt_GeaVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_GeaVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_GeaVeEingriffswinkel.Text;
            KopfspielEingabe = txt_GeaVeKopfspiel.Text;

            //Kontrollen/Tests der Eingaben

            GaZahn.TestderBreiteEingabe(BreiteEingabe);
            GaZahn.TestderZähnezahlEingabe(ZähnezahlEingabe);
            GaZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe);
            GaZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe);
            GaZahn.TestderKopfspielEingabe(KopfspielEingabe);
            GaZahn.KontrolleWertebereichEingriffswinkel();
            GaZahn.KontrolleWertebereichKopfspiel();

            //Ergebnis Ausgabe

            lbl_Zahnhöhe.Content = GaZahn.ZahnhöheBerechen();
            lbl_Zahnfußhöhe.Content = GaZahn.ZahnfußhöheBerechnen();
            lbl_Zahnkopfhöhe.Content = GaZahn.ZahnkopfhöheBerechnen();
            lbl_Teilung.Content = GaZahn.TeilungBerechnen();
            lbl_Fußkreisdurchmesser.Content = GaZahn.FußkreisdurchmesserBerechnen();
            lbl_Grundkreisdurchmesser.Content = GaZahn.GrundkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = GaZahn.KopfkreisdurchmesserBerechnen();
            lbl_Volumen.Content = GaZahn.VolumenBerechnen();

            //Stahl
            if (cb_GeaVeMaterial.SelectedIndex == 1)
            {

                lbl_Gewicht.Content = GaZahn.VolumenBerechnen() * 0.000785;
                lbl_Preis.Content = (GaZahn.VolumenBerechnen() * 0.000785) * 1.5;

            }
            //Kunststoff
            if (cb_GeaVeMaterial.SelectedIndex == 2)
            {

                lbl_Gewicht.Content = GaZahn.VolumenBerechnen() * 0.0000002300;
                lbl_Preis.Content = (GaZahn.VolumenBerechnen() * 0.0000002300) * 0.4;

            }
            //Messing
            if (cb_GeaVeMaterial.SelectedIndex == 3)
            {

                lbl_Gewicht.Content = GaZahn.VolumenBerechnen() * 0.00083;
                lbl_Preis.Content = (GaZahn.VolumenBerechnen() * 0.00083) * 3.35;

            }


            grd_Ergebnisse.Visibility = Visibility.Visible;

        }
        //Geradverzahnung innen Berechnen
        private void btn_GeiVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            GeradverzahnunginnenBerechnung GiZahn = new GeradverzahnunginnenBerechnung();





            string ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, BreiteEingabe;

            BreiteEingabe = txt_GeiVeBreite.Text;
            ZähnezahlEingabe = txt_GeiVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_GeiVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_GeiVeEingriffswinkel.Text;
            KopfspielEingabe = txt_GeiVeKopfspiel.Text;

            //Kontrollen/Tests der Eingaben

            GiZahn.TestderBreiteEingabe(BreiteEingabe);
            GiZahn.TestderZähnezahlEingabe(ZähnezahlEingabe);
            GiZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe);
            GiZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe);
            GiZahn.TestderKopfspielEingabe(KopfspielEingabe);
            GiZahn.KontrolleWertebereichEingriffswinkel();
            GiZahn.KontrolleWertebereichKopfspiel();

            //Ergebnis Ausgabe

            lbl_Zahnhöhe.Content = GiZahn.ZahnhöheBerechen();
            lbl_Zahnfußhöhe.Content = GiZahn.ZahnfußhöheBerechnen();
            lbl_Zahnkopfhöhe.Content = GiZahn.ZahnkopfhöheBerechnen();
            lbl_Teilung.Content = GiZahn.TeilungBerechnen();
            lbl_Fußkreisdurchmesser.Content = GiZahn.FußkreisdurchmesserBerechnen();
            lbl_Grundkreisdurchmesser.Content = GiZahn.GrundkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = GiZahn.KopfkreisdurchmesserBerechnen();
            lbl_Volumen.Content = GiZahn.VolumenBerechnen();

            //Stahl
            if (cb_GeiVeMaterial.SelectedIndex == 1)
            {

                lbl_Gewicht.Content = GiZahn.VolumenBerechnen() * 0.000785;
                lbl_Preis.Content = (GiZahn.VolumenBerechnen() * 0.000785) * 1.5;

            }
            //Kunststoff
            if (cb_GeiVeMaterial.SelectedIndex == 2)
            {

                lbl_Gewicht.Content = GiZahn.VolumenBerechnen() * 0.0000002300;
                lbl_Preis.Content = (GiZahn.VolumenBerechnen() * 0.0000002300) * 0.4;

            }
            //Messing
            if (cb_GeiVeMaterial.SelectedIndex == 3)
            {

                lbl_Gewicht.Content = GiZahn.VolumenBerechnen() * 0.00083;
                lbl_Preis.Content = (GiZahn.VolumenBerechnen() * 0.00083) * 3.35;

            }


            grd_Ergebnisse.Visibility = Visibility.Visible;

        }

        //Schrägverzahnung Berechnen
        private void btn_SrVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            SchrägverzahnungBerechnung SZahn = new SchrägverzahnungBerechnung();





            string  ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, Schrägungswinkeleingabe, BreiteEingabe;

            BreiteEingabe = txt_SrVeBreite.Text;
            ZähnezahlEingabe = txt_SrVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_SrVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_SrVeEingriffswinkel.Text;
            KopfspielEingabe = txt_SrVeKopfspiel.Text;
            Schrägungswinkeleingabe = txt_SrVeSchrägungswinkel.Text;

            //Kontrollen/Tests der Eingaben

            SZahn.TestderSchrägungswinkelEingabe(Schrägungswinkeleingabe);
            SZahn.TestderBreiteEingabe(BreiteEingabe);
            SZahn.TestderZähnezahlEingabe(ZähnezahlEingabe);
            SZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe);
            SZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe);
            SZahn.TestderKopfspielEingabe(KopfspielEingabe);
            SZahn.KontrolleWertebereichEingriffswinkel();
            SZahn.KontrolleWertebereichKopfspiel();
            SZahn.KontrolleWertebereichSchrägungswinkel();

            //Ergebnis Ausgabe

            lbl_Zahnhöhe.Content = SZahn.ZahnhöheBerechen();
            lbl_Zahnfußhöhe.Content = SZahn.ZahnfußhöheBerechnen();
            lbl_Zahnkopfhöhe.Content = SZahn.ZahnkopfhöheBerechnen();
            lbl_Teilung.Content = SZahn.TeilungBerechnen();
            lbl_Fußkreisdurchmesser.Content = SZahn.FußkreisdurchmesserBerechnen();
            lbl_Grundkreisdurchmesser.Content = SZahn.GrundkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = SZahn.KopfkreisdurchmesserBerechnen();          
            lbl_Volumen.Content = SZahn.VolumenBerechnen();

            //Stahl
            if (cb_SrVeMaterial.SelectedIndex == 1)
            {
                
                lbl_Gewicht.Content = SZahn.VolumenBerechnen() * 0.000785;
                lbl_Preis.Content = (SZahn.VolumenBerechnen() * 0.000785) * 1.5;

            }
            //Kunststoff
            if (cb_SrVeMaterial.SelectedIndex == 2)
            {

                lbl_Gewicht.Content = SZahn.VolumenBerechnen() * 0.0000002300;
                lbl_Preis.Content = (SZahn.VolumenBerechnen() * 0.0000002300) * 0.4;

            }
            //Messing
            if (cb_SrVeMaterial.SelectedIndex == 3)
            {

                lbl_Gewicht.Content = SZahn.VolumenBerechnen() * 0.00083;
                lbl_Preis.Content = (SZahn.VolumenBerechnen() * 0.00083) * 3.35;

            }

            grd_Ergebnisse.Visibility = Visibility.Visible;
        }
        //Pfeilverzahnung Berechnen
        private void btn_PfVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            PfeilverzahnungBerechnung PZahn = new PfeilverzahnungBerechnung();





            string ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, Schrägungswinkeleingabe, BreiteEingabe;

            BreiteEingabe = txt_PfVeBreite.Text;
            ZähnezahlEingabe = txt_PfVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_PfVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_PfVeEingriffswinkel.Text;
            KopfspielEingabe = txt_PfVeKopfspiel.Text;
            Schrägungswinkeleingabe = txt_PfVeSchrägungswinkel.Text;

            //Kontrollen/Tests der Eingaben

            PZahn.TestderSchrägungswinkelEingabe(Schrägungswinkeleingabe);
            PZahn.TestderBreiteEingabe(BreiteEingabe);
            PZahn.TestderZähnezahlEingabe(ZähnezahlEingabe);
            PZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe);
            PZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe);
            PZahn.TestderKopfspielEingabe(KopfspielEingabe);
            PZahn.KontrolleWertebereichEingriffswinkel();
            PZahn.KontrolleWertebereichKopfspiel();
            PZahn.KontrolleWertebereichSchrägungswinkel();

            //Ergebnis Ausgabe

            lbl_Zahnhöhe.Content = PZahn.ZahnhöheBerechen();
            lbl_Zahnfußhöhe.Content = PZahn.ZahnfußhöheBerechnen();
            lbl_Zahnkopfhöhe.Content = PZahn.ZahnkopfhöheBerechnen();
            lbl_Teilung.Content = PZahn.TeilungBerechnen();
            lbl_Fußkreisdurchmesser.Content = PZahn.FußkreisdurchmesserBerechnen();
            lbl_Grundkreisdurchmesser.Content = PZahn.GrundkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = PZahn.KopfkreisdurchmesserBerechnen();     
            lbl_Volumen.Content = PZahn.VolumenBerechnen();


            //Stahl
            if (cb_PfVeMaterial.SelectedIndex == 1)
            {

                lbl_Gewicht.Content = PZahn.VolumenBerechnen() * 0.000785;
                lbl_Preis.Content = (PZahn.VolumenBerechnen() * 0.000785) * 1.5;

            }
            //Kunststoff
            if (cb_PfVeMaterial.SelectedIndex == 2)
            {

                lbl_Gewicht.Content = PZahn.VolumenBerechnen() * 0.0000002300;
                lbl_Preis.Content = (PZahn.VolumenBerechnen() * 0.0000002300) * 4;

            }
            //Messing
            if (cb_PfVeMaterial.SelectedIndex == 3)
            {

                lbl_Gewicht.Content = PZahn.VolumenBerechnen() * 0.00083;
                lbl_Preis.Content = (PZahn.VolumenBerechnen() * 0.00083) * 3.35;

            }

            grd_Ergebnisse.Visibility = Visibility.Visible;
        }



    }
}
