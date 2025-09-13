using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FileHandling fh=new FileHandling();
//fh.CheckingFileExistOrNot();
//fh.ReadingDataFromFile();
//fh.CreatingCopyOfATextFile();
//fh.DirectoryOrFolder();

namespace PractisePrograms
{
    internal class FileHandling
    {
        public void CheckingFileExistOrNot()
        {
            //It checks that wether the file is available in our drive or not.
            string path = @"E:\data.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File is Available");
            }
            else
            {
                Console.WriteLine("File Not Available");
            }
        }

        public void ReadingDataFromFile()
        {
            //It read the file data in c sharp application.
            //We use ReadAllText method to read the data from text file
            string path = @"E:\data.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Is Available And data is:");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("File Not Available");
            }
            
        }
        public void CreatingCopyOfATextFile()
        {
            //This Is first version.
            //This methods creats a copy of existing file
            //We use Copy method to craete a copy of our file.
            string path1 = @"E:\Ashish.txt";//Yeh us file ka path hai jisko mujhe copy banana hai 
            string path2 = @"E:\Ashish1.txt";
            //yeh us file ka path banya hai jiska mujhe copy banana hai path1 ka.
            File.Copy(path1, path2);//it does not overwrite.
            //File.Copy(path1, path2,true);//Use this for overwriting.
        }
        public void DirectoryOrFolder()
        {
            //It is used to create,delete and move directry.
            //it is also used to create subdirectory.it is sealed class.
            //we use DirectoryInfo class for creating and deleting directory.

            //1:->Create: this method is used to create a new directory.
            string path = @"E:\MyDirectory";
            //Yeh bata raha hai ki E drive me MyDirectory name ka ek folder banyo.
            DirectoryInfo di1 = new DirectoryInfo(path);
            //di1.Create();
            Console.WriteLine("Directory or Folder Created");

            //2:->CreateSubdirectory: this method is used to create a sub directory in a directory.
            DirectoryInfo di2 = new DirectoryInfo(path);
            //di2.CreateSubdirectory("SubDirectory");

            //4:->MoveTo: this method is used to move a directory data in another directory.
            DirectoryInfo di3 = new DirectoryInfo(path);
            string path2 = @"E:\MyDirectory2";
            //yeha par main MyDirectory or path ka data MyDirectory2 me transfer
            //kar raha hoo data transfer hone ke baad MyDirectory apne aap delete ho jayega
            //di3.MoveTo(path2);

            //4:->Delete: this method is used to delete directory,sudirectory or file.
            DirectoryInfo di4 = new DirectoryInfo(path2);
            //di4.Delete(true);

            //5:->GetDirectories: this method is used to the sub directories in the given directories
            //6:->GetFiles: this method is used to get the file form the given directory
            string path3 = @"E:\Name";
            DirectoryInfo di5 = new DirectoryInfo(path3);
            DirectoryInfo[] dirs = di5.GetDirectories();
            foreach (var item in dirs)
            {
                Console.WriteLine(item);

                //Console.WriteLine(item.GetFiles().Length);
                //it is used to get files
            }

            //Properties in directories..............
            string path4 = @"E:\Name\New1";
            DirectoryInfo di6 = new DirectoryInfo(path4);
            //1:-Name and FullName
            Console.WriteLine(di6.Name);
            Console.WriteLine(di6.FullName);
            //2:-LastAccessTime
            Console.WriteLine(di6.LastAccessTime);
            //2:-CreationTime
            Console.WriteLine(di6.CreationTime);
            //3:-Attributes
            Console.WriteLine(di6.Attributes);
            //4:-Parent
            Console.WriteLine(di6.Parent);
            //5:-Root
            Console.WriteLine(di6.Root);
            //6:-LastWriteTime
            Console.WriteLine(di6.LastWriteTime);
        }

    }
}
