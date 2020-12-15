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
using System.Windows;

namespace Sprint3_WPF_Catia
{
    class CatiaPfeilverzahnung
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

            // Geometrisches Set auswählen und umbenennen
            HybridBodies catHybridBodies1 = HSPGE_CatiaPart.Part.HybridBodies;
            HybridBody catHybridBody1;

            try
            {
                catHybridBody1 = catHybridBodies1.Item("Geometrisches Set.1");
            }
            catch (Exception)
            {
                MessageBox.Show("Kein geometrisches Set gefunden! " + Environment.NewLine + "Ein PART manuell erzeugen und darauf achten, dass 'Geometisches Set' aktiviert ist.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Information);

                return;
            }

            catHybridBody1.set_Name("Profil");
            // Neue Skizze im ausgewählten geometrischen Set anlegen
            Sketches catSketch = catHybridBody1.HybridSketches;
            OriginElements catOriginElements = HSPGE_CatiaPart.Part.OriginElements;
            Reference catReferenz = (Reference)catOriginElements.PlaneYZ;

            HSPGE_catia_Profil = catSketch.Add(catReferenz);
            // Achsensystem in Skizze erstellen 
            ErzeugeAchsensystem();
            // Part aktualisieren
            HSPGE_CatiaPart.Part.Update();

        }
        //Erzeugung eines Achsensystems
        private void ErzeugeAchsensystem()
        {
            object[] arr = new object[] {0.0, 0.0, 0.0,
                                         0.0, 1.0, 0.0,
                                         0.0, 0.0, 1.0 };
            HSPGE_catia_Profil.SetAbsoluteAxisData(arr);
        }



        internal void StirnradGeradverzahnung(PfeilverzahnungBerechnung pfBerechnung)
        {
            //HilfsRadien
            double TeilkreisRadius = (pfBerechnung.Modul * pfBerechnung.Zähnezahl) / 2;
            double HilfskreisRadius = TeilkreisRadius * 0.94;
            double FußkreisRadius = TeilkreisRadius - (1.25 * pfBerechnung.Modul);
            double Kopfkreisradius = TeilkreisRadius + pfBerechnung.Modul;
            double Verrundungsradius = 0.35 * pfBerechnung.Modul;

            //HilfsWinkel
            double alpha = 20;
            double beta = 90 / pfBerechnung.Zähnezahl;
            double beta_radius = Math.PI * beta / 180;
            double gamma = 90 - (alpha - beta);
            double gamma_radius = Math.PI * gamma / 180;
            double TotalAngle = 360.0 / pfBerechnung.Zähnezahl;
            double TotalAngleRadius = Math.PI * TotalAngle / 180;

            //Nullpunkte
            double x0 = 0;
            double y0 = 0;

            //MittelPunkt EvolventenKreis
            double MP_EvolventenKreis_x = HilfskreisRadius * Math.Cos(gamma_radius);
            double MP_EvolventenKreis_y = HilfskreisRadius * Math.Sin(gamma_radius);

            // SchnittPunkt Evolventenkreis & Teilkreisradius
            double SP_EvolventenTeilKreis_x = -TeilkreisRadius * Math.Sin(beta_radius);
            double SP_EvolventenTeilKreis_y = TeilkreisRadius * Math.Cos(beta_radius);

            //Evolventenkreis Radius
            double Evolventenkreis_r = Math.Sqrt(Math.Pow((MP_EvolventenKreis_x - SP_EvolventenTeilKreis_x), 2) + Math.Pow((MP_EvolventenKreis_y - SP_EvolventenTeilKreis_y), 2));

            //SchnittPunkt Evolventenkreis & Kopfkreisradius
            double SP_EvolventenKopfKreis_x = Schnittpunkt_x(x0, y0, Kopfkreisradius, MP_EvolventenKreis_x, MP_EvolventenKreis_y, Evolventenkreis_r);
            double SP_EvolventenKopfKreis_y = Schnittpunkt_y(x0, y0, Kopfkreisradius, MP_EvolventenKreis_x, MP_EvolventenKreis_y, Evolventenkreis_r);

            //MittelPunkt VerrundungsRadius
            double MP_Verrundung_x = Schnittpunkt_x(x0, y0, FußkreisRadius + Verrundungsradius, MP_EvolventenKreis_x, MP_EvolventenKreis_y, Evolventenkreis_r + Verrundungsradius);
            double MP_Verrundung_y = Schnittpunkt_y(x0, y0, FußkreisRadius + Verrundungsradius, MP_EvolventenKreis_x, MP_EvolventenKreis_y, Evolventenkreis_r + Verrundungsradius);

            //SchnittPunkt Evolventenkreis & Verrundungsradius
            double SP_EvolventeVerrundung_x = Schnittpunkt_x(MP_EvolventenKreis_x, MP_EvolventenKreis_y, Evolventenkreis_r, MP_Verrundung_x, MP_Verrundung_y, Verrundungsradius);
            double SP_EvolventeVerrundung_y = Schnittpunkt_y(MP_EvolventenKreis_x, MP_EvolventenKreis_y, Evolventenkreis_r, MP_Verrundung_x, MP_Verrundung_y, Verrundungsradius);

            //SchnittPunkt Fußkreis & Verrundungs Radius
            double SP_FußkreisVerrundungsRadius_x = Schnittpunkt_x(x0, y0, FußkreisRadius, MP_Verrundung_x, MP_Verrundung_y, Verrundungsradius);
            double SP_FußkreisVerrundungsRadius_y = Schnittpunkt_y(x0, y0, FußkreisRadius, MP_Verrundung_x, MP_Verrundung_y, Verrundungsradius);

            //StartPunkt Fußkreis Radius
            double phi = TotalAngleRadius - Math.Atan(Math.Abs(SP_FußkreisVerrundungsRadius_x) / Math.Abs(SP_FußkreisVerrundungsRadius_y));
            double StartPkt_Fußkreis_x = -FußkreisRadius * Math.Sin(phi);
            double StartPkt_Fußkreis_y = FußkreisRadius * Math.Cos(phi);

            //Skizze umbenennen und öffnen
            HSPGE_catia_Profil.set_Name("Pfeilverzahnung");
            Factory2D catFactory2D1 = HSPGE_catia_Profil.OpenEdition();

            //Punkte 
            Point2D catP2D_Ursprung = catFactory2D1.CreatePoint(x0, y0);

            Point2D catP2D_StartPkt_Fußkreis = catFactory2D1.CreatePoint(StartPkt_Fußkreis_x, StartPkt_Fußkreis_y);
            Point2D catP2D_SP_FußkreisVerrundungsRadius1 = catFactory2D1.CreatePoint(SP_FußkreisVerrundungsRadius_x, SP_FußkreisVerrundungsRadius_y);
            Point2D catP2D_SP_FußkreisVerrundungsRadius2 = catFactory2D1.CreatePoint(-SP_FußkreisVerrundungsRadius_x, SP_FußkreisVerrundungsRadius_y);

            Point2D catP2D_MP_EvolventenKreis1 = catFactory2D1.CreatePoint(MP_EvolventenKreis_x, MP_EvolventenKreis_y);
            Point2D catP2D_MP_EvolventenKreis2 = catFactory2D1.CreatePoint(-MP_EvolventenKreis_x, MP_EvolventenKreis_y);

            Point2D catP2D_SP_EvolventenKopfKreis1 = catFactory2D1.CreatePoint(SP_EvolventenKopfKreis_x, SP_EvolventenKopfKreis_y);
            Point2D catP2D_SP_EvolventenKopfKreis2 = catFactory2D1.CreatePoint(-SP_EvolventenKopfKreis_x, SP_EvolventenKopfKreis_y);

            Point2D catP2D_MP_Verrundung1 = catFactory2D1.CreatePoint(MP_Verrundung_x, MP_Verrundung_y);
            Point2D catP2D_MP_Verrundung2 = catFactory2D1.CreatePoint(-MP_Verrundung_x, MP_Verrundung_y);

            Point2D catP2D_SP_EvolventeVerrundung1 = catFactory2D1.CreatePoint(SP_EvolventeVerrundung_x, SP_EvolventeVerrundung_y);
            Point2D catP2D_SP_EvolventeVerrundung2 = catFactory2D1.CreatePoint(-SP_EvolventeVerrundung_x, SP_EvolventeVerrundung_y);


            //Kreise
            Circle2D catC2D_Frußkreis = catFactory2D1.CreateCircle(x0, y0, FußkreisRadius, 0, 0);
            catC2D_Frußkreis.CenterPoint = catP2D_Ursprung;
            catC2D_Frußkreis.StartPoint = catP2D_SP_FußkreisVerrundungsRadius1;
            catC2D_Frußkreis.EndPoint = catP2D_StartPkt_Fußkreis;

            Circle2D catC2D_Kopfkreis = catFactory2D1.CreateCircle(x0, y0, Kopfkreisradius, 0, 0);
            catC2D_Kopfkreis.CenterPoint = catP2D_Ursprung;
            catC2D_Kopfkreis.StartPoint = catP2D_SP_EvolventenKopfKreis2;
            catC2D_Kopfkreis.EndPoint = catP2D_SP_EvolventenKopfKreis1;

            Circle2D catC2D_EvolventenKreis1 = catFactory2D1.CreateCircle(MP_EvolventenKreis_x, MP_EvolventenKreis_y, Evolventenkreis_r, 0, 0);
            catC2D_EvolventenKreis1.CenterPoint = catP2D_MP_EvolventenKreis1;
            catC2D_EvolventenKreis1.StartPoint = catP2D_SP_EvolventenKopfKreis1;
            catC2D_EvolventenKreis1.EndPoint = catP2D_SP_EvolventeVerrundung1;

            Circle2D catC2D_Evolventenkreis2 = catFactory2D1.CreateCircle(-MP_EvolventenKreis_x, MP_EvolventenKreis_y, Evolventenkreis_r, 0, 0);
            catC2D_Evolventenkreis2.CenterPoint = catP2D_MP_EvolventenKreis2;
            catC2D_Evolventenkreis2.StartPoint = catP2D_SP_EvolventeVerrundung2;
            catC2D_Evolventenkreis2.EndPoint = catP2D_SP_EvolventenKopfKreis2;

            Circle2D catC2D_VerrundungsKreis1 = catFactory2D1.CreateCircle(MP_Verrundung_x, MP_Verrundung_y, Verrundungsradius, 0, 0);
            catC2D_VerrundungsKreis1.CenterPoint = catP2D_MP_Verrundung1;
            catC2D_VerrundungsKreis1.StartPoint = catP2D_SP_FußkreisVerrundungsRadius1;
            catC2D_VerrundungsKreis1.EndPoint = catP2D_SP_EvolventeVerrundung1;

            Circle2D catC2D_VerrundungsKreis2 = catFactory2D1.CreateCircle(-MP_Verrundung_x, MP_Verrundung_y, Verrundungsradius, 0, 0);
            catC2D_VerrundungsKreis2.CenterPoint = catP2D_MP_Verrundung2;
            catC2D_VerrundungsKreis2.StartPoint = catP2D_SP_EvolventeVerrundung2;
            catC2D_VerrundungsKreis2.EndPoint = catP2D_SP_FußkreisVerrundungsRadius2;



            HSPGE_catia_Profil.CloseEdition();

            HSPGE_CatiaPart.Part.Update();
        }



        public void ErzeugeKreismuster(PfeilverzahnungBerechnung pfBerechnung)
        {


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


            //Kreismuster mit Daten füllen
            CircPattern Kreismuster = SF.AddNewSurfacicCircPattern(Factory2D1, 1, 2, 0, 0, 1, 1, RefUrsprung, RefXDir, false, 0, true, false);
            Kreismuster.CircularPatternParameters = CatCircularPatternParameters.catInstancesandAngularSpacing;
            AngularRepartition angularRepartition1 = Kreismuster.AngularRepartition;
            Angle angle1 = angularRepartition1.AngularSpacing;
            angle1.Value = Convert.ToDouble(360 / pfBerechnung.Zähnezahl);
            AngularRepartition angularRepartition2 = Kreismuster.AngularRepartition;
            IntParam intParam1 = angularRepartition2.InstancesCount;
            intParam1.Value = Convert.ToInt32(pfBerechnung.Zähnezahl) + 1;


            // Geschlossene Kontur
            Reference Ref_Kreismuster = myPart.CreateReferenceFromObject(Kreismuster);
            HybridShapeAssemble Verbindung = HSF.AddNewJoin(Ref_Kreismuster, Ref_Kreismuster);
            Reference Ref_Verbindung = myPart.CreateReferenceFromObject(Verbindung);

            HSF.GSMVisibility(Ref_Verbindung, 0);

            myPart.Update();

            //hspge_catiaPart.Part.Update();

            Bodies bodies = myPart.Bodies;
            Body myBody = bodies.Add();
            myBody.set_Name("Zahnrad");
            myBody.InsertHybridShape(Verbindung);

            myPart.Update();


            //Schrägung 1 erstellen

            //Verschieben

            myPart.InWorkObject = myBody;
            HybridShapeTranslate Verschieben = HSF.AddNewEmptyTranslate();
            Verschieben.ElemToTranslate = Ref_Kreismuster;
            Verschieben.VectorType = 0;
            Verschieben.Direction = XDir;
            Verschieben.DistanceValue = (pfBerechnung.Breite/2);
            Verschieben.VolumeResult = false;
            myBody.InsertHybridShape(Verschieben);
            myPart.InWorkObject = Verschieben;
            Reference Ref_Verschieben = myPart.CreateReferenceFromObject(Verschieben);
            myPart.Update();

            //Drehen
            HybridShapeRotate Drehen = HSF.AddNewEmptyRotate();
            Drehen.ElemToRotate = Ref_Verschieben;
            Drehen.VolumeResult = false;
            Drehen.RotationType = 0;
            Drehen.Axis = RefXDir;
            Drehen.AngleValue = pfBerechnung.Schrägungswinkel;
            myBody.InsertHybridShape(Drehen);
            myPart.InWorkObject = Drehen;
            HSF.GSMVisibility(Ref_Verschieben, 0);
            Reference Ref_Drehen = myPart.CreateReferenceFromObject(Drehen);
            myPart.Update();


            //Verbindung
            HybridShapeAssemble Verbindung_2 = HSF.AddNewJoin(Ref_Drehen, Ref_Drehen);
            myBody.InsertHybridShape(Verbindung_2);
            Reference Ref_Verbindung_2 = myPart.CreateReferenceFromObject(Verbindung_2);
            myPart.Update();


            //Loft mit Helix Führung
            Loft myLoft = (Loft)SF.AddNewLoft();
            HybridShapeLoft LoftH = (HybridShapeLoft)myLoft.HybridShape;
            LoftH.AddSectionToLoft(Ref_Verbindung, 1, (Reference)default(Type));
            LoftH.AddSectionToLoft(Ref_Verbindung_2, 1, (Reference)default(Type));
            myPart.Update();


            //Schrägung 2 erstellen

            //Verschieben

            myPart.InWorkObject = myBody;
            HybridShapeTranslate Verschieben_2 = HSF.AddNewEmptyTranslate();
            Verschieben_2.ElemToTranslate = Ref_Kreismuster;
            Verschieben_2.VectorType = 0;
            Verschieben_2.Direction = XDir;
            Verschieben_2.DistanceValue = -(pfBerechnung.Breite/2);
            Verschieben_2.VolumeResult = false;
            myBody.InsertHybridShape(Verschieben_2);
            myPart.InWorkObject = Verschieben_2;
            Reference Ref_Verschieben_2 = myPart.CreateReferenceFromObject(Verschieben_2);
            myPart.Update();

            //Drehen
            HybridShapeRotate Drehen_2 = HSF.AddNewEmptyRotate();
            Drehen_2.ElemToRotate = Ref_Verschieben_2;
            Drehen_2.VolumeResult = false;
            Drehen_2.RotationType = 0;
            Drehen_2.Axis = RefXDir;
            Drehen_2.AngleValue = pfBerechnung.Schrägungswinkel;
            myBody.InsertHybridShape(Drehen_2);
            myPart.InWorkObject = Drehen_2;
            HSF.GSMVisibility(Ref_Verschieben_2, 0);
            Reference Ref_Drehen_2 = myPart.CreateReferenceFromObject(Drehen_2);
            myPart.Update();


            //Verbindung
            HybridShapeAssemble Verbindung_3 = HSF.AddNewJoin(Ref_Drehen_2, Ref_Drehen_2);
            myBody.InsertHybridShape(Verbindung_3);
            Reference Ref_Verbindung_3 = myPart.CreateReferenceFromObject(Verbindung_3);
            myPart.Update();


            //Loft mit Helix Führung
            Loft myLoft_2 = (Loft)SF.AddNewLoft();
            HybridShapeLoft LoftH_2 = (HybridShapeLoft)myLoft_2.HybridShape;
            LoftH_2.AddSectionToLoft(Ref_Verbindung, 1, (Reference)default(Type));
            LoftH_2.AddSectionToLoft(Ref_Verbindung_3, 1, (Reference)default(Type));
            
            myPart.Update();

        }
        //Berechnungen der SchnittPunkte
        private double Schnittpunkt_x(double MP1_x, double MP1_y, double r1, double MP2_x, double MP2_y, double r2)
        {
            double d = Math.Sqrt(Math.Pow((MP1_x - MP2_x), 2) + Math.Pow((MP1_y - MP2_y), 2));
            double l = (Math.Pow(r1, 2) - Math.Pow(r2, 2) + Math.Pow(d, 2)) / (d * 2);
            double h;
            double ii = 0.00001;

            if (r1 - l < -ii)
            {
                MessageBox.Show("Fehler!\nBitte überprüfen Sie die Eingangsparameter.");
            }
            if (Math.Abs(r1 - l) < ii)
            {
                h = 0;
            }
            else
            {
                h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(l, 2));
            }

            return l * (MP2_x - MP1_x) / d - h * (MP2_y - MP1_y) / d + MP1_x;
        }
        private double Schnittpunkt_y(double MP1_x, double MP1_y, double r1, double MP2_x, double MP2_y, double r2)
        {
            double d = Math.Sqrt(Math.Pow((MP1_x - MP2_x), 2) + Math.Pow((MP1_y - MP2_y), 2));
            double l = (Math.Pow(r1, 2) - Math.Pow(r2, 2) + Math.Pow(d, 2)) / (d * 2);
            double h;
            double ii = 0.00001;

            if (r1 - l < -ii)
            {
                MessageBox.Show("Fehler!\nBitte überprüfen Sie die Eingangsparameter.");
            }
            if (Math.Abs(r1 - l) < ii)
            {
                h = 0;
            }
            else
            {
                h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(l, 2));
            }

            return l * (MP2_y - MP1_y) / d + h * (MP2_x - MP1_x) / d + MP1_y;
        }


    }
}
