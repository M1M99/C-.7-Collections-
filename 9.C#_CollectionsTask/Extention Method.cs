using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.C__CollectionsTask
{
    public static class Extention_Method
    {
        public static void SimpleMethod (this Dictionary<int, string> dict)
        {
            foreach (var key in dict) {
                Console.WriteLine(key);
            }
        }
    }
}
