using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Persona;
namespace File;

public class FileManager
{

    public string Path { get; set; }
    public void Write(Person obj)
    {

        StreamWriter sw = new StreamWriter(Path, true);
        sw.WriteLine($"{obj.Name},{obj.Surname},{obj.Age},{obj.Sex}");

        sw.Close();



    }

    public Person Read()
    {
        StreamReader sr = new StreamReader(Path);
        string readInfo = sr.ReadLine();
        string[] array = readInfo.Split(',');

        Person Recovered = new Person();
        Recovered.Name = array[0];
        Recovered.Surname = array[1];
        Recovered.Age = int.Parse(array[2]);
        Recovered.Sex = array[3];

        // Console.WriteLine(sr.ReadToEnd());
        sr.Close();
        return Recovered;
    }

    public FileManager(string path)
    {
        Path = path;
    }
}
