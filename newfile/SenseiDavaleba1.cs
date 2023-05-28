using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace SenseiDavaleba1
{
    internal class SenseiDavaleba1
    {
        static void Main(string[] args)
        {
            Person Dejan = new Person();
            Dejan.name = "Dejan";
            Dejan.surname = "Stankovic";
            Dejan.age = 44;
            Dejan.sex = "Male";

            Qenirame.chawere(Dejan);
            Qenirame.waikitxe();


            Person Recovered = new Person();
            string fullInfo = Qenirame.waikitxe();
            string[] array = fullInfo.Split(',');
            Recovered.name = array[0];
            Recovered.surname = array[1];
            Recovered.age = int.Parse(array[2]);
            Recovered.sex = array[3];
            Console.WriteLine(array[0] + " " + array[1] + " " + array[2] + " " + array[3]);

            //Directory.CreateDirectory(@"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Males");
            //Directory.CreateDirectory(@"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Females");

            //sw.WriteLine($"person name is {Dejan.name}, surname is {Dejan.surname}, age  {Dejan.age}, sex {Dejan.sex}");
            //sw.Close();


        }
    }

    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
    }


    public static class Qenirame
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