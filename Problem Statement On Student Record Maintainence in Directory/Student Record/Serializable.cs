using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace StudentRecord
{
    public class Serializable<T>
    {
        public static string SerializeData(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static Object DeserializeData(string serialzedData)
        {
            return JsonConvert.DeserializeObject<T>(serialzedData);
        }
    }
}
