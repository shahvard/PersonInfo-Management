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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p1 = new Person(1,"Robert","Brampton","robert@gmail.com",24,"19/09/1998");
        Person p2 = new Person(2, "John", "Brampton", "john@gmail.com", 23, "9/10/1999");
        Person p3 = new Person(3, "Harsh", "Mississauga", "harsh@gmail.com", 21, "1/12/2000");
        Person p4 = new Person(4, "Purv", "Toronto", "purv@gmail.com", 18, "05/01/2002");
        Person p5 = new Person(5, "Andy", "Brampton", "andy@gmail.com", 30, "09/04/1990");
        List<Person> personList = new List<Person>() ;

        SportsTeam s1 = new SportsTeam(101, 1, "CSK", "Brampton");
        SportsTeam s2 = new SportsTeam(102, 2, "MI", "Mississauga");
        SportsTeam s3 = new SportsTeam(103, 3, "KKR", "Toronto");
        SportsTeam s4 = new SportsTeam(104, 4, "PSK", "Hamilton");
        SportsTeam s5 = new SportsTeam(105, 5, "DC", "Brampton");
        List<SportsTeam> sportsList = new List<SportsTeam>();

        Personality pe1 = new Personality(1001, 1, 8, "Blood", "Christian");
        Personality pe2 = new Personality(1002, 2, 9, "Inception", "James");
        Personality pe3 = new Personality(1003, 3, 10, "American", "Daniel");
        Personality pe4 = new Personality(1004, 4, 8, "Dark Night", "Tom Holland");
        Personality pe5 = new Personality(1005, 5, 9, "Godfather", "Tom Hardy");
        List<Personality> personalityList = new List<Personality>();

        Education e1 = new Education(501, 1, "CST", 98.1, "Excellent");
        Education e2 = new Education(502, 2, "CSE", 55.1, "Poor");
        Education e3 = new Education(503, 3, "Mechanical", 65, "Average");
        Education e4 = new Education(504, 4, "Elec", 85, "Good");
        Education e5 = new Education(505, 5, "CST", 95.1, "Excellent");
        List<Education> educationList = new List<Education>();

        public object MessageBoxButtons { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            personList.Add(p1);
            personList.Add(p2);
            personList.Add(p3);
            personList.Add(p4);
            personList.Add(p5);
            returnList.PersonList = personList;
            sportsList.Add(s1);
            sportsList.Add(s2);
            sportsList.Add(s3);
            sportsList.Add(s4);
            sportsList.Add(s5);
            returnList.SportsList = sportsList;
            personalityList.Add(pe1);
            personalityList.Add(pe2);
            personalityList.Add(pe3);
            personalityList.Add(pe4);
            personalityList.Add(pe5);
            returnList.PersonalityList = personalityList;
            educationList.Add(e1);
            educationList.Add(e2);
            educationList.Add(e3);
            educationList.Add(e4);
            educationList.Add(e5);
            returnList.EducationList = educationList;

        }

        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New Page");
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             PersonWindow p = new PersonWindow();
           
             p.Show();
           


           
            

            var nameSorted = from emp in personList select emp;



        
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SportsWindow sw = new SportsWindow();
            sw.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PersonalityWindow pw = new PersonalityWindow();
            pw.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           EducationWindow ew = new EducationWindow();
            ew.Show();
        }
    }
}
