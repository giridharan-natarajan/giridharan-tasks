using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace ConsoleApp1
{
    class Task21032
    {
        public static void Main()
        {
            FileStream fs = new FileStream("T:\\softura\\ Sweets.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter bw = new StreamWriter(fs);
            List<string> str = new List<String>();
            str.Add("Chocolava");
            str.Add("choco mouse");
            str.Add("Dokla");
            foreach (string d in str)
            {
                bw.Write("\n" + d);
            }
            bw.Flush();
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream("T:\\softura\\ Sweets.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            String s = sr.ReadToEnd();
            sr.Close();
            fs1.Close();
            Console.WriteLine(s);
            FileInfo fi = new FileInfo(@"T:\softura\sweets.txt");

            Console.WriteLine(fi.CreationTime);
            Console.Read();
            Console.ReadLine();
        }
    }
}
