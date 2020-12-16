using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Sprint3_WPF_Catia
{
    class ExcelSchrägverzahnung
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



            mySheet.Cells[4, "A"] = "Stirnrad Schrägverzahnung";
            mySheet.Cells[5, "A"] = "Modul : ";
            mySheet.Cells[6, "A"] = "Zähnezahl :";
            mySheet.Cells[7, "A"] = "Teilkreisdurchmesser :";
            mySheet.Cells[8, "A"] = "Breite :";
            mySheet.Cells[9, "A"] = "Eingriffswinkel :";
            mySheet.Cells[10, "A"] = "Schrägungswinkel :";
            mySheet.Cells[11, "A"] = "Kopfspiel :";

            mySheet.Cells[13, "a"] = "Zahnhöhe :";
            mySheet.Cells[14, "a"] = "Zahnfußhöhe :";
            mySheet.Cells[15, "a"] = "Zahnkopfhöhe :";
            mySheet.Cells[16, "a"] = "Teilung :";
            mySheet.Cells[17, "a"] = "Fußkreisdurchmesser :";
            mySheet.Cells[18, "a"] = "Grundkreisdurchmesser :";
            mySheet.Cells[19, "a"] = "Kopfkreisdurchmesser :";



            mySheet.Cells[5, "b"] = "mm";
            mySheet.Cells[6, "b"] = "Anzahl";
            mySheet.Cells[7, "b"] = "mm";
            mySheet.Cells[8, "b"] = "mm";
            mySheet.Cells[9, "b"] = "Grad";
            mySheet.Cells[10, "b"] = "Grad";
            mySheet.Cells[11, "b"] = "mm";

            mySheet.Cells[13, "b"] = "mm";
            mySheet.Cells[14, "b"] = "mm";
            mySheet.Cells[15, "b"] = "mm";
            mySheet.Cells[16, "b"] = "mm";
            mySheet.Cells[17, "b"] = "mm";
            mySheet.Cells[18, "b"] = "mm";
            mySheet.Cells[19, "b"] = "mm";





            //Eingaben Zentrieren

            mySheet.Range["A5", "A11"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            mySheet.Range["A13", "A19"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            mySheet.Range["b5", "b11"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            mySheet.Range["b13", "b19"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            mySheet.Range["c5", "c11"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            mySheet.Range["c13", "c19"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            //Einstellungen der Schriftgröße

            mySheet.Range["A5", "A11"].Font.Size = 11;
            mySheet.Range["b5", "b11"].Font.Size = 11;
            mySheet.Range["c5", "c11"].Font.Size = 11;

            mySheet.Range["A13", "A19"].Font.Size = 11;
            mySheet.Range["b13", "b19"].Font.Size = 11;
            mySheet.Range["c13", "c19"].Font.Size = 11;


            //Schriftzug fettwerden lassen

            mySheet.Range["A2"].Font.Bold = true;
            mySheet.Range["A4"].Font.Bold = true;

            //Schriftgröße anpassen

            mySheet.Range["A2"].Font.Size = 24;
            mySheet.Range["A4"].Font.Size = 16;



            //Zellen zusammenfassen

            mySheet.Range["a2:D2"].Merge();
            mySheet.Range["a4:c3"].Merge();


            //zellen Zentrieren

            mySheet.Range["A2", "D2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            mySheet.Range["A4", "c4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;



            //Unterstrich "Produktdatenblatt"

            mySheet.Range["a2:D2"].Font.Underline = XlUnderlineStyle.xlUnderlineStyleSingle;


            //Zellen rahmen eingabeparameter

            Xrange = mySheet.get_Range("A5:c11");
            myBorders = Xrange.Borders;
            myBorders.Weight = XlBorderWeight.xlThick;
            myBorders.Weight = 2d;

            // Zellen rahmen ergebnisse

            Xrange = mySheet.get_Range("A13:c19");
            myBorders = Xrange.Borders;
            myBorders.Weight = XlBorderWeight.xlThick;
            myBorders.Weight = 2d;

            //autofit

            mySheet.Range["A1", "c19"].EntireColumn.AutoFit();

        }

        internal void Schrägverzahnung(SchrägverzahnungBerechnung SZahn)
        {
            //übertragung in excel der ein und ausgabeparameter
            //Material hinzufügen

            mySheet.Cells[5, "c"] = SZahn.Modul;
            mySheet.Cells[6, "c"] = SZahn.Zähnezahl;
            mySheet.Cells[7, "c"] = SZahn.Teilkreisdurchmesser;
            mySheet.Cells[8, "c"] = SZahn.Breite;
            mySheet.Cells[9, "c"] = SZahn.Eingriffswinkel;
            mySheet.Cells[10, "c"] = SZahn.Schrägungswinkel;
            mySheet.Cells[11, "c"] = SZahn.Kopfspiel;

            mySheet.Cells[13, "c"] = SZahn.Zahnhöhe;
            mySheet.Cells[14, "c"] = SZahn.Zahnfußhöhe;
            mySheet.Cells[15, "c"] = SZahn.Zahnkopfhöhe;
            mySheet.Cells[16, "c"] = SZahn.Teilung;
            mySheet.Cells[17, "c"] = SZahn.Fußkreisdurchmesser;
            mySheet.Cells[18, "c"] = SZahn.Grundkreisdurchmesser;
            mySheet.Cells[19, "c"] = SZahn.Kopfkreisdurchmesser;







        }
    }


}

