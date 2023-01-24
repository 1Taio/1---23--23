using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___23__23
{
    public class Student
    {
        // fields

        public string FirstName;
        public string LastName;
        public double CSIGrade;
        public double GenEDGrade;


        // constructor
        // how do you create constructor?
        // Access modifer - ClassName - Parenthesis
        //Default constructor(takes no arguments)


        //Constructors allow/ restrict what is need to creaet an object
        // guarentee vaules for fields with a constructor

        public Student(string firstName, string lastName, int CSI, int GenEd)
        {
            //how you assign vaules to field
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = CSI;
            GenEDGrade = GenEd;
        }

        // create a 2nd constructor
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = -1;
            GenEDGrade = -1;
        }


        // properties
        //Methods
    }
}
