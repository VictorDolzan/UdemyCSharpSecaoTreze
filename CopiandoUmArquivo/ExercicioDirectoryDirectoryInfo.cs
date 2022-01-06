using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTreze
{
    class ExercicioDirectoryDirectoryInfo
    {
        public static void ExecutarDirectoryDirectoryInfo()
        {            
            string path = @"/home/victor/Desktop/myfolder";
            try
            {
                IEnumerable<string> folders =  Directory.EnumerateDirectories(path,"*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path,"*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach(string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + @"/newfolder2");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}