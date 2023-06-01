using Persona;
using File;
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
            Dejan.Name = "Dejan";
            Dejan.Surname = "Stankovic";
            Dejan.Age = 44;
            Dejan.Sex = "Male";

            FileManager manager = new FileManager(@"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Males\Names.txt");

            manager.Write(Dejan);

            Person recovered = manager.Read();
            Console.WriteLine($"{recovered.Name} {recovered.Surname} {recovered.Age} {recovered.Sex}");

            //Directory.CreateDirectory(@"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Males");
            //Directory.CreateDirectory(@"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Females");

            //sw.WriteLine($"person name is {Dejan.name}, surname is {Dejan.surname}, age  {Dejan.age}, sex {Dejan.sex}");
            //sw.Close();


        }
    }
}