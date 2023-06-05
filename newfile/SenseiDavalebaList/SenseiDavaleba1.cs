using Persona;
using File;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Globalization;

namespace SenseiDavaleba1
{
    internal class SenseiDavaleba1
    {
        static void Main(string[] args)
        {

            List<Person> Persons = new List<Person>();

            Persons.Add(new Person() { Name = "Dejan", Surname = "Stankovic", Age = 44, Sex = "Male" });
            Persons.Add(new Person() { Name = "Ala", Surname = "Pugachova", Age = 90, Sex = "Female" });
            Persons.Add(new Person() { Name = "Vaja", Surname = "Wiklauri", Age = 40000000, Sex = "Male" });

            FileManager manager = new FileManager(@"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Males\Names.txt");
            manager.Write(Persons);

            List<Person> Recovered = manager.Read();


            foreach (Person p in Recovered)
            {

                Console.WriteLine(p);
            }

        }
    }
}
