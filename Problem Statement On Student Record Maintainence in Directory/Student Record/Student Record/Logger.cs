using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace StudentRecord
{
    class Logger
    {        
        public static void Log(string msg)
        {           
            string log = Serializable<string>.SerializeData(LogFormattedString(msg));
            File.AppendAllText(Path.LogFilePath, log);
        }
        public static string LogFormattedString(string logText)
        {
            return string.Format("{0} {1}.{2}", DateTime.Now, logText, Environment.NewLine);
        }
    }
}
