using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SearchSubString
{
    public class Search
    {
        private static string str;
        private static string substr;
        public Search(string org_str, string sub_str)
        {
            str = org_str;
            substr = sub_str;
        }
        public Boolean FindMatch()
        {
            Stack stack = new Stack(1);                        
            for(int i=0; i <= str.Length - substr.Length; i++)
            {                    
                    stack.Push(str.Substring(i, substr.Length ));                    
                    if (stack.Pop().Equals(substr))
                        return true;                
            }
            return false;
        }
    }
}
