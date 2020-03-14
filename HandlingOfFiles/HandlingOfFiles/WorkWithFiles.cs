using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandlingOfFiles
{
    class WorkWithFiles
    {
        public static string[] filesList;        
        public static string directoryPath;
        public static void ChoiseDirectory(string pathToDirectory)
        {            
            if (!Directory.Exists(pathToDirectory)) Directory.CreateDirectory(pathToDirectory);
        }
        public static void WriteToFile(string nameOfFile, string text)
        {
            string pathToFile = Path.Combine(directoryPath, nameOfFile);
            if (!File.Exists(pathToFile))
            {
                using (StreamWriter writer = File.CreateText(pathToFile))
                {
                    writer.WriteLine(text);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathToFile, true))
                {
                    writer.WriteLine(text);
                }
            }
        }
        public static void ReadFromFile(string nameOfFile)
        {
            string pathToFile = Path.Combine(directoryPath, nameOfFile);
            if (File.Exists(pathToFile))
            {
                using (StreamReader reader = new StreamReader(pathToFile))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
        }
        public static void DeleteFollowingFile(string nameOfFile)
        {
            string pathToFile = Path.Combine(directoryPath, nameOfFile);
            if (File.Exists(pathToFile)) File.Delete(pathToFile);
        }
        public static void DeleteFollowingDirectory(string pathToDirectory)
        {
            if (Directory.Exists(pathToDirectory)) Directory.Delete(pathToDirectory, true);
        }
        public static void ChoiseFiles(string pathToDirectory)
        {
            if(!Directory.Exists(pathToDirectory))
            {
                Console.WriteLine($"Directory \"{pathToDirectory}\" not exist");
                return;
            }
            filesList = Directory.GetFiles(pathToDirectory);
            if (filesList.Length!=0)
            {
                Console.WriteLine($"There are following files in the folder \"{Path.GetFullPath(directoryPath)}\"");
                for (int i = 0; i < filesList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Path.GetFileName(filesList[i])}");
                }
                do
                {
                    Console.Write("\nEnter file number: ");
                    string ent = Console.ReadLine();                    
                    if ((int.TryParse(ent, out int entnum)) & entnum <= filesList.Length & entnum > 0)
                    {
                        ReadFromFile(Path.GetFileName(filesList[entnum-1]));
                        break;
                    }
                    else Console.WriteLine("\nTry again!");
                }
                while (true);
            }
            else Console.WriteLine("The folder is empty");
        }
    }
}
