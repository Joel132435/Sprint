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


        }

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


        }

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

        }

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

        }      
  

       
      
        private void btn_Schließen_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Soll das Programm beendet werden?", "Programmende", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                System.Environment.Exit(0);
        }

        private void btn_GeaVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            GeradverzahnungaußenBerechnung GaZahn = new GeradverzahnungaußenBerechnung();





            string ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, BreiteEingabe;

            BreiteEingabe = txt_GeaVeBreite.Text;
            ZähnezahlEingabe = txt_GeaVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_GeaVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_GeaVeEingriffswinkel.Text;
            KopfspielEingabe = txt_GeaVeKopfspiel.Text;

            GaZahn.TestderBreiteEingabe(BreiteEingabe);
            GaZahn.TestderZähnezahlEingabe(ZähnezahlEingabe);
            GaZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe);
            GaZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe);
            GaZahn.TestderKopfspielEingabe(KopfspielEingabe);
            GaZahn.KontrolleWertebereichEingriffswinkel();
            GaZahn.KontrolleWertebereichKopfspiel();

            lbl_Zahnhöhe.Content = GaZahn.ZahnhöheBerechen();
            lbl_Zahnfußhöhe.Content = GaZahn.ZahnfußhöheBerechnen();
            lbl_Zahnkopfhöhe.Content = GaZahn.ZahnkopfhöheBerechnen();
            lbl_Teilung.Content = GaZahn.TeilungBerechnen();
            lbl_Fußkreisdurchmesser.Content = GaZahn.FußkreisdurchmesserBerechnen();
            lbl_Grundkreisdurchmesser.Content = GaZahn.GrundkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = GaZahn.KopfkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = GaZahn.KopfkreisdurchmesserBerechnen();
            lbl_Volumen.Content = GaZahn.VolumenBerechnen();

            if (cb_GeaVeMaterial.SelectedIndex == 1)
            {

                lbl_Gewicht.Content = GaZahn.GewichtStahlBerechnen();
                lbl_Preis.Content = GaZahn.PreisStahlBerechnen();

            }
            if (cb_GeaVeMaterial.SelectedIndex == 2)
            {

                lbl_Gewicht.Content = GaZahn.GewichtKunstoffBerechnen();
                lbl_Preis.Content = GaZahn.PreisKunstoffBerechnen();

            }
            if (cb_GeaVeMaterial.SelectedIndex == 3)
            {

                lbl_Gewicht.Content = GaZahn.GewichtGusseisenBerechnen();
                lbl_Preis.Content = GaZahn.PreisGusseisenBerechnen();

            }


            grd_Ergebnisse.Visibility = Visibility.Visible;

        }

        private void btn_GeiVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            GeradverzahnunginnenBerechnung GiZahn = new GeradverzahnunginnenBerechnung();





            string ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, BreiteEingabe;

            BreiteEingabe = txt_GeiVeBreite.Text;
            ZähnezahlEingabe = txt_GeiVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_GeiVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_GeiVeEingriffswinkel.Text;
            KopfspielEingabe = txt_GeiVeKopfspiel.Text;

            GiZahn.TestderBreiteEingabe(BreiteEingabe);
            GiZahn.TestderZähnezahlEingabe(ZähnezahlEingabe);
            GiZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe);
            GiZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe);
            GiZahn.TestderKopfspielEingabe(KopfspielEingabe);
            GiZahn.KontrolleWertebereichEingriffswinkel();
            GiZahn.KontrolleWertebereichKopfspiel();

            lbl_Zahnhöhe.Content = GiZahn.ZahnhöheBerechen();
            lbl_Zahnfußhöhe.Content = GiZahn.ZahnfußhöheBerechnen();
            lbl_Zahnkopfhöhe.Content = GiZahn.ZahnkopfhöheBerechnen();
            lbl_Teilung.Content = GiZahn.TeilungBerechnen();
            lbl_Fußkreisdurchmesser.Content = GiZahn.FußkreisdurchmesserBerechnen();
            lbl_Grundkreisdurchmesser.Content = GiZahn.GrundkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = GiZahn.KopfkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = GiZahn.KopfkreisdurchmesserBerechnen();
            lbl_Volumen.Content = GiZahn.VolumenBerechnen();

            if (cb_GeaVeMaterial.SelectedIndex == 1)
            {

                lbl_Gewicht.Content = GiZahn.GewichtStahlBerechnen();
                lbl_Preis.Content = GiZahn.PreisStahlBerechnen();

            }
            if (cb_GeaVeMaterial.SelectedIndex == 2)
            {

                lbl_Gewicht.Content = GiZahn.GewichtKunstoffBerechnen();
                lbl_Preis.Content = GiZahn.PreisKunstoffBerechnen();

            }
            if (cb_GeaVeMaterial.SelectedIndex == 3)
            {

                lbl_Gewicht.Content = GiZahn.GewichtGusseisenBerechnen();
                lbl_Preis.Content = GiZahn.PreisGusseisenBerechnen();

            }


            grd_Ergebnisse.Visibility = Visibility.Visible;

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
            lbl_Volumen.Content = SZahn.VolumenBerechnen();


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

            grd_Ergebnisse.Visibility = Visibility.Visible;
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
            lbl_Volumen.Content = PZahn.VolumenBerechnen();


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

            grd_Ergebnisse.Visibility = Visibility.Visible;
        }



    }
}
