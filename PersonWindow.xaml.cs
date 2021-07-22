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
    /// Interaction logic for PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        List<Person> personList;
        public PersonWindow()
        {
            InitializeComponent();
            personList = returnList.PersonList;
            var b = from ab in personList
                    select ab;
            foreach (var a in b)
            {
                listBox.Items.Add(a.Id + "         " + a.Name+"           "+a.Address+"             "+a.Email+"         " +
                    "            "+a.Age );

            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            personInsert pi = new personInsert();
            pi.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a record from the listbox", "Error",
                      MessageBoxButton.OK,
                      MessageBoxImage.None);
            }
            if (listBox.SelectedIndex > -1)
            {
                if (MessageBox.Show("Confirm Delete?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    string name = (listBox.SelectedItem.ToString());

                string[] result = name.Split(' ');
                int id1 = Int32.Parse(result[0]);
                var deleteOrderDetails = from details in personList
                                         where details.Id == id1
                                         select details;


                foreach (var a in deleteOrderDetails.ToList())
                {
                    personList.Remove(a);
                }

                this.Close();
                MessageBox.Show("The Record has been deleted", "Success",
                      MessageBoxButton.OK,
                      MessageBoxImage.Information);
            }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (listBox.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a record from the listbox", "Error",
                      MessageBoxButton.OK,
                      MessageBoxImage.None);
            }
            if (listBox.SelectedIndex > -1)
            {
                string id = (listBox.SelectedItem.ToString());

                string[] result = id.Split(' ');
                
                PersonUpdate pu = new PersonUpdate(Int32.Parse(result[0]));
                pu.Show();
                this.Close();
               
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
