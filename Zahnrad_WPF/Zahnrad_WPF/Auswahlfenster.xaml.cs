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

            txt_GeVeModul.Clear();           
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();
           

        }

        internal void trv_PfeilverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;

        }

        internal void trv_SchraegverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Visible;

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeModul.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();
            txt_SrVeZaehnezahl.Clear();
            
        }

        internal void trv_DoppelschraegverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;
        }

        internal void trv_GeradverzahnungKegelraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Visible;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;

            txt_GeVeModul.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();
            
        }

        internal void trv_PfeilverzahnungKegelraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;

        }

        internal void trv_GeradverzahnungSchnecke_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Visible;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;

            txt_GeVeModul.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();
            
        }

        internal void trv_BogenverzahnungSchnecke_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
            grd_Schrägverzahnung.Visibility = Visibility.Hidden;

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





            string ModulEingabe, ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe;

            ModulEingabe = txt_GeVeModul.Text;
            ZähnezahlEingabe = txt_GeVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_GeVeTeilkreisdurchmesser.Text;           
            EingriffswinkelEingabe = txt_GeVeEingriffswinkel.Text;
            KopfspielEingabe = txt_GeVeKopfspiel.Text;

            GZahn.TestderModulEingabe(ModulEingabe);
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
            lbl_Gewicht.Content = GZahn.GewichtBerechnen();
            lbl_Preis.Content = GZahn.PreisBerechnen();
            lbl_Kopfkreisdurchmesser.Content = GZahn.KopfkreisdurchmesserBerechnen();




        }

        private void btn_SrVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            SchrägverzahnungBerechnung SZahn = new SchrägverzahnungBerechnung();





            string ModulEingabe, ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, Schrägungswinkeleingabe;

            ModulEingabe = txt_SrVeModul.Text;
            ZähnezahlEingabe = txt_SrVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_SrVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_SrVeEingriffswinkel.Text;
            KopfspielEingabe = txt_SrVeKopfspiel.Text;
            Schrägungswinkeleingabe = txt_SrVeSchrägungswinkel.Text;

            SZahn.TestderSchrägungswinkelEingabe(Schrägungswinkeleingabe);
            SZahn.TestderModulEingabe(ModulEingabe);
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
            lbl_Gewicht.Content = SZahn.GewichtBerechnen();
            lbl_Preis.Content = SZahn.PreisBerechnen();
            lbl_Kopfkreisdurchmesser.Content = SZahn.KopfkreisdurchmesserBerechnen();







        }
        
    }
}
