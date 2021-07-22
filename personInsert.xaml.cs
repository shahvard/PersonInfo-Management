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
    /// Interaction logic for personInsert.xaml
    /// </summary>
    public partial class personInsert : Window
    {
        List<Person> personList;

        public personInsert()
        {
            InitializeComponent();
            personList = returnList.PersonList;
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int id;
            int age;
            
            bool success2 = Int32.TryParse(txtId.Text, out id);
            bool success = Int32.TryParse(txtAge.Text, out age);
            if (success2 && success)//&& success1 && success2)
            {
                Person p = new Person(Int32.Parse(txtId.Text.ToString()), txtName.Text, txtAddress.Text, txtemail.Text, Int32.Parse(txtAge.Text), txtBirthday.Text);
                personList.Add(p);
                this.Close();
                MessageBox.Show("The record has been inserted", "Information",
          MessageBoxButton.OK,
          MessageBoxImage.None);
                return;
            }
            else
            {
                MessageBox.Show("The Id and Age should be Integer", "Error",
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
            personInsert ei = new personInsert();
            ei.Show();
            this.Close();
        }
        private void mnuUpdate_Click(object sender, RoutedEventArgs e)
        {
            PersonWindow ew = new PersonWindow();
            ew.Show();
            this.Close();
        }
        private void mnuDelete_Click(object sender, RoutedEventArgs e)
        {
            PersonWindow ew = new PersonWindow();
            ew.Show();
            this.Close();
        }
    }
}
