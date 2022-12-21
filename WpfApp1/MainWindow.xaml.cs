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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;

namespace WpfApp1
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

           
        }
      

        public void AddTeam_Click(object sender, RoutedEventArgs e)
        {
          
            TeamCreatorWindow TeamCreatorPopup = new TeamCreatorWindow();
            TeamCreatorPopup.Show();

        }
        public void AddTeams(TeamCreatorWindow TEAM)
        {
            AddTeamBox.Items.Add(TEAM);
        }

    }
}
