using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace StudentRecord
{
    public class Record
    {        
        private static string studentFilePath="";
        public static void Add(Student student)
        {
            if (CreateStudentFile(student))
            {
                string studentEntry=Serializable<Student>.SerializeData(student);
                File.WriteAllText(studentFilePath, studentEntry);
                Logger.Log("Serializable object info added for file "+studentFilePath);
            }                
        }
        public static void Update(int id)
        {
            string searchFile = string.Format("{0}\\{1}.txt", Path.DirectoryPath, id);
            if (Path.StudentFilePathList.Contains(searchFile))
            {
                File.Delete(searchFile);
                Student student = StudentRecordConsole.GetStudentInfo();
                Add(student);
                Logger.Log(string.Format("File {0} updated successfully.", id));                     
            }
            else
            {
                Logger.Log(string.Format("Could not update {0}, not found.", id));
            }
        }
        public static void ListAll()
        {
            int i = 0;
            if (Path.StudentFilePathList.Count == 0)
                StudentRecordConsole.Empty();
            foreach (string filePath in Path.StudentFilePathList)
            {
                i++;
                using (StreamReader file = File.OpenText(filePath))
                {
                    string data=file.ReadToEnd();
                    Student student=(Student)Serializable<Student>.DeserializeData(data);
                    StudentRecordConsole.ListAllRecordOnConsole(i,student);
                    Logger.Log(string.Format("User listed record"));
                }
            }
        }
        public static void ViewRecord(int id)
        {            
            string searchFile = string.Format("{0}\\{1}.txt",Path.DirectoryPath,id);
            if (Path.StudentFilePathList.Count == 0)
                StudentRecordConsole.Empty();
            if (Path.StudentFilePathList.Contains(searchFile))
            {                
                using (StreamReader file = File.OpenText(searchFile))
                {
                    string data = file.ReadToEnd();
                    Student student = (Student)Serializable<Student>.DeserializeData(data);                    
                    StudentRecordConsole.DisplayStudentRecord(student);
                    Logger.Log(string.Format("User viewed record {0}.", id));
                }
            }
            else
            {
                Logger.Log(string.Format("Record not found, seraching for {0}.",id));
            }            
        }  
        public static bool CreateStudentFile(Student student)
        {
            studentFilePath = string.Format("{0}\\{1}.txt", Path.DirectoryPath, student.MobileNumber);
            if (!File.Exists(studentFilePath))
            {
                File.Create(studentFilePath).Dispose();
                Path.StudentFilePathList.Add(studentFilePath);
                Logger.Log("Success. "+student.MobileNumber+".txt created within following path "+Path.DirectoryPath);
                return true;
            }
            else
            {
                Logger.Log("Failed to create. "+student.MobileNumber + ".txt already exists within following path "+ Path.DirectoryPath);
                return false;
            }            
        }
    }    
}
