using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Shapes;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for TeamCreatorWindow.xaml
    /// </summary>
   partial class  TeamCreatorWindow : Window
   {
        

        public TeamCreatorWindow()
        {
            InitializeComponent();
        }
        class CreatedTeam : TeamCreatorWindow
        {
            
            public CreatedTeam(string TeamName, string KeyPlayer, string Knep)
            {

                TeamName = TeamNameTxtBox.Text;
                KeyPlayer = KeyPlayerTxtBox.Text;
                Knep = TeamKnep;
            }
           
        }
        public string TeamKnep;
        public string TeamName { get; set; }

        public string KeyPlayer { get; set; }

        public string Knep { get; set; }
        public void CancelTeamCreator_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void CreateTeambutton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = Application.Current.MainWindow as MainWindow;
            CreatedTeam TEAM = new CreatedTeam(TeamName, KeyPlayer, Knep);
         
           mw.AddTeams(TEAM);
            
        }
        public void BortaButton_Click(object sender, RoutedEventArgs e)
        {
            BortaButton.IsChecked = true;
            HemmaButton.IsChecked = false;
            HemmaButton.BorderBrush = Brushes.Gray;
            BortaButton.BorderBrush = Brushes.Green;
            TeamKnep = "BORTA";
        }
        public void HemmaButton_Click(object sender, RoutedEventArgs e)
        {
            HemmaButton.IsChecked = true;
            BortaButton.IsChecked = false;
            HemmaButton.BorderBrush = Brushes.Green;
            BortaButton.BorderBrush = Brushes.Gray;
            TeamKnep = "HEMMA";
        }
       
   }
}
