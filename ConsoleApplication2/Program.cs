using Newtonsoft.Json;
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

            JsonSerializer js = new JsonSerializer();


 
            Complex q = new Complex();
            FileStream fs = new FileStream("complex.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            q.a = int.Parse(Console.ReadLine());
            q.b = int.Parse(Console.ReadLine());
            string res = JsonConvert.SerializeObject(q);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(res);

            sw.Close();
            fs.Close();

            FileStream fs2 = new FileStream("complex.txt", FileMode.Open, FileAccess.Read);
  
            StreamReader hw = new StreamReader(fs2);
            res = hw.ReadLine();
            Complex h = JsonConvert.DeserializeObject<Complex>(res);
            Console.WriteLine(h.a +"+" + h.b+ "i");


        }
    }
}