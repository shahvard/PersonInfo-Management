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
    /// Interaction logic for EducationUpdate.xaml
    /// </summary>
    public partial class EducationUpdate : Window
    {
        List<Education> educationList = new List<Education>();

        int selectedValue;
        public EducationUpdate(int selected)
        {
            InitializeComponent();
            educationList = returnList.EducationList;
            selectedValue = selected;
            txtId.Content = selectedValue.ToString();

            var UpdateOrderDetails = from details in educationList
                                     where details.Id == selected
                                     select details;

            foreach (var a in UpdateOrderDetails.ToList())
            {

                txtId.Content = a.Id.ToString();
                txtPersonId.Text = a.PersonId.ToString();
                txtCourseName.Text = a.CourseName;
                txtCourseGrade.Text = a.CourseGrade.ToString();
                txtComments.Text = a.Comments;



            }





        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            int id1;
            double grade;

            bool success1 = Int32.TryParse(txtPersonId.Text.ToString(), out id1);
            bool success2 = Double.TryParse(txtCourseGrade.Text, out grade);
            if (success1 && success2)//&& success1 && success2)
            {



                int id = Int32.Parse(txtId.Content.ToString());
                var UpdateOrderDetails = from details in educationList
                                         where details.Id == id
                                         select details;
                foreach (var a in UpdateOrderDetails.ToList())
                {

                    if (MessageBox.Show("Confirm Update?", "Confirm Update", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        a.Id = Int32.Parse(txtId.Content.ToString());
                        a.PersonId = Int32.Parse(txtPersonId.Text);
                        a.CourseName = txtCourseName.Text;
                        a.CourseGrade = Double.Parse(txtCourseGrade.Text);
                        a.Comments = txtComments.Text;
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
                MessageBox.Show("The Person Id should be int and grade should be double", "Error",
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
