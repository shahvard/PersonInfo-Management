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

namespace Midterm
{
    /// <summary>
    /// Interaction logic for sportsInsert.xaml
    /// </summary>
    public partial class sportsInsert : Window
    {

        List<SportsTeam> sportsList;

        public sportsInsert()
        {
            InitializeComponent();
            sportsList = returnList.SportsList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



            int id;
            int id1;

            bool success2 = Int32.TryParse(txtId.Text, out id);
            bool success = Int32.TryParse(txtPersonId.Text, out id1);
            if (success2 && success)//&& success1 && success2)
            {

                SportsTeam st = new SportsTeam(Int32.Parse(txtId.Text.ToString()), Int32.Parse(txtPersonId.Text), txtSportsTeam.Text, txtCity.Text);
                sportsList.Add(st);
                this.Close();
                MessageBox.Show("The record has been inserted", "Information",
 MessageBoxButton.OK,
 MessageBoxImage.None);
                return;

            }


            else
            {
                MessageBox.Show("The Id and Person Id should be Integer", "Error",
                          MessageBoxButton.OK,
                          MessageBoxImage.None);
                return;
            }

        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Confirm Quit", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
        private void mnuInsert_Click(object sender, RoutedEventArgs e)
        {
            sportsInsert ei = new sportsInsert();
            ei.Show();
            this.Close();
        }
        private void mnuUpdate_Click(object sender, RoutedEventArgs e)
        {
            SportsWindow ew = new SportsWindow();
            ew.Show();
            this.Close();
        }
        private void mnuDelete_Click(object sender, RoutedEventArgs e)
        {
            SportsWindow ew = new SportsWindow();
            ew.Show();
            this.Close();
        }
    }
}
