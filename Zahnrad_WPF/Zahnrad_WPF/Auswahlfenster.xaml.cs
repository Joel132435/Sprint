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

        internal void trv_GeradverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Visible;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
            grd_Pfeilverzahnung.Visibility = Visibility.Hidden;

            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();


        }

        internal void trv_PfeilverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
            grd_Pfeilverzahnung.Visibility = Visibility.Visible;

            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();

        }

        internal void trv_SchraegverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Visible;
            grd_Pfeilverzahnung.Visibility = Visibility.Hidden;

            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();

        }

        internal void trv_DoppelschraegverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
            grd_Pfeilverzahnung.Visibility = Visibility.Hidden;

            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();
        }

        internal void trv_GeradverzahnungKegelraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Visible;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
            grd_Pfeilverzahnung.Visibility = Visibility.Hidden;

            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();

        }

        internal void trv_PfeilverzahnungKegelraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
            grd_Pfeilverzahnung.Visibility = Visibility.Visible;

            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();

        }

        internal void trv_GeradverzahnungSchnecke_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Visible;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
            grd_Pfeilverzahnung.Visibility = Visibility.Hidden;

            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();

        }

        internal void trv_BogenverzahnungSchnecke_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
            grd_Pfeilverzahnung.Visibility = Visibility.Hidden;

            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();

        }





        internal void trv_Stirnraeder_Selected(object sender, RoutedEventArgs e)
        {

        }

        internal void trv_Kegelraeder_Selected(object sender, RoutedEventArgs e)
        {

        }

        internal void trv_Schnecke_Selected(object sender, RoutedEventArgs e)
        {

        }

       
      
        private void btn_Schließen_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Soll das Programm beendet werden?", "Programmende", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                System.Environment.Exit(0);
        }

        private void btn_GeVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            GeradverzahnungBerechnung GZahn = new GeradverzahnungBerechnung();





            string ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, BreiteEingabe;

            BreiteEingabe = txt_GeVeBreite.Text;
            ZähnezahlEingabe = txt_GeVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_GeVeTeilkreisdurchmesser.Text;           
            EingriffswinkelEingabe = txt_GeVeEingriffswinkel.Text;
            KopfspielEingabe = txt_GeVeKopfspiel.Text;

            GZahn.TestderBreiteEingabe(BreiteEingabe);
            GZahn.TestderZähnezahlEingabe(ZähnezahlEingabe);
            GZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe);           
            GZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe);
            GZahn.TestderKopfspielEingabe(KopfspielEingabe);
            GZahn.KontrolleWertebereichEingriffswinkel();
            GZahn.KontrolleWertebereichKopfspiel();

            lbl_Zahnhöhe.Content = GZahn.ZahnhöheBerechen();
            lbl_Zahnfußhöhe.Content = GZahn.ZahnfußhöheBerechnen();
            lbl_Zahnkopfhöhe.Content = GZahn.ZahnkopfhöheBerechnen();
            lbl_Teilung.Content = GZahn.TeilungBerechnen();
            lbl_Fußkreisdurchmesser.Content = GZahn.FußkreisdurchmesserBerechnen();
            lbl_Grundkreisdurchmesser.Content = GZahn.GrundkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = GZahn.KopfkreisdurchmesserBerechnen();                   
            lbl_Kopfkreisdurchmesser.Content = GZahn.KopfkreisdurchmesserBerechnen();

           
                if (cb_GeVeMaterial.SelectedIndex == 1)
                {

                    lbl_Gewicht.Content = GZahn.GewichtStahlBerechnen();
                    lbl_Preis.Content = GZahn.PreisStahlBerechnen();

                }
                if (cb_GeVeMaterial.SelectedIndex == 2)
                {

                    lbl_Gewicht.Content = GZahn.GewichtKunstoffBerechnen();
                    lbl_Preis.Content = GZahn.PreisKunstoffBerechnen();

                }
                if (cb_GeVeMaterial.SelectedIndex == 3)
                {

                    lbl_Gewicht.Content = GZahn.GewichtGusseisenBerechnen();
                    lbl_Preis.Content = GZahn.PreisGusseisenBerechnen();

                }

            


        }

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

            SZahn.TestderSchrägungswinkelEingabe(Schrägungswinkeleingabe);
            SZahn.TestderBreiteEingabe(BreiteEingabe);
            SZahn.TestderZähnezahlEingabe(ZähnezahlEingabe);
            SZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe);
            SZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe);
            SZahn.TestderKopfspielEingabe(KopfspielEingabe);
            SZahn.KontrolleWertebereichEingriffswinkel();
            SZahn.KontrolleWertebereichKopfspiel();
            SZahn.KontrolleWertebereichSchrägungswinkel();


            lbl_Zahnhöhe.Content = SZahn.ZahnhöheBerechen();
            lbl_Zahnfußhöhe.Content = SZahn.ZahnfußhöheBerechnen();
            lbl_Zahnkopfhöhe.Content = SZahn.ZahnkopfhöheBerechnen();
            lbl_Teilung.Content = SZahn.TeilungBerechnen();
            lbl_Fußkreisdurchmesser.Content = SZahn.FußkreisdurchmesserBerechnen();
            lbl_Grundkreisdurchmesser.Content = SZahn.GrundkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = SZahn.KopfkreisdurchmesserBerechnen();          
            lbl_Kopfkreisdurchmesser.Content = SZahn.KopfkreisdurchmesserBerechnen();

            if (cb_SrVeMaterial.SelectedIndex == 1)
            {

                lbl_Gewicht.Content = SZahn.GewichtStahlBerechnen();
                lbl_Preis.Content = SZahn.PreisStahlBerechnen();

            }
            if (cb_SrVeMaterial.SelectedIndex == 2)
            {

                lbl_Gewicht.Content = SZahn.GewichtKunstoffBerechnen();
                lbl_Preis.Content = SZahn.PreisKunstoffBerechnen();

            }
            if (cb_SrVeMaterial.SelectedIndex == 3)
            {

                lbl_Gewicht.Content = SZahn.GewichtGusseisenBerechnen();
                lbl_Preis.Content = SZahn.PreisGusseisenBerechnen();

            }
        }

        private void btn_PfVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            PfeilverzahnungBerechnung PZahn = new PfeilverzahnungBerechnung();





            string ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, Schrägungswinkeleingabe, BreiteEingabe;

            BreiteEingabe = txt_SrVeBreite.Text;
            ZähnezahlEingabe = txt_SrVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_SrVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_SrVeEingriffswinkel.Text;
            KopfspielEingabe = txt_SrVeKopfspiel.Text;
            Schrägungswinkeleingabe = txt_SrVeSchrägungswinkel.Text;

            PZahn.TestderSchrägungswinkelEingabe(Schrägungswinkeleingabe);
            PZahn.TestderBreiteEingabe(BreiteEingabe);
            PZahn.TestderZähnezahlEingabe(ZähnezahlEingabe);
            PZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe);
            PZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe);
            PZahn.TestderKopfspielEingabe(KopfspielEingabe);
            PZahn.KontrolleWertebereichEingriffswinkel();
            PZahn.KontrolleWertebereichKopfspiel();
            PZahn.KontrolleWertebereichSchrägungswinkel();


            lbl_Zahnhöhe.Content = PZahn.ZahnhöheBerechen();
            lbl_Zahnfußhöhe.Content = PZahn.ZahnfußhöheBerechnen();
            lbl_Zahnkopfhöhe.Content = PZahn.ZahnkopfhöheBerechnen();
            lbl_Teilung.Content = PZahn.TeilungBerechnen();
            lbl_Fußkreisdurchmesser.Content = PZahn.FußkreisdurchmesserBerechnen();
            lbl_Grundkreisdurchmesser.Content = PZahn.GrundkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = PZahn.KopfkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = PZahn.KopfkreisdurchmesserBerechnen();

            if (cb_PfVeMaterial.SelectedIndex == 1)
            {

                lbl_Gewicht.Content = PZahn.GewichtStahlBerechnen();
                lbl_Preis.Content = PZahn.PreisStahlBerechnen();

            }
            if (cb_PfVeMaterial.SelectedIndex == 2)
            {

                lbl_Gewicht.Content = PZahn.GewichtKunstoffBerechnen();
                lbl_Preis.Content = PZahn.PreisKunstoffBerechnen();

            }
            if (cb_PfVeMaterial.SelectedIndex == 3)
            {

                lbl_Gewicht.Content = PZahn.GewichtGusseisenBerechnen();
                lbl_Preis.Content = PZahn.PreisGusseisenBerechnen();

            }
        }



    }
}
