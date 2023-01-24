using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___23__23
{
    public class Instructor
    {
        //Fields
        string lastName;
        string firstName;
        string phone;

        //Constructor
        public Instructor(string lastName, string firstName, string phone)
        {
            //Keyyword  this
            this.lastName = lastName;
            this.firstName = firstName;
            this.phone = phone;
        }

        //Properties

        // how do you define a property
        // access modifier - type of the field - name of the field(Upper Case)
        public string LastName
        {
            //two new key words
            //Getter and Setter
            //Getter allows the user to read the Vaule
            //Setter allpws the user to write the vaule

            //get is used to read the information READ ONLY

            get 
            {
                return lastName;
            }

            set 
            {
                //vaule is the vaule being assinged by the user

                lastName = value;
            }
        }
    }
}
