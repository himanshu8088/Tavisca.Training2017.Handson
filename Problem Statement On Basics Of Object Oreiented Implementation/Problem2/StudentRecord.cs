using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*                                          Problem 2.
  Write a program to display student information. Accept Student’s name, Roll no, Age, class, and university name and display it on console.
*/
namespace Problem2
{
    public class StudentRecord : IRecord
    {
        private string name;
        private int age;
        private string university;
        private int studentClass;
        private int rollNumber;

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public string GetUniversity()
        {
            return university;
        }
        public void SetUniversity(string university)
        {
            this.university = university;
        }
        public int GetRollNumber()
        {
            return rollNumber;
        }
        public void SetRollNumber(int rollNumber)
        {
            this.rollNumber = rollNumber;
        }
        public int GetStudentClass()
        {
            return studentClass;
        }
        public void SetStudentClass(int studentClass)
        {
            this.studentClass = studentClass;
        }
        public override string ToString()
        {
            return string.Format("Name:{0}\nClass:{1}\nAge:{2}\nRoll Number:{3}\nUniversity:{4}",GetName(),GetStudentClass(),GetAge(),GetRollNumber(),GetUniversity());
        }
    }


}
