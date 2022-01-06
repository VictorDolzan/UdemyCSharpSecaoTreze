using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTreze
{
    class ExercicioStreamWriter
    {
        public static void ExecutarExercicioStreamWriter()
        {
            string sourcePath = @"/home/victor/Desktop/File1.txt";
            string targetPath = @"/home/victor/Desktop/File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}