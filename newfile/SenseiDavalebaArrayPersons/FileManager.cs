using Persona;
using System.Diagnostics.Metrics;
using System.Text;

namespace File;

public class FileManager
{

    public string Path { get; set; }

    public void Write(Person[] persons)
    {
        StreamWriter sw = new StreamWriter(Path, true);

        foreach (Person person in persons)
        {
            sw.WriteLine(person.ToString());
        }

        sw.Close();

    }

    public Person[] Read()
    {
        Person[] recovered = new Person[3];

        StreamReader sr = new StreamReader(Path);

        string line;
        int counter = 0;
        while ((line = sr.ReadLine()) != null)
        {
            string[] splitPersonProperties = line.Split(',');

            //recovered[counter] = new Person();

            //recovered[counter].Name = splitPersonProperties[0].Trim();
            //recovered[counter].Surname = splitPersonProperties[1].Trim();
            //recovered[counter].Age = int.Parse(splitPersonProperties[2].Trim());
            //recovered[counter].Sex = splitPersonProperties[3].Trim();

            //uketesi gza
            recovered[counter] = CreatePersonFromStringArray(splitPersonProperties);

            counter++;
            Array.Resize(ref recovered, recovered.Length+1);
        }
        
        sr.Close();

        return recovered;
    }

    private Person CreatePersonFromStringArray(string[] properties)
    {
        Person person = new Person();

        person.Name = properties[0].Trim();
        person.Surname = properties[1].Trim();
        person.Age = int.Parse(properties[2].Trim());
        person.Sex = properties[3].Trim();

        return person;
    }

    public FileManager(string path)
    {
        Path = path;
    }
}


