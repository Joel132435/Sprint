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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sprint1_GUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double m, z, d, h, hf, ha, p, df, c, db, deg, w;
            

            m = Convert.ToDouble(txtBox_Modul.Text);
            z = Convert.ToDouble(txtBox_Zähnezahl.Text);
            d = Convert.ToDouble(txtBox_Teilkreisdurchmesser.Text);
            c = Convert.ToDouble(txtBox_Kopfspiel.Text);
            w = Convert.ToDouble(txtBox_Eingriffswinkel.Text);

            if (c <= 0)
            {
                MessageBoxResult Kopfspiel;
                Kopfspiel = MessageBox.Show("Kopfspiel mit häufigen Wert rechnen?", "Kopfspiel",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );
                if (Kopfspiel == MessageBoxResult.Yes)
                {
                    c = m * Convert.ToDouble(0.167);
                }
                else
                {
                    
                }
                
            }
            
            //Zahnhöhe

            h = 2 * m + c;
            erg_Zahnhöhe.Content = h.ToString();

            

            //Zahnfußhöhe

            hf = m + c;

            erg_Zahnfußhöhe.Content = hf.ToString();
            

            //Zahnkopfhöhe
            

            ha = m;

            erg_Zahnkopfhöhe.Content = ha.ToString();

            //Teilung

            p = Math.PI * m;

            erg_Teilung.Content = p.ToString();



            //Fußkreisdurchmesser

            df = d - 2 * (m + c);

            erg_Fußkreisdurchmesser.Content = df.ToString();

            //Grundkreisdurchmesser

            deg = (w * (Math.PI)) / 180;

            db = m * z * (Math.Cos(deg));

            erg_Grundkreisdurchmesser.Content = db.ToString();
            


        }
    }
}
