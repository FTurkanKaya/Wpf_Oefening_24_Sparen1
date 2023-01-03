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

namespace Wpf_Oefening_24_Sparen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int weekGeld;
        double verhoging;
        int gewenstBedrag;
        double totaalSpaar;
        int week;
        int weekSpaar;
        double weekVerhoging;
        private StringBuilder sb;
        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            weekGeld = Convert.ToInt32(TxtWeekGeld.Text);
            verhoging = Convert.ToDouble(TxtVerhoging.Text);
            gewenstBedrag = Convert.ToInt32(TxtSpaar.Text);
            sb = new StringBuilder();

            week = 0;
            do
            {
                week++;
                weekSpaar = weekGeld * week;
                weekVerhoging = verhoging * week;
                totaalSpaar = weekSpaar + weekVerhoging;

            }while(totaalSpaar <= gewenstBedrag);

            sb.AppendLine($"Spaarbedrag na {week} weken: € {weekSpaar}\n\n" +
                $"Extra weekgeld op dat moment : € {weekVerhoging}\n\n" +
                $"Totaal spaargeld: € {totaalSpaar}.");

            TxtResult.Text = sb.ToString();





        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtResult.Text = "";
            TxtVerhoging.Text = "";
            TxtSpaar.Text = "";
            TxtWeekGeld.Text = "";
            TxtWeekGeld.Focus();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
            

        }
    }
}
