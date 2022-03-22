using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace ConsoleApp1
{
    [Serializable]
    class serial
    {
        public string name = "Giridharan";
        public int age = 24;
        public string gender = "Male";
        public string empid = "AXCD";
    }
    class Task2203
    {
        public void SerialtoFile()
        {
            serial stobj = new serial();
            FileStream fs = new FileStream("emp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, stobj);
            fs.Close();
        }
        public void DeSerialData()
        {
            FileStream fs = new FileStream("emp.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            serial eobj = (serial)f.Deserialize(fs);
            Console.WriteLine(eobj.name);
            Console.WriteLine(eobj.age);
            Console.WriteLine(eobj.gender);
            Console.WriteLine(eobj.empid);
        }

        public static void Main()
        {
            Task2203 obj = new Task2203();
            obj.SerialtoFile();
            obj.DeSerialData();
            Console.ReadLine();

        }
    }
}
