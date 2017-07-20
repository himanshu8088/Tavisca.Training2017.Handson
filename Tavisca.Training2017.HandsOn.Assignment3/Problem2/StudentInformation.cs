using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public enum InfoType { Name,Age,Class,University,RollNumber};
    public class StudentInformation
    {
        StudentRecord info;
        public StudentInformation()
        {
            info = new StudentRecord();
            SetStudentInformation();
            DisplayStudentInfo();
        }
        private void SetStudentInformation()
        {
            int age,studClass,rollNum;

            Console.WriteLine("Please Enter Name");
            info.SetName(Console.ReadLine());

            Console.WriteLine("Please Enter Age");
            int.TryParse(Console.ReadLine(),out age);
            info.SetAge(age);

            Console.WriteLine("Please Enter Class");
            int.TryParse(Console.ReadLine(), out studClass);
            info.SetStudentClass(studClass);

            Console.WriteLine("Please Enter University");
            info.SetUniversity(Console.ReadLine());

            Console.WriteLine("Please Enter Roll Number");
            int.TryParse(Console.ReadLine(), out rollNum);
            info.SetRollNumber(rollNum);
        }   
        public void DisplayStudentInfo()
        {
            Console.WriteLine(info.ToString());
        }

        
        
    }

    
}
