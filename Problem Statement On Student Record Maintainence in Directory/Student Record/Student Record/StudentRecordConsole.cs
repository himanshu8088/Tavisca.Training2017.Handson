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
        static string cacheFilePath = "\\CacheData.txt";
        static string logFilePath = "\\log.txt";

        static void Main(string[] args)
        {
            CreateFile();
            Console.WriteLine("Key for Operation:\nAdd<1>\nList<2>\nUpdate<3>\nView<4>\n");
            int choice = -1;

            while (true)
            {
                int.TryParse(Console.ReadLine(), out choice);
                if (choice == -1)
                    break;
                switch (choice)
                {
                    case 1:
                        Record.Add(GetStudentInfo());
                        break;
                    case 2:
                        Record.ListAll();
                        break;
                    case 3:
                        Record.Update(FileName());
                        break;
                    case 4:
                        Record.ViewRecord(FileName());
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nKey for Operation:\nAdd<1>\nList All<2>\nUpdate<3>\nView Record<4>\n");
            }
        }

        public static int FileName()
        {
            Console.WriteLine("\nEnter Mobile Number");
            int key;
            int.TryParse(Console.ReadLine(), out key);
            return key;
        }

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
                bool val=DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date);
                student.DOB = date.Date;
                if (val == true)
                    break;
                else
                    Console.WriteLine("!Please Try Again Invalid Input.");

            }

            return student;
        }

        public static void ListAllRecordOnConsole(int recNumber, Student student)
        {
            if (student != null)
            {
                Console.WriteLine("#" + recNumber);
                Console.WriteLine(string.Format("Name:{0} {1}", student.FirstName, student.LastName));
            }
            else
            {
                Console.WriteLine("No Record Found");
            }
        }

        public static void DisplayStudentRecord(Student student)
        {
            if (student != null)
                Console.WriteLine(string.Format("Name:{0} {1}\nMobile Number:{2}\nEmail ID:{3}\nAddress:{4}\nDate Of Birth:{5}\nCourse Pursuing:{6}\nMentor Name:{7}\nEmergency Number:{8}\n", student.FirstName, student.LastName, student.MobileNumber, student.Email, student.Address, student.DOB, student.Course, student.MentorName, student.EmergencyContactNumber));
            else
                Console.WriteLine("File doesnt exist.");
        }

        public static void CreateFile()
        {
            Path.DirectoryPath = studentDirectoryPath;
            Path.CacheDataFilePath = string.Format("{0}{1}", studentDirectoryPath, cacheFilePath);
            Path.LogFilePath = string.Format("{0}{1}", studentDirectoryPath, logFilePath);

            if (!Directory.Exists(Path.DirectoryPath))
            {
                Directory.CreateDirectory(studentDirectoryPath);
            }
            if (!File.Exists(Path.LogFilePath))
            {
                File.WriteAllText(Path.LogFilePath, "");
                Logger.Log("Log file generated.");
            }
            if (!File.Exists(Path.CacheDataFilePath))
            {
                Path.StudentFilePathList = new List<string>();
                string cacheDataFile = Serializable<List<string>>.SerializeData(Path.StudentFilePathList);
                File.WriteAllText(Path.CacheDataFilePath, cacheDataFile);
            }
            else
            {
                using (StreamReader file = File.OpenText(Path.CacheDataFilePath))
                {
                    string data = file.ReadToEnd();
                    Path.StudentFilePathList = (List<string>)Serializable<List<string>>.DeserializeData(data);
                }                
            }
        }

        public static void Empty()
        {
            Console.WriteLine("No Record Found!");
        }
    }
}
