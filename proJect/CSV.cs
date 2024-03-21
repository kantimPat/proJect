using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proJect
{
     public class CSV
    {
        private string path = @"D:\oopLap\proJect\Data.csv";
        public bool CSVfile(string name_products , int orders , int total)
        {
            string content = "\n"+name_products + "," + orders + "," + total;
            try
            {
                File.AppendAllText(path, content);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
