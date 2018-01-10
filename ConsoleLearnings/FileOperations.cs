using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
namespace ConsoleLearnings
{
    class Fileoperations
    {
        public static void operationsFile()
        {
            Console.WriteLine("Hi Teja");



            //1
            /*
            string filename = @"D:\desktop\teja";
            FileStream fs1 = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs1);
            Console.WriteLine("Enter the text which you want to write to the file");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();*/

            //DirectoryInfo inf=  Directory.CreateDirectory(filename);
            //Console.WriteLine(inf.FullName);
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("tdddfdfeja");
            Console.WriteLine(sb1);


            string path = @"D:\desktop\kanumuri";
            string path1 = "teja";


            DirectoryInfo di1 = new DirectoryInfo(path);
            DirectoryInfo di2 = di1.CreateSubdirectory(path1);
            Console.WriteLine(di2.FullName);
            FileInfo[] a1 = di1.GetFiles();

            if (1 != 1)
            {
                Console.WriteLine("File eists");

            }
            else
            {

                FileStream a2 = new FileStream(di2.FullName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter a3 = new StreamWriter(a2);
                a3.WriteLine(sb1);
                a3.Close();
                a2.Close();
                a2.Close();
            }

            //string tempFolderAbsolutePath = @"D:\desktop\Temp1";
            //string subFolderRelativePath = @"SubTemp2";
            //string subFolderRelativePath1 = @"SubsubTemp3";

            //DirectoryInfo tempFolder = new DirectoryInfo(tempFolderAbsolutePath);
            //DirectoryInfo a = tempFolder.CreateSubdirectory(subFolderRelativePath);
            //DirectoryInfo b = a.CreateSubdirectory(subFolderRelativePath1);

            //FileInfo[] aa = new DirectoryInfo(tempFolderAbsolutePath).GetFiles();
            //foreach (var c1 in aa) {

            //    Console.WriteLine(c1);
            //}


            //string tempFileName = String.Concat(Guid.NewGuid().ToString(), @".tmp");
            //string textData = @"Temp text data";

            //using (StreamWriter streamWriter = File.CreateText(Path.Combine(subFolder.FullName, tempFileName)))
            //{
            //    streamWriter.Write(textData);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}
            //if (File.Exists(filename)) { Console.WriteLine("File "); }
            //fs1.Close();

            Console.ReadLine();
        }
    }
}