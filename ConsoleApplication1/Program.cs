using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ConsoleApplication9
{
    public class Complex
    {
        public int a;
        public int b;

    }
    class Program
    {
        static void Main(string[] args)
        {



            BinaryFormatter formatter = new BinaryFormatter();
            Complex q = new Complex();
            FileStream fs = new FileStream("complex.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fs2 = new FileStream("complex2.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            q.a = int.Parse(Console.ReadLine());
            q.b = int.Parse(Console.ReadLine());


          

            formatter.Serialize(fs, q.a);
            formatter.Serialize(fs2, q.b);
            fs.Close();
            fs2.Close();

            FileStream fs3 = new FileStream("complex.dat", FileMode.Open, FileAccess.Read);
            FileStream fs4 = new FileStream("complex2.dat", FileMode.Open, FileAccess.Read);
            int a = (int)formatter.Deserialize(fs3) ;
            int b = (int)formatter.Deserialize(fs4);
            Complex h = new Complex();
            h.a = a;
            h.b = b;
            Console.WriteLine(h.a + " + " + h.b + "i");
        }
    }
}