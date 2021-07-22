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
    /// Interaction logic for EducationInsert.xaml
    /// </summary>
    public partial class EducationInsert : Window
    {
        List<Education> educationList;

        public EducationInsert()
        {
            InitializeComponent();
            educationList = returnList.EducationList;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            int id1;
            int id;
            double grade;
            bool success1 = Int32.TryParse(txtPersonId.Text.ToString(), out id1);
            bool success2 = Int32.TryParse(txtId.Text, out id);
            bool success = Double.TryParse(txtCourseGrade.Text, out grade);
            if (success1 && success2 && success)//&& success1 && success2)
            {


                Education ed = new Education(Int32.Parse(txtId.Text.ToString()), Int32.Parse(txtPersonId.Text), txtCourseName.Text, Double.Parse(txtCourseGrade.Text), txtComments.Text);
                educationList.Add(ed);
                this.Close();
                MessageBox.Show("The record has been inserted", "Information",
      MessageBoxButton.OK,
      MessageBoxImage.None);
                return;

            }

            else
            {
                MessageBox.Show("The Person Id and Id should be Integer and course grade should be double", "Error",
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
