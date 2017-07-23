using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    public class Student
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int MobileNumber { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public DateTime DOB { set; get; }
        public string Course { set; get; }
        public string MentorName { set; get; }
        public int EmergencyContactNumber { set; get; }
    }
}
