﻿using System;
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

            btn_GeaVeCatia.Visibility = Visibility.Hidden;
            btn_GeiVeCatia.Visibility = Visibility.Hidden;
            btn_SrVeCatia.Visibility = Visibility.Hidden;
            btn_PfVeCatia.Visibility = Visibility.Hidden;

            txt_GeaVeBreite.Clear();
            txt_GeaVeZaehnezahl.Clear();
            txt_GeaVeEingriffswinkel.Clear();
            txt_GeaVeTeilkreisdurchmesser.Clear();
            txt_GeaVeKopfspiel.Clear();
            txt_GeaVeModul.Clear();

            txt_GeiVeBreite.Clear();
            txt_GeiVeZaehnezahl.Clear();
            txt_GeiVeEingriffswinkel.Clear();
            txt_GeiVeTeilkreisdurchmesser.Clear();
            txt_GeiVeKopfspiel.Clear();
            txt_GeiVeModul.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();
            txt_SrVeModul.Clear();

            txt_PfVeBreite.Clear();
            txt_PfVeEingriffswinkel.Clear();
            txt_PfVeKopfspiel.Clear();
            txt_PfVeSchrägungswinkel.Clear();
            txt_PfVeTeilkreisdurchmesser.Clear();
            txt_PfVeZaehnezahl.Clear();
            txt_PfVeModul.Clear();

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

            btn_GeaVeCatia.Visibility = Visibility.Hidden;
            btn_GeiVeCatia.Visibility = Visibility.Hidden;
            btn_SrVeCatia.Visibility = Visibility.Hidden;
            btn_PfVeCatia.Visibility = Visibility.Hidden;

            txt_GeaVeBreite.Clear();
            txt_GeaVeZaehnezahl.Clear();
            txt_GeaVeEingriffswinkel.Clear();
            txt_GeaVeTeilkreisdurchmesser.Clear();
            txt_GeaVeKopfspiel.Clear();
            txt_GeaVeModul.Clear();

            txt_GeiVeBreite.Clear();
            txt_GeiVeZaehnezahl.Clear();
            txt_GeiVeEingriffswinkel.Clear();
            txt_GeiVeTeilkreisdurchmesser.Clear();
            txt_GeiVeKopfspiel.Clear();
            txt_GeiVeModul.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();
            txt_SrVeModul.Clear();

            txt_PfVeBreite.Clear();
            txt_PfVeEingriffswinkel.Clear();
            txt_PfVeKopfspiel.Clear();
            txt_PfVeSchrägungswinkel.Clear();
            txt_PfVeTeilkreisdurchmesser.Clear();
            txt_PfVeZaehnezahl.Clear();
            txt_PfVeModul.Clear();


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

            btn_GeaVeCatia.Visibility = Visibility.Hidden;
            btn_GeiVeCatia.Visibility = Visibility.Hidden;
            btn_SrVeCatia.Visibility = Visibility.Hidden;
            btn_PfVeCatia.Visibility = Visibility.Hidden;

            txt_GeaVeBreite.Clear();
            txt_GeaVeZaehnezahl.Clear();
            txt_GeaVeEingriffswinkel.Clear();
            txt_GeaVeTeilkreisdurchmesser.Clear();
            txt_GeaVeKopfspiel.Clear();
            txt_GeaVeModul.Clear();

            txt_GeiVeBreite.Clear();
            txt_GeiVeZaehnezahl.Clear();
            txt_GeiVeEingriffswinkel.Clear();
            txt_GeiVeTeilkreisdurchmesser.Clear();
            txt_GeiVeKopfspiel.Clear();
            txt_GeiVeModul.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();
            txt_SrVeModul.Clear();

            txt_PfVeBreite.Clear();
            txt_PfVeEingriffswinkel.Clear();
            txt_PfVeKopfspiel.Clear();
            txt_PfVeSchrägungswinkel.Clear();
            txt_PfVeTeilkreisdurchmesser.Clear();
            txt_PfVeZaehnezahl.Clear();
            txt_PfVeModul.Clear();

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

            btn_GeaVeCatia.Visibility = Visibility.Hidden;
            btn_GeiVeCatia.Visibility = Visibility.Hidden;
            btn_SrVeCatia.Visibility = Visibility.Hidden;
            btn_PfVeCatia.Visibility = Visibility.Hidden;

            txt_GeaVeBreite.Clear();
            txt_GeaVeZaehnezahl.Clear();
            txt_GeaVeEingriffswinkel.Clear();
            txt_GeaVeTeilkreisdurchmesser.Clear();
            txt_GeaVeKopfspiel.Clear();
            txt_GeaVeModul.Clear();

            txt_GeiVeBreite.Clear();
            txt_GeiVeZaehnezahl.Clear();
            txt_GeiVeEingriffswinkel.Clear();
            txt_GeiVeTeilkreisdurchmesser.Clear();
            txt_GeiVeKopfspiel.Clear();
            txt_GeiVeModul.Clear();

            txt_SrVeEingriffswinkel.Clear();
            txt_SrVeKopfspiel.Clear();
            txt_SrVeBreite.Clear();
            txt_SrVeSchrägungswinkel.Clear();
            txt_SrVeZaehnezahl.Clear();
            txt_SrVeTeilkreisdurchmesser.Clear();
            txt_SrVeModul.Clear();

            txt_PfVeBreite.Clear();
            txt_PfVeEingriffswinkel.Clear();
            txt_PfVeKopfspiel.Clear();
            txt_PfVeSchrägungswinkel.Clear();
            txt_PfVeTeilkreisdurchmesser.Clear();
            txt_PfVeZaehnezahl.Clear();
            txt_PfVeModul.Clear();

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





            string ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, BreiteEingabe, ModulEingabe;

            BreiteEingabe = txt_GeaVeBreite.Text;
            ZähnezahlEingabe = txt_GeaVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_GeaVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_GeaVeEingriffswinkel.Text;
            KopfspielEingabe = txt_GeaVeKopfspiel.Text;
            ModulEingabe = txt_GeaVeModul.Text;

            //Kontrollen/Tests der Eingaben
            
            
            
            if ( GaZahn.TestderModulEingabe(ModulEingabe) == 1 && GaZahn.TestderBreiteEingabe(BreiteEingabe) == 1 && GaZahn.TestderZähnezahlEingabe(ZähnezahlEingabe) == 1 && GaZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe) == 1 && GaZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe) == 1 && GaZahn.TestderKopfspielEingabe(KopfspielEingabe) == 1 && GaZahn.KontrolleWertebereichEingriffswinkel() == 1 && GaZahn.KontrolleWertebereichKopfspiel() == 1 )
            {
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

                    lbl_Gewicht.Content = Math.Round(GaZahn.VolumenBerechnen() * 0.00000785, 2);
                    lbl_Preis.Content = Math.Round(GaZahn.VolumenBerechnen() * 0.00000785 * 1.5, 2);

                }
                //Kunststoff
                if (cb_GeaVeMaterial.SelectedIndex == 2)
                {

                    lbl_Gewicht.Content = Math.Round(GaZahn.VolumenBerechnen() * 0.000002300, 4);
                    lbl_Preis.Content = Math.Round(GaZahn.VolumenBerechnen() * 0.000002300 * 0.4, 4);

                }
                //Messing
                if (cb_GeaVeMaterial.SelectedIndex == 3)
                {

                    lbl_Gewicht.Content = Math.Round(GaZahn.VolumenBerechnen() * 0.0000083, 2);
                    lbl_Preis.Content = Math.Round(GaZahn.VolumenBerechnen() * 0.0000083 * 3.35, 2);

                }


                grd_Ergebnisse.Visibility = Visibility.Visible;
                btn_GeaVeCatia.Visibility = Visibility.Visible;


            }
            else
            {
                btn_GeaVeCatia.Visibility = Visibility.Hidden;
                return;
            }
            

        }
        //Geradverzahnung innen Berechnen
        private void btn_GeiVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            GeradverzahnunginnenBerechnung GiZahn = new GeradverzahnunginnenBerechnung();





            string ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, BreiteEingabe, ModulEingabe;

            BreiteEingabe = txt_GeiVeBreite.Text;
            ZähnezahlEingabe = txt_GeiVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_GeiVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_GeiVeEingriffswinkel.Text;
            KopfspielEingabe = txt_GeiVeKopfspiel.Text;
            ModulEingabe = txt_GeiVeModul.Text;


            //Kontrollen/Tests der Eingaben

            if (GiZahn.TestderModulEingabe(ModulEingabe) == 1 && GiZahn.TestderBreiteEingabe(BreiteEingabe) == 1 && GiZahn.TestderZähnezahlEingabe(ZähnezahlEingabe) == 1 && GiZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe) == 1 && GiZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe) == 1 && GiZahn.TestderKopfspielEingabe(KopfspielEingabe) == 1 && GiZahn.KontrolleWertebereichEingriffswinkel() == 1 && GiZahn.KontrolleWertebereichKopfspiel() == 1)
            {
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

                    lbl_Gewicht.Content = Math.Round(GiZahn.VolumenBerechnen() * 0.00000785, 2);
                    lbl_Preis.Content = Math.Round(GiZahn.VolumenBerechnen() * 0.00000785 * 1.5, 2);

                }
                //Kunststoff
                if (cb_GeiVeMaterial.SelectedIndex == 2)
                {

                    lbl_Gewicht.Content = Math.Round(GiZahn.VolumenBerechnen() * 0.000002300, 4);
                    lbl_Preis.Content = Math.Round(GiZahn.VolumenBerechnen() * 0.000002300 * 0.4, 4);

                }
                //Messing
                if (cb_GeiVeMaterial.SelectedIndex == 3)
                {

                    lbl_Gewicht.Content = Math.Round(GiZahn.VolumenBerechnen() * 0.0000083, 2);
                    lbl_Preis.Content = Math.Round(GiZahn.VolumenBerechnen() * 0.0000083 * 3.35, 2);

                }


                grd_Ergebnisse.Visibility = Visibility.Visible;
                btn_GeiVeCatia.Visibility = Visibility.Visible;


            }
            else
            {
                btn_GeiVeCatia.Visibility = Visibility.Hidden;
                return;
            }


        }

        //Schrägverzahnung Berechnen
        private void btn_SrVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            SchrägverzahnungBerechnung SZahn = new SchrägverzahnungBerechnung();





            string  ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, Schrägungswinkeleingabe, BreiteEingabe, ModulEingabe;

            BreiteEingabe = txt_SrVeBreite.Text;
            ZähnezahlEingabe = txt_SrVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_SrVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_SrVeEingriffswinkel.Text;
            KopfspielEingabe = txt_SrVeKopfspiel.Text;
            Schrägungswinkeleingabe = txt_SrVeSchrägungswinkel.Text;
            ModulEingabe = txt_SrVeModul.Text;

            //Kontrollen/Tests der Eingaben

            if (SZahn.TestderSchrägungswinkelEingabe(Schrägungswinkeleingabe) == 1 && SZahn.KontrolleWertebereichSchrägungswinkel() == 1 && SZahn.TestderModulEingabe(ModulEingabe) == 1 && SZahn.TestderBreiteEingabe(BreiteEingabe) == 1 && SZahn.TestderZähnezahlEingabe(ZähnezahlEingabe) == 1 && SZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe) == 1 && SZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe) == 1 && SZahn.TestderKopfspielEingabe(KopfspielEingabe) == 1 && SZahn.KontrolleWertebereichEingriffswinkel() == 1 && SZahn.KontrolleWertebereichKopfspiel() == 1)
            {
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

                    lbl_Gewicht.Content = Math.Round(SZahn.VolumenBerechnen() * 0.00000785, 2);
                    lbl_Preis.Content = Math.Round(SZahn.VolumenBerechnen() * 0.00000785 * 1.5, 2);

                }
                //Kunststoff
                if (cb_SrVeMaterial.SelectedIndex == 2)
                {

                    lbl_Gewicht.Content = Math.Round(SZahn.VolumenBerechnen() * 0.000002300, 4);
                    lbl_Preis.Content = Math.Round(SZahn.VolumenBerechnen() * 0.000002300 * 0.4, 4);

                }
                //Messing
                if (cb_SrVeMaterial.SelectedIndex == 3)
                {

                    lbl_Gewicht.Content = Math.Round(SZahn.VolumenBerechnen() * 0.0000083, 2);
                    lbl_Preis.Content = Math.Round(SZahn.VolumenBerechnen() * 0.0000083 * 3.35, 2);

                }


                grd_Ergebnisse.Visibility = Visibility.Visible;
                btn_SrVeCatia.Visibility = Visibility.Visible;


            }
            else
            {
                btn_SrVeCatia.Visibility = Visibility.Hidden;
                return;
            }

        }
        //Pfeilverzahnung Berechnen
        private void btn_PfVe_berechnung_Click(object sender, RoutedEventArgs e)
        {

            PfeilverzahnungBerechnung PZahn = new PfeilverzahnungBerechnung();

            


            string ZähnezahlEingabe, TeilkreisdurchmesserEingabe, EingriffswinkelEingabe, KopfspielEingabe, Schrägungswinkeleingabe, BreiteEingabe, ModulEingabe;

            BreiteEingabe = txt_PfVeBreite.Text;
            ZähnezahlEingabe = txt_PfVeZaehnezahl.Text;
            TeilkreisdurchmesserEingabe = txt_PfVeTeilkreisdurchmesser.Text;
            EingriffswinkelEingabe = txt_PfVeEingriffswinkel.Text;
            KopfspielEingabe = txt_PfVeKopfspiel.Text;
            Schrägungswinkeleingabe = txt_PfVeSchrägungswinkel.Text;
            ModulEingabe = txt_PfVeModul.Text;

            //Kontrollen/Tests der Eingaben

            if (PZahn.TestderSchrägungswinkelEingabe(Schrägungswinkeleingabe) == 1 && PZahn.KontrolleWertebereichSchrägungswinkel() == 1 && PZahn.TestderModulEingabe(ModulEingabe) == 1 && PZahn.TestderBreiteEingabe(BreiteEingabe) == 1 && PZahn.TestderZähnezahlEingabe(ZähnezahlEingabe) == 1 && PZahn.TestdesTeilkreisdurchmessersEingabe(TeilkreisdurchmesserEingabe) == 1 && PZahn.TestderEingriffswinkelEingabe(EingriffswinkelEingabe) == 1 && PZahn.TestderKopfspielEingabe(KopfspielEingabe) == 1 && PZahn.KontrolleWertebereichEingriffswinkel() == 1 && PZahn.KontrolleWertebereichKopfspiel() == 1)
            {
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

                    lbl_Gewicht.Content = Math.Round(PZahn.VolumenBerechnen() * 0.00000785, 2);
                    lbl_Preis.Content = Math.Round(PZahn.VolumenBerechnen() * 0.00000785 * 1.5, 2);

                }
                //Kunststoff
                if (cb_PfVeMaterial.SelectedIndex == 2)
                {

                    lbl_Gewicht.Content = Math.Round(PZahn.VolumenBerechnen() * 0.000002300, 4);
                    lbl_Preis.Content = Math.Round(PZahn.VolumenBerechnen() * 0.000002300 * 0.4, 4);

                }
                //Messing
                if (cb_PfVeMaterial.SelectedIndex == 3)
                {

                    lbl_Gewicht.Content = Math.Round(PZahn.VolumenBerechnen() * 0.0000083, 2);
                    lbl_Preis.Content = Math.Round(PZahn.VolumenBerechnen() * 0.0000083 * 3.35, 2);

                }


                grd_Ergebnisse.Visibility = Visibility.Visible;
                btn_PfVeCatia.Visibility = Visibility.Visible;


            }
            else
            {

                btn_PfVeCatia.Visibility = Visibility.Hidden;
                return;
                
            }

        }

        private void btn_GeaVeCatia_Click(object sender, RoutedEventArgs e)
        {



        }

        private void btn_GeiVeCatia_Click(object sender, RoutedEventArgs e)
        {



        }

        private void btn_SrVeCatia_Click(object sender, RoutedEventArgs e)
        {



        }

        private void btn_PfVeCatia_Click(object sender, RoutedEventArgs e)
        {



        }
    }
}
