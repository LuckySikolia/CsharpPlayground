using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        //the constructor
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }


        //method to tell if the student has honors
        public bool HasHonors()
        {
            if(gpa >= 3.8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
