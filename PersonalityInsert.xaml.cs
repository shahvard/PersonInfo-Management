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
    /// Interaction logic for PersonalityInsert.xaml
    /// </summary>
    public partial class PersonalityInsert : Window
    {

        List<Personality> personalityList;

        public PersonalityInsert()
        {
            InitializeComponent();
            personalityList = returnList.PersonalityList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            int id1;
            int id;
            int shoeSize;
            bool success1 = Int32.TryParse(txtPersonId.Text.ToString(), out id1);
            bool success2 = Int32.TryParse(txtId.Text, out id);
            bool success = Int32.TryParse(txtShoeSize.Text, out shoeSize);
            if (success1 && success2 && success)//&& success1 && success2)
            {



                Personality p = new Personality(id, id1, shoeSize, txtFM.Text, txtFA.Text);
                personalityList.Add(p);
                this.Close();

                MessageBox.Show("The record has been inserted", "Information",
                                     MessageBoxButton.OK,
                                      MessageBoxImage.None);
                return;
            }


            else
            {
                MessageBox.Show("The Person Id,Id and shoe size should be Integer", "Error",
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
