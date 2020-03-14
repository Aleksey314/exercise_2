using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandlingOfFiles
{
    class Program
    {
        static void Main(string[] args)
        {            
            WorkWithFiles.directoryPath= Path.Combine(Directory.GetCurrentDirectory(), "TempFolder");
            WorkWithFiles.ChoiseDirectory(WorkWithFiles.directoryPath);
            WorkWithFiles.WriteToFile("temp1.txt", ExampleText.text1);
            WorkWithFiles.WriteToFile("temp2.txt", ExampleText.text2);
            WorkWithFiles.WriteToFile("temp3.txt", ExampleText.text3);
            WorkWithFiles.ChoiseFiles(WorkWithFiles.directoryPath);
            WorkWithFiles.DeleteFollowingDirectory(WorkWithFiles.directoryPath);

            WorkWithFiles.directoryPath = @"d:\op";
            WorkWithFiles.ChoiseFiles(WorkWithFiles.directoryPath);
        }
    }
}
