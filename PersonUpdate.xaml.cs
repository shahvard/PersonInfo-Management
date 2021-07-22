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
    /// Interaction logic for PersonUpdate.xaml
    /// </summary>
    public partial class PersonUpdate : Window
    {
        int selectedValue;
        List<Person> personList;
        public PersonUpdate(int selected)
        {
            InitializeComponent();
            personList = returnList.PersonList;
            selectedValue = selected;
            txtName.Text = selectedValue.ToString();
            var UpdateOrderDetails = from details in personList
                                     where details.Id == selectedValue
                                     select details;

            foreach (var a in UpdateOrderDetails.ToList())
            {
                txtId.Content = a.Id.ToString();
                    txtName.Text =a.Name;
                    txtAddress.Text = a.Address;
                    txtAge.Text = a.Age.ToString();
                    txtBirthday.Text = a.Birthday;
                    txtemail.Text = a.Email;
                }
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int age;


            bool success = Int32.TryParse(txtAge.Text, out age);
            if (success)//&& success1 && success2)
            {
                int id = Int32.Parse(txtId.Content.ToString());

                var UpdateOrderDetails = from details in personList
                                         where details.Id == id
                                         select details;

                foreach (var a in UpdateOrderDetails.ToList())
                {
                    a.Id = Int32.Parse(txtId.Content.ToString());
                    a.Name = txtName.Text;
                    a.Address = txtAddress.Text;
                    a.Email = txtemail.Text;
                    a.Age = Int32.Parse(txtAge.Text);
                    a.Birthday = txtBirthday.Text;
                    this.Close();
                    MessageBox.Show("The Record has been updated", "Success",
                             MessageBoxButton.OK,
                             MessageBoxImage.Information);
                }


            }
            else
            {
                MessageBox.Show("The Age should be Integer", "Error",
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
