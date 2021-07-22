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
    /// Interaction logic for SportsUpdate.xaml
    /// </summary>
    public partial class SportsUpdate : Window
    {
        List<SportsTeam> sportsList = new List<SportsTeam>();
        int selectedValue;

        public SportsUpdate(int selected)
        {
            InitializeComponent();
            sportsList = returnList.SportsList;
            selectedValue = selected;
            txtId.Content = selectedValue.ToString();
            var UpdateOrderDetails = from details in sportsList
                                     where details.Id == selectedValue
                                     select details;

            foreach (var a in UpdateOrderDetails.ToList())
            {
                txtId.Content = a.Id.ToString();
                txtPersonId.Text = a.PersonId.ToString();
                txtSportsTeam.Text = a.Sportsteam;
                txtCity.Text = a.City;

            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            int id1;


            bool success = Int32.TryParse(txtPersonId.Text, out id1);
            if (success)//&& success1 && success2)
            {



                int id = Int32.Parse(txtId.Content.ToString());
                var UpdateOrderDetails = from details in sportsList
                                         where details.Id == id
                                         select details;
                foreach (var a in UpdateOrderDetails.ToList())
                {

                    if (MessageBox.Show("Confirm Update?", "Confirm Update", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        a.Id = Int32.Parse(txtId.Content.ToString());
                        a.PersonId = Int32.Parse(txtPersonId.Text);
                        a.Sportsteam = txtSportsTeam.Text;
                        a.City = txtCity.Text;
                        MessageBox.Show("The Record has been updated", "Success",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        this.Close();
                        return;
                    }

                }

            }

            else
            {
                MessageBox.Show("The PersonId should be Integer", "Error",
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
