using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
namespace Tavisca.Training2017.HandsOn.HttpRespOnCo
{
    class Program
    {
        public static void Main(string[] args)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp("http://codejam.tavisca.com/");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
          
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);            
            Console.WriteLine("Response stream received.\n");
            Console.WriteLine(readStream.ReadToEnd());
            response.Close();
            readStream.Close();
            Console.ReadKey();
        }
    }
}
