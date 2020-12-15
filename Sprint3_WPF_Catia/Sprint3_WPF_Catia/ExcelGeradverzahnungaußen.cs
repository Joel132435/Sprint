using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Sprint3_WPF_Catia
{
    class ExcelGeradverzahnungaußen
    {

        //Tooltipps erweitern
        Excel.Application excelApp = new Excel.Application();
        Excel._Worksheet mySheet;
        Excel.Range Xrange;
        Excel.Borders myBorders;




        //Methoden
        internal void ExcelEinstellungen()
        {
            excelApp.Visible = true;
            excelApp.DisplayAlerts = false;
            excelApp.Workbooks.Add();

            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;



            // Namen für die Ein- und Ausgabewerte
            mySheet.Cells[2, "a"] = "Datenblatt";

         

            mySheet.Cells[14, "A"] = "Stirnrad Geradverzahnung";
            mySheet.Cells[15, "A"] = "Modul : ";
            mySheet.Cells[16, "A"] = "Zähnezahl :";
            mySheet.Cells[17, "A"] = "Teilkreisdurchmesser :";
            mySheet.Cells[18, "A"] = "Breite :";
            mySheet.Cells[19, "A"] = "Eingriffswinkel :";
            mySheet.Cells[20, "A"] = "Kopfspiel :";  
            
            mySheet.Cells[26, "a"] = "Zahnhöhe :";
            mySheet.Cells[27, "a"] = "Zahnfußhöhe :";
            mySheet.Cells[28, "a"] = "Zahnkopfhöhe :";
            mySheet.Cells[29, "a"] = "Teilung :";
            mySheet.Cells[30, "a"] = "Fußkreisdurchmesser :";
            mySheet.Cells[31, "a"] = "Grundkreisdurchmesser :";
            mySheet.Cells[32, "a"] = "Kopfkreisdurchmesser :";
     


            mySheet.Cells[15, "b"] = "mm";
            mySheet.Cells[16, "b"] = "Anzahl";
            mySheet.Cells[17, "b"] = "mm";
            mySheet.Cells[18, "b"] = "mm";
            mySheet.Cells[19, "b"] = "Grad";
            mySheet.Cells[20, "b"] = "mm";

            mySheet.Cells[26, "b"] = "mm";
            mySheet.Cells[27, "b"] = "mm";
            mySheet.Cells[28, "b"] = "mm";
            mySheet.Cells[29, "b"] = "mm";
            mySheet.Cells[30, "b"] = "mm";
            mySheet.Cells[31, "b"] = "mm";
            mySheet.Cells[32, "b"] = "mm";
         

           
           

            //Eingaben Zentrieren
            mySheet.Range["A5", "A11"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            mySheet.Range["A15", "A20"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            mySheet.Range["A26", "A32"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            mySheet.Range["b15", "b21"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            mySheet.Range["b26", "b32"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            mySheet.Range["c15", "c20"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            mySheet.Range["c26", "c32"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            //EInstellungen der Schriftgröße
            mySheet.Range["A5", "A11"].Font.Size = 9;

            mySheet.Range["A15", "A21"].Font.Size = 11;
            mySheet.Range["b15", "b21"].Font.Size = 11;
            mySheet.Range["c15", "c21"].Font.Size = 11;

            mySheet.Range["A26", "A32"].Font.Size = 11;
            mySheet.Range["b26", "b32"].Font.Size = 11;
            mySheet.Range["c26", "c32"].Font.Size = 11;


            //Schriftzug fettwerden lassen
            mySheet.Range["A2"].Font.Bold = true;
            mySheet.Range["A14"].Font.Bold = true;

            //Schriftgröße anpassen
            mySheet.Range["A2"].Font.Size = 24;
            mySheet.Range["A14"].Font.Size = 16;
           


            //Zellen zusammenfassen
            mySheet.Range["a2:D2"].Merge();
            mySheet.Range["a14:c14"].Merge();
            ;


            //zellen Zentrieren
            mySheet.Range["A2", "D2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            mySheet.Range["A14", "c14"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            
            

            //Unterstrich "Produktdatenblatt"
            mySheet.Range["a2:D2"].Font.Underline = XlUnderlineStyle.xlUnderlineStyleSingle;


            //Zellen rahmen eingabeparameter
            Xrange = mySheet.get_Range("A15:c20");
            myBorders = Xrange.Borders;
            myBorders.Weight = XlBorderWeight.xlThick;
            myBorders.Weight = 2d;

            // Zellen rahmen ergebnisse
            Xrange = mySheet.get_Range("A26:c32");
            myBorders = Xrange.Borders;
            myBorders.Weight = XlBorderWeight.xlThick;
            myBorders.Weight = 2d;

            //zellen rahmen preis
            Xrange = mySheet.get_Range("A32:c32");
            myBorders = Xrange.Borders;
            myBorders.Weight = XlBorderWeight.xlThick;
            myBorders.Weight = 2d;
             


            //autofit
            mySheet.Range["A1", "c32"].EntireColumn.AutoFit();


            //Kommazahlen
            //Hinzufügen




        }

        internal void Geradverzahnungaußen(GeradverzahnungaußenBerechnung GeaZahn)
        {
            //übertragung in excel der ein und ausgabeparameter
            //Material hinzufügen

            mySheet.Cells[15, "c"] = GeaZahn.Modul;
            mySheet.Cells[16, "c"] = GeaZahn.Zähnezahl;
            mySheet.Cells[17, "c"] = GeaZahn.Teilkreisdurchmesser;
            mySheet.Cells[18, "c"] = GeaZahn.Breite;
            mySheet.Cells[19, "c"] = GeaZahn.Eingriffswinkel;
            mySheet.Cells[20, "c"] = GeaZahn.Kopfspiel;
            
            mySheet.Cells[26, "c"] = GeaZahn.Zahnhöhe;
            mySheet.Cells[27, "c"] = GeaZahn.Zahnfußhöhe;
            mySheet.Cells[28, "c"] = GeaZahn.Zahnkopfhöhe;
            mySheet.Cells[29, "c"] = GeaZahn.Teilung;
            mySheet.Cells[30, "c"] = GeaZahn.Fußkreisdurchmesser;
            mySheet.Cells[31, "c"] = GeaZahn.Grundkreisdurchmesser;
            mySheet.Cells[32, "c"] = GeaZahn.Kopfkreisdurchmesser;
            









        }
    }
}
