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
        private static void UpdateList()
        {
            DirectoryInfo d = new DirectoryInfo(Path.DirectoryPath);
            FileInfo[] Files = d.GetFiles("*.bin");
            foreach (FileInfo file in Files)
            {
                string filePath = Path.DirectoryPath + "\\" + file.Name;
                if (!Path.StudentFilePathList.Contains(filePath))
                    Path.StudentFilePathList.Add(filePath);
            }
        }

        public static void AddRecordInDirectory(Student student)
        {
            UpdateList();
            FileStream file = CreateStudentFile(student);
            if (file != null)
            {
                string studentEntry=Serializable<Student>.SerializeData(student);
                File.WriteAllText(file.Name, studentEntry);                
                Logger.Log("Serializable object info added for file "+file.Name);                
            }                
        }
        public static void UpdateRecordInDirectory(int id)
        {
            string searchFile = string.Format("{0}\\{1}.bin", Path.DirectoryPath, id);
            UpdateList();
            if (Path.StudentFilePathList.Contains(searchFile))
            {
                File.Delete(searchFile);
                int index=Path.StudentFilePathList.IndexOf(searchFile);
                Path.StudentFilePathList.RemoveAt(index);
                Student student = StudentRecordConsole.GetStudentInfo();
                AddRecordInDirectory(student);
                Logger.Log(string.Format("File updated Successfully.", id));                     
            }
            else
            {
                Logger.Log(string.Format("Could not update {0}, not found.", id));
            }            
        }
        public static void ListAllRecordFromDirectory()
        {
            UpdateList();
            int i = 0;
            if (Path.StudentFilePathList.Count == 0)
            {
                StudentRecordConsole.Empty();
                Logger.Log("No record found, trying to list all.");
            }
                
            foreach (string filePath in Path.StudentFilePathList)
            {
                i++;
                using (StreamReader file = File.OpenText(filePath))
                {
                    string data=file.ReadToEnd();
                    Student student=(Student)Serializable<Student>.DeserializeData(data);
                    StudentRecordConsole.DisplayAllRecordListOnConsole(i,student, filePath.Split('/').Last());
                    Logger.Log(string.Format("User listed all record"));
                }
            }
        }
        public static void ViewSingleStudentRecordFromDirectory(int id)
        {
            UpdateList();
            string searchFile = string.Format("{0}\\{1}.bin",Path.DirectoryPath,id);
            if (Path.StudentFilePathList.Count == 0)
                StudentRecordConsole.Empty();
            if (Path.StudentFilePathList.Contains(searchFile))
            {                
                using (StreamReader file = File.OpenText(searchFile))
                {
                    string data = file.ReadToEnd();
                    Student student = (Student)Serializable<Student>.DeserializeData(data);                    
                    StudentRecordConsole.DisplaySingleStudentRecordOnConsole(student);
                    Logger.Log(string.Format("User viewed record {0}.", id));
                }
            }
            else
            {
                Logger.Log(string.Format("Record not found, seraching for {0}.",id));
            }            
        }  
        public static FileStream CreateStudentFile(Student student)
        {
            string tempStudentFilePath = string.Format("{0}\\{1}.bin", Path.DirectoryPath, student.MobileNumber);
            if (!File.Exists(tempStudentFilePath))
            {
                using(FileStream file=File.Create(tempStudentFilePath))
                {
                    Logger.Log("New File Created: " + student.MobileNumber);
                    return file;
                }                
            }
            else
            {
                Logger.Log("Failed to Create: "+student.MobileNumber);
                return null;
            }            
        }
    }    
}
