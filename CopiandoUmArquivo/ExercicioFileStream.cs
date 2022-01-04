using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTreze
{
    class ExercicioFileStream
    {
        public static void ExecutarExercicioFileStream()
        {
            string path = @"/home/victor/Desktop/File1.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                fileStream = new FileStream(path, FileMode.Open);
                streamReader = new StreamReader(fileStream);
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
                if (fileStream != null) fileStream.Close();
            }
        }
    }
}