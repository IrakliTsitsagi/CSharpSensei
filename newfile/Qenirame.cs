using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using persona;
namespace qenirame
{
    public class Qenirame
    {
        public static void chawere(Person obj)
        {
            string file = @"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Males\Names.txt";  // ese
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine($"{obj.name},{obj.surname},{obj.age},{obj.sex}");
            sw.Close();



        }

        public static string waikitxe()
        {

            string fileReader = @"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Males\Names.txt";
            StreamReader sr = new StreamReader(fileReader);
            string wakitxuli = "";
            wakitxuli = sr.ReadLine();
            // Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            return wakitxuli;
        }
    }
}
