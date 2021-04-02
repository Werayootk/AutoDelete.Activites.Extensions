using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoDelete;
using System.Collections.Generic;

namespace TestDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime strDate = new DateTime();
            DateTime endDate = new DateTime();

            strDate = Convert.ToDateTime("01/04/2021 05:50:06");
            endDate = Convert.ToDateTime("03/04/2021 05:50:06");

            var DefinePath = @"D:\PathTest";
            bool chk = false;
            bool end = delete(DefinePath, chk, strDate, endDate);
            Console.WriteLine(end.ToString());
            Console.ReadKey();
        }

        /*
 * TO DO Logic
 * Get Path folder and check not file else is file throw exception ok
 * check all exist file in folder and stor name in list
 * foreach loop delted all files in list 
 * and condition get create date data from file name and check period between and end date
 * pass condition delete that file
*/
        public static Boolean delete(string path, bool flag,DateTime strDate,DateTime endDate)
        {
            FileAttributes attr = File.GetAttributes(path);
            if (attr.HasFlag(FileAttributes.Directory))
            {
                Console.WriteLine("Please waitt ........................");
                List<string> FileName = new List<string>();
                FileName = Directory.GetFiles(path).ToList();

                foreach (var item in FileName)
                {
                    DateTime _dateFileCreate = new DateTime();
                    var _path = Path.Combine(path,item);
                    _dateFileCreate = File.GetCreationTime(_path);
                    if (strDate <= _dateFileCreate && endDate >= _dateFileCreate)
                    {
                        File.Delete(_path);
                    }
                }

            }
            else
            {
                Console.WriteLine("This is a file, Please give me a Path");
            }
            return flag;
        }
    }
}
