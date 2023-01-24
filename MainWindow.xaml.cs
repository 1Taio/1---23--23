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

namespace _1___23__23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       

        List< Student> students = new List< Student>();
        public MainWindow()
        {
           
            Instructor breshna = new Instructor("Naim", "Breshna", "1234567898");

            //properties

            breshna.LastName = "fsdfads";
            MessageBox.Show(breshna.LastName);

            InitializeComponent();
            
        }

        public static void classEx() 
        {

            //Creat a class new class
            // Class called student


            // how do we add a class?
            // we right click on file under our solution
            // select add
            // 
            //-----------------------------------------------------------------------//
            // WHat is an instance
            // How do we make it
            // what does the new keyword do
            //----------------------------------------------------------------------//    
            // instantiate
            // declare and instantiate

            // two types of date; Vaule and Reference



            // this is how you create  a new instance
            // of a movie


            // new keyword means we are creating a
            // new object in memory


            // how do you access members of an object
            // use the dot .operator 
            Movie darkKnight = new Movie();
            darkKnight.MovieName = "Dark Knight";
            darkKnight.Year = 2008;


            MessageBox.Show(darkKnight.Year.ToString());


            //Create a new instance of a student object

            //what is new Student() calling?
            //The default constructor of student
            //Wh

            //What happenes to the deafult constructor
            //when i make a new constructor?

            //It goes away
            Student student = new Student("Breshna", "Naim", 110, 115);
            Student student2 = new Student("Alex", "Garcia");




            //how do i give my student a first name
            //student.FirstName = "Breshna";
            //student.LastName = "Naim";
            //student.CSIGrade = 110;
            //student.GenEDGrade = 115;


            students.Add(student);
            students.Add(student2);


            MessageBox.Show(formatedStudent(student2));
        }
      internal string formatedStudent(Student student)
        {
            string studentInformation = student.FirstName + " " + student.LastName + " " + student.CSIGrade + " " + student.GenEDGrade;
            return studentInformation;
        }
    }
}
