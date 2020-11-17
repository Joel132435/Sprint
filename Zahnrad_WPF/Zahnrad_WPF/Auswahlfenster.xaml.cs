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

            txt_GeVeModul.Clear();
            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();
            txt_GeVeProfilverschiebung.Clear();

        }

        internal void trv_PfeilverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;

        }

        internal void trv_SchraegverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;

        }

        internal void trv_DoppelschraegverzahnungStirnraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;
        }

        internal void trv_GeradverzahnungKegelraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Visible;

            txt_GeVeModul.Clear();
            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();
            txt_GeVeProfilverschiebung.Clear();
        }

        internal void trv_PfeilverzahnungKegelraeder_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;

        }

        internal void trv_GeradverzahnungSchnecke_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Visible;

            txt_GeVeModul.Clear();
            txt_GeVeBreite.Clear();
            txt_GeVeZaehnezahl.Clear();
            txt_GeVeEingriffswinkel.Clear();
            txt_GeVeTeilkreisdurchmesser.Clear();
            txt_GeVeKopfspiel.Clear();
            txt_GeVeProfilverschiebung.Clear();
        }

        internal void trv_BogenverzahnungSchnecke_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_Geradverzahnung.Visibility = Visibility.Hidden;

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

            GeradverzahnungBerechnung geradZahn1 = new GeradverzahnungBerechnung();





            string ModulEingabe, ZähnezahlEingabe, TeilkreisdurchmesserEingabe, BreiteEingabe, EIngriffswinkelEingabe, KopfspielEingabe;

            ModulEingabe = txt_GeVeModul.Text;
            ZähnezahlEingabe = txt_GeVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_GeVeTeilkreisdurchmesser.Text;
            BreiteEingabe = txt_GeVeBreite.Text;
            EIngriffswinkelEingabe = txt_GeVeEingriffswinkel.Text;
            KopfspielEingabe = txt_GeVeKopfspiel.Text;

            geradZahn1.TestderModulEingabe(ModulEingabe);
            geradZahn1.TestderZähnezahlEingabe(ZähnezahlEingabe);
            geradZahn1.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe);
            geradZahn1.TestderBreiteEingabe(BreiteEingabe);
            geradZahn1.TestderEingriffswinkelEingabe(EIngriffswinkelEingabe);
            geradZahn1.TestderKopfspielEingabe(KopfspielEingabe);

            geradZahn1.KontrolleWertebereichEingriffswinkel();
            geradZahn1.KontrolleWertebereichKopfspiel();


            lbl_Zahnhöhe.Content = geradZahn1.ZahnhöheBerechen();
            lbl_Zahnfußhöhe.Content = geradZahn1.ZahnfußhöheBerechnen();
            lbl_Zahnkopfhöhe.Content = geradZahn1.ZahnkopfhöheBerechnen();
            lbl_Teilung.Content = geradZahn1.TeilungBerechnen();
            lbl_Fußkreisdurchmesser.Content = geradZahn1.FußkreisdurchmesserBerechnen();
            lbl_Grundkreisdurchmesser.Content = geradZahn1.GrundkreisdurchmesserBerechnen();
            lbl_Kopfkreisdurchmesser.Content = geradZahn1.KopfkreisdurchmesserBerechnen();
            lbl_Zahnfußfestigkeit.Content = geradZahn1.ZahnfußfestigkeitBerechnen();
            lbl_Zahnflankenfestigkeit.Content = geradZahn1.ZahnflankenfestigkeitBerechnen();
            lbl_Gewicht.Content = geradZahn1.GewichtBerechnen();
            lbl_Preis.Content = geradZahn1.PreisBerechnen();





        }
    }
}
