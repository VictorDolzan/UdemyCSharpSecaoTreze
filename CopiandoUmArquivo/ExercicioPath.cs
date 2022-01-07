namespace CSharpSecaoTreze
{
    public class ExercicioPath
    {
        public static void ExecutarExercicioPath()
        {
            string path = @"/home/victor/Desktop/myfolder/File1.txt";
            try
            {
                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetExtention: " + Path.GetExtension(path));
                Console.WriteLine("GetFileNameWithoutExtention: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}