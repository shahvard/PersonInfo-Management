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
    /// Interaction logic for PersonalityUpdate.xaml
    /// </summary>
    public partial class PersonalityUpdate : Window
    {

        int selectedValue;
        List<Personality> personalityList;

        public PersonalityUpdate(int id)
        {

            InitializeComponent();
            selectedValue = id;
            personalityList = returnList.PersonalityList;

            txtId.Content = selectedValue.ToString();
            var UpdateOrderDetails = from details in personalityList
                                     where details.Id == selectedValue
                                     select details;

            foreach (var a in UpdateOrderDetails.ToList())
            {
                txtId.Content = a.Id;
                txtPersonId.Text = a.PersonId.ToString();
                txtShoeSize.Text = a.ShoeSize.ToString();
                txtFM.Text = a.FavouriteMovie;
                txtFA.Text = a.FavouriteActor;

            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            int id1;

            int shoeSize;
            bool success1 = Int32.TryParse(txtPersonId.Text.ToString(), out id1);

            bool success = Int32.TryParse(txtShoeSize.Text, out shoeSize);
            if (success1 && success)//&& success1 && success2)
            {



                int id = Int32.Parse(txtId.Content.ToString());
                var UpdateOrderDetails = from details in personalityList
                                         where details.Id == id
                                         select details;
                foreach (var a in UpdateOrderDetails.ToList())
                {

                    if (MessageBox.Show("Confirm Update?", "Confirm Update", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        a.Id = Int32.Parse(txtId.Content.ToString());
                        a.PersonId = Int32.Parse(txtPersonId.Text);
                        a.ShoeSize = Int32.Parse(txtShoeSize.Text);
                        a.FavouriteMovie = txtFM.Text;
                        a.FavouriteActor = txtFA.Text;
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
                MessageBox.Show("The Person Id and shoe size should be Integer", "Error",
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
            PersonalityInsert ei = new PersonalityInsert();
            ei.Show();
            this.Close();

        }
        private void mnuUpdate_Click(object sender, RoutedEventArgs e)
        {
            PersonalityWindow ew = new PersonalityWindow();
            ew.Show();
            this.Close();
        }
        private void mnuDelete_Click(object sender, RoutedEventArgs e)
        {
            PersonalityWindow ew = new PersonalityWindow();
            ew.Show();
            this.Close();
        }
    }
}
