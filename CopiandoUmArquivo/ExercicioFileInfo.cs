using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTreze
{
    class ExercicioFileInfo
    {
        public static void ExecutarExercicioFileInfo()
        {
            string sourcePath = @"/home/victor/Desktop/File2.txt";
            string finalPath = @"/home/victor/Desktop/File3.txt";

            FileInfo fileInfo1 = new FileInfo(sourcePath);
            fileInfo1.CopyTo(finalPath);

            string[] lines = File.ReadAllLines(sourcePath);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            try
            {

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(e.Message);
            }
        }
    }
}