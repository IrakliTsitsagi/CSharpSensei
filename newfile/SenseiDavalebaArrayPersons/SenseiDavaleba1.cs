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

            Person[] Persons = new Person[3];

            //new Person{ Name = "Dejan", Surname = "Stankovic", Age = 25, Sex = "Male"},
            // new Person { Name = "Bob", Surname = "Big", Age = 30 , Sex= "Male"},
            // new Person { Name = "Vaja", Surname = "Wiklauri", Age = 40000, Sex = "Male" }
            Persons[0] = new Person();
            Persons[0].Name = "Dejan";
            Persons[0].Surname = "Stankovic";
            Persons[0].Age = 44;
            Persons[0].Sex = "Male";

            
            Persons[1] = new Person();
            Persons[1].Name = "Ala";
            Persons[1].Surname = "Pugachova";
            Persons[1].Age = 90;
            Persons[1].Sex = "Female";

            Persons[2] = new Person();
            Persons[2].Name = "Vaja";
            Persons[2].Surname = "Wiklauri";
            Persons[2].Age = 40000000;
            Persons[2].Sex = "Male";


            FileManager manager = new FileManager(@"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Males\Names.txt");
                manager.Write(Persons);

            Person[] Recovered = manager.Read();
            for (int i = 0; i < Recovered.Length; i++)
            {
                Console.WriteLine(Recovered[i]);

            }


            // Person recovered = manager.Read();
            //Console.WriteLine($"{recovered.Name} {recovered.Surname} {recovered.Age} {recovered.Sex}");

            //Directory.CreateDirectory(@"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Males");
            //Directory.CreateDirectory(@"C:\Users\\Irakli\OneDrive\Desktop\C#\Sensei\Females");

            //sw.WriteLine($"person name is {Dejan.name}, surname is {Dejan.surname}, age  {Dejan.age}, sex {Dejan.sex}");
            //sw.Close();


        }
    }
}