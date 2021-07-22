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
    /// Interaction logic for EducationWindow.xaml
    /// </summary>
    public partial class EducationWindow : Window
    {
        List<Education> educationList = new List<Education>();
        public EducationWindow()
        {
            InitializeComponent();
            educationList = returnList.EducationList;
            var b = from ab in educationList
                    select ab;
            foreach (var a in b)
            {
                listBox.Items.Add(a.Id + "      " + a.PersonId + "                       " + a.CourseName + "                    " + a.CourseGrade + "    " +
                    "                    " +
                    a.Comments);
            }
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EducationInsert ei = new EducationInsert();
            ei.Show();
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
                string id = (listBox.SelectedItem.ToString());


                string[] result = id.Split(' ');
                int id1 = Int32.Parse(result[0]);
                EducationUpdate eu = new EducationUpdate(id1);
                eu.Show();
                this.Close();
                
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
                if (MessageBox.Show("Confirm Delete?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    string id = (listBox.SelectedItem.ToString());


                    string[] result = id.Split(' ');
                    int id1 = Int32.Parse(result[0]);
                    var deleteOrderDetails = from details in educationList
                                             where details.Id == id1
                                             select details;


                    foreach (var a in deleteOrderDetails.ToList())
                    {
                        educationList.Remove(a);
                    }




                    this.Close();
                    MessageBox.Show("The Record has been deleted", "Success",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);
                }
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
            EducationInsert ei = new EducationInsert();
            ei.Show();
            this.Close();

        }
        private void mnuUpdate_Click(object sender, RoutedEventArgs e)
        {
            EducationWindow ew = new EducationWindow();
            ew.Show();
            this.Close();
        }
        private void mnuDelete_Click(object sender, RoutedEventArgs e)
        {
            EducationWindow ew = new EducationWindow();
            ew.Show();
            this.Close();
        }
    }
}
