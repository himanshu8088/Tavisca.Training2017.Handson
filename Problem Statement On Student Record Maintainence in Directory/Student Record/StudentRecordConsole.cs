using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
namespace StudentRecord
{
    public class StudentRecordConsole
    {
        static string studentDirectoryPath = "D:\\Student Record";
        static string logFilePath = "\\log.LOG";

        static void Main(string[] args)
        {
            Initialize();
            OptChoices();
        }

        #region Opt Choices from Console

        public static void OptChoices()
        {
            Console.WriteLine("\nKey for Operation:\n\t\t<1>AddRecordInDirectory New Record\n\t\t<2>List Record\n\t\t<3>UpdateRecordInDirectory Particular Record\n\t\t<4>View Particular Record\n");
            int choice = -1;

            while (true)
            {
                int.TryParse(Console.ReadLine(), out choice);
                if (choice == -1)
                    break;
                switch (choice)
                {
                    case 1:
                        Record.AddRecordInDirectory(GetStudentInfo());
                        break;
                    case 2:
                        Record.ListAllRecordFromDirectory();
                        break;
                    case 3:
                        Record.UpdateRecordInDirectory(FileName());
                        break;
                    case 4:
                        Record.ViewSingleStudentRecordFromDirectory(FileName());
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nKey for Operation:\n\t\t<1>AddRecordInDirectory New Record\n\t\t<2>List Record\n\t\t<3>UpdateRecordInDirectory Particular Record\n\t\t<4>View Particular Record\n");
            }
        }

        #endregion

        #region Directory Creation and Initialization

        public static void Initialize()
        {
            Path.StudentFilePathList = new List<string>();
            Path.DirectoryPath = studentDirectoryPath;
            Path.LogFilePath = string.Format("{0}{1}", studentDirectoryPath, logFilePath);

            if (!Directory.Exists(Path.DirectoryPath))
                Directory.CreateDirectory(studentDirectoryPath);
            if (!File.Exists(Path.LogFilePath))
                Logger.Log("Log file generated.");

        }

        #endregion

        public static void Empty()
        {
            Console.WriteLine("No Record Found!");
        }

        #region Opt file name from user for updation or view

        public static int FileName()
        {
            Console.WriteLine("\nEnter File Name Without Extension");
            int key;
            int.TryParse(Console.ReadLine(), out key);
            return key;
        }

        #endregion

        #region Input from Console and Validation

        public static Student GetStudentInfo()
        {
            Student student = new Student();
            CultureInfo provider = CultureInfo.InvariantCulture;

            while (true)
            {
                Console.WriteLine("Enter First Name:");
                student.FirstName = Console.ReadLine();
                if (Validation.isValidLetter(student.FirstName))
                    break;
                else
                    Console.WriteLine("!Please Try Again Invalid Input.");
            }
            while (true)
            {
                Console.WriteLine("Enter Last Name:");
                student.LastName = Console.ReadLine();
                if (Validation.isValidLetter(student.LastName))
                    break;
                else
                    Console.WriteLine("!Please Try Again Invalid Input.");
            }

            while (true)
            {
                int number;
                Console.WriteLine("Enter Mobile Number:");
                int.TryParse(Console.ReadLine(), out number);
                student.MobileNumber = number;
                if (Validation.isValidNumber(student.MobileNumber))
                    break;
                else
                    Console.WriteLine("!Please Try Again Invalid Input.");
            }

            while (true)
            {
                Console.WriteLine("Enter Email Id:");
                student.Email = Console.ReadLine();
                if (Validation.isValidEmail(student.Email))
                    break;
                else
                    Console.WriteLine("!Please Try Again Invalid Input.");
            }

            Console.WriteLine("Enter Address:");
            student.Address = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter Course Pursuing Currently:");
                student.Course = Console.ReadLine();
                if (Validation.isValidLetter(student.Course))
                    break;
                else
                    Console.WriteLine("!Please Try Again Invalid Input.");
            }

            while (true)
            {
                Console.WriteLine("Enter Mentor Name:");
                student.MentorName = Console.ReadLine();
                if (Validation.isValidLetter(student.MentorName))
                    break;
                else
                    Console.WriteLine("!Please Try Again Invalid Input.");
            }
            while (true)
            {
                int number;
                Console.WriteLine("Enter Emergency Contact Number:");
                int.TryParse(Console.ReadLine(), out number);
                student.EmergencyContactNumber = number;
                if (Validation.isValidNumber(student.EmergencyContactNumber))
                    break;
                else
                    Console.WriteLine("!Please Try Again Invalid Input.");
            }
            while (true)
            {
                Console.WriteLine("Enter a Date of Birth(e.g. dd/mm/yyyy):");
                DateTime date;
                bool val = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date);
                student.DOB = date.Date;
                if (val == true)
                    break;
                else
                    Console.WriteLine("!Please Try Again Invalid Input.");
            }

            return student;
        }

        #endregion

        #region Display on Console

        public static void DisplayAllRecordListOnConsole(int recNumber, Student student, string fileName)
        {
            if (student != null)
            {
                Console.WriteLine(string.Format("\n#{0}\nName:{1} {2}\nFile Name:{3}", recNumber, student.FirstName, student.LastName, fileName));
            }
            else
            {
                Console.WriteLine("\n#{0}\n!Empty\nFile Name:{1}", recNumber, fileName);
            }
        }

        public static void DisplaySingleStudentRecordOnConsole(Student student)
        {
            if (student != null)
                Console.WriteLine(string.Format("Name:{0} {1}\nMobile Number:{2}\nEmail ID:{3}\nAddress:{4}\nDate Of Birth:{5}\nCourse Pursuing:{6}\nMentor Name:{7}\nEmergency Number:{8}\n", student.FirstName, student.LastName, student.MobileNumber, student.Email, student.Address, student.DOB, student.Course, student.MentorName, student.EmergencyContactNumber));
            else
                Console.WriteLine("File doesnt exist.");
        }

        #endregion


    }
}
