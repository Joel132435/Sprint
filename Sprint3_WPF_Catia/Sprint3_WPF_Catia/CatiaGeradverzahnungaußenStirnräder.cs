using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECMOD;
using INFITF;
using PARTITF;
using HybridShapeTypeLib;
using KnowledgewareTypeLib;
using ProductStructureTypeLib;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Runtime.CompilerServices;
//Zum Starten über Anwendung
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Sprint3_WPF_Catia
{
    class CatiaGeradverzahnungaußenStirnräder
    {

        INFITF.Application HSPGE_CatiaApp;
        MECMOD.PartDocument HSPGE_CatiaPart;
        MECMOD.Sketch HSPGE_catia_Profil;




        //Methode für Feststellung ob Catia läuft
        public bool CatiaLaeuft()
        {


            try
            {
                object catiaObject = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");

                HSPGE_CatiaApp = (INFITF.Application)catiaObject;
                return true;
            }

            catch (Exception)
            {
                return false;
            }

        }

        //Methode zur erstellung eines neuen Parts
        internal void ErzeugePart()
        {
            INFITF.Documents catDocuments1 = HSPGE_CatiaApp.Documents;
            HSPGE_CatiaPart = (PartDocument)catDocuments1.Add("Part");

        }

        //Erstellen einer neuen Skizze
        internal void ErzeugeSkizze()
        {


            HybridBodies catHybridBodies1 = HSPGE_CatiaPart.Part.HybridBodies;
            HybridBody catHybridBody1;

            try
            {
                catHybridBody1 = catHybridBodies1.Item("Geometrisches Set.1");
            }
            catch (Exception)
            {
                MessageBox.Show("Kein geometrisches Set gefunden! " + Environment.NewLine + "Ein PART manuell erzeugen und ein darauf achten, dass 'Geometisches Set' aktiviert ist.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Information);

                return;
            }

            catHybridBody1.set_Name("Profil");
            Sketches catSketch = catHybridBody1.HybridSketches;
            OriginElements catOriginElements = HSPGE_CatiaPart.Part.OriginElements;
            Reference catReferenz = (Reference)catOriginElements.PlaneYZ;

            HSPGE_catia_Profil = catSketch.Add(catReferenz);

            ErzeugeAchsensystem();

            HSPGE_CatiaPart.Part.Update();

        }

        private void ErzeugeAchsensystem()
        {
            object[] arr = new object[] {0.0, 0.0, 0.0,
                                         0.0, 1.0, 0.0,
                                         0.0, 0.0, 1.0 };
            HSPGE_catia_Profil.SetAbsoluteAxisData(arr);
        }








        internal void StirnradGeradverzahnung(GeradverzahnungaußenBerechnung gaBerechnung)
        {
            //Bennennung
            HSPGE_catia_Profil.set_Name("Stirnrad Geradverzahnung außen");
            Factory2D catFactory2D = HSPGE_catia_Profil.OpenEdition();


            Point2D catP2D_1 = catFactory2D.CreatePoint(0, (gaBerechnung.Fußkreisdurchmesser / 2));
            Point2D catP2D_2 = catFactory2D.CreatePoint(0, (gaBerechnung.Fußkreisdurchmesser / 2) + gaBerechnung.Zahnhöhe);
            Point2D catP2D_3 = catFactory2D.CreatePoint((gaBerechnung.Teilung / 2), (gaBerechnung.Fußkreisdurchmesser / 2) + gaBerechnung.Zahnhöhe);
            Point2D catP2D_4 = catFactory2D.CreatePoint((gaBerechnung.Teilung / 2), (gaBerechnung.Fußkreisdurchmesser / 2));
            Point2D catP2D_5 = catFactory2D.CreatePoint((gaBerechnung.Teilung / 2) + gaBerechnung.Modul, (gaBerechnung.Fußkreisdurchmesser / 2));

            Line2D catL2D_1 = catFactory2D.CreateLine(0, (gaBerechnung.Fußkreisdurchmesser / 2), 0, (gaBerechnung.Fußkreisdurchmesser / 2) + gaBerechnung.Zahnhöhe);
            catL2D_1.StartPoint = catP2D_1;
            catL2D_1.EndPoint = catP2D_2;

            Line2D catL2D_2 = catFactory2D.CreateLine(0, (gaBerechnung.Fußkreisdurchmesser / 2) + gaBerechnung.Zahnhöhe, (gaBerechnung.Teilung / 2), (gaBerechnung.Fußkreisdurchmesser / 2) + gaBerechnung.Zahnhöhe);
            catL2D_2.StartPoint = catP2D_2;
            catL2D_2.EndPoint = catP2D_3;

            Line2D catL2D_3 = catFactory2D.CreateLine((gaBerechnung.Teilung / 2), (gaBerechnung.Fußkreisdurchmesser / 2) + gaBerechnung.Zahnhöhe, (gaBerechnung.Teilung / 2), (gaBerechnung.Fußkreisdurchmesser / 2));
            catL2D_3.StartPoint = catP2D_3;
            catL2D_3.EndPoint = catP2D_4;

            Circle2D catC2D_1 = catFactory2D.CreateCircle(0, 0, (gaBerechnung.Fußkreisdurchmesser / 2), 0, 0);
            catC2D_1.StartPoint = catP2D_5;
            catC2D_1.EndPoint = catP2D_4;





            //Kreismuster
            ShapeFactory SF = (ShapeFactory)HSPGE_CatiaPart.Part.ShapeFactory;
            HybridShapeFactory HSF = (HybridShapeFactory)HSPGE_CatiaPart.Part.HybridShapeFactory;
            Part myPart = HSPGE_CatiaPart.Part;


            //Referenzen und Skizze
            Factory2D Factory2D1 = HSPGE_catia_Profil.Factory2D;

            HybridShapePointCoord Ursprung = HSF.AddNewPointCoord(0, 0, 0);
            Reference RefUrsprung = myPart.CreateReferenceFromObject(Ursprung);
            HybridShapeDirection XDir = HSF.AddNewDirectionByCoord(1, 0, 0);
            Reference RefXDir = myPart.CreateReferenceFromObject(XDir);


            //Kreismuster mit daten füllen
            CircPattern Kreismuster = SF.AddNewSurfacicCircPattern(Factory2D1, 1, 2, 0, 0, 1, 1, RefUrsprung, RefXDir,
            false, 0, true, false);
            Kreismuster.CircularPatternParameters = CatCircularPatternParameters.catInstancesandAngularSpacing;
            AngularRepartition angularRepartition1 = Kreismuster.AngularRepartition;
            Angle angle1 = angularRepartition1.AngularSpacing;
            angle1.Value = Convert.ToDouble(360 / Convert.ToDouble(gaBerechnung.Zähnezahl));
            AngularRepartition angularRepartition2 = Kreismuster.AngularRepartition;
            IntParam intParam1 = angularRepartition2.InstancesCount;
            intParam1.Value = Convert.ToInt32(gaBerechnung.Zähnezahl) + 1;


            // Geschlossene kontur
            Reference Ref_Kreismuster = myPart.CreateReferenceFromObject(Kreismuster);
            HybridShapeAssemble Verbindung = HSF.AddNewJoin(Ref_Kreismuster, Ref_Kreismuster);
            Reference Ref_Verbindung = myPart.CreateReferenceFromObject(Verbindung);

            HSF.GSMVisibility(Ref_Verbindung, 0);

            myPart.Update();

            Bodies bodies = myPart.Bodies;
            Body myBody = bodies.Add();
            myBody.set_Name("Zahnrad");
            myBody.InsertHybridShape(Verbindung);

            myPart.Update();


            myPart.InWorkObject = myBody;
            Pad myPad = SF.AddNewPadFromRef(Ref_Verbindung, gaBerechnung.Breite);
            myPart.Update();



        }



    }
}
