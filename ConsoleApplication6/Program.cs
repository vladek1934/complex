using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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



            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            Complex q = new Complex();
            FileStream fs = new FileStream("complex.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            q.a = int.Parse(Console.ReadLine());
            q.b = int.Parse(Console.ReadLine());



            xs.Serialize(fs, q);
            fs.Close();
            FileStream fs2 = new FileStream("complex.txt", FileMode.Open, FileAccess.Read);
            Complex h = new Complex();
            h = xs.Deserialize(fs2) as Complex;
            Console.WriteLine(h.a + " + " + h.b + "i");


        }
    }
}