using Persona;
using System.Diagnostics.Metrics;
using System.Text;

namespace File;

public class FileManager
{

    public string Path { get; set; }

    public void Write(List<Person> persons)
    {
        StreamWriter sw = new StreamWriter(Path, true);

        foreach (Person person in persons)
        {
            sw.WriteLine(person.ToString());
        }

        sw.Close();

    }

    public List<Person> Read()
    {
        List<Person> recovered = new List<Person>();

        StreamReader sr = new StreamReader(Path);
        string line;

        while ((line = sr.ReadLine()) != null)// axla gavigot ra problemaa
        {
            string[] splitPersonProperties = line.Split(',');

            /*recovered = CreatePersonFromList(splitPersonProperties);*/// xedaav? arsebuls tavze gadaawera axali listi romelshic 1 tipi iyo marto dainaxe? ki mand viyavi gachedili
            
            CreatePersonFromList(splitPersonProperties, recovered);
        }
        sr.Close();

        return recovered;
    }

    public FileManager(string path)
    {
        Path = path;
    }

    private void CreatePersonFromList(string[] split, List<Person> people)
    {
        /*List<Person> person = new List<Person>();*/// eg kide imis bralia rom am funqciashi yovel axal xazze persons ki ar aqmni da arsebul listshi ki ar amateb
        //personsac qmni da axal listsac da axal listshi amateb da mere dzvel lists awer axals. da shedegad sul ise gamodis rom 1 tipi gyavs listshi bolo romelic iqneba is
        //ho magas mivxvdi da mere davitam rogorc gamaketebina waigo mara erori darcha mainc anu :D erori ar darcha ubralod ar momewona eg gza
        // axla ori variantia gamosworebis. am funqciam an marto 1 personi unda daabrunos xolme romelsac mere recovered listshi chasvam
        //an kide ramenairad recovered lists unda miwvdes da axali listis gaketebis magivrad recoverebshi chaamatos axali personebi romeli gzit vqnat? miwvdes

        people.Add(new Person() { Name = split[0], Surname = split[1], Age = int.Parse(split[2]), Sex = split[3] });

        //return person;
    }
}


//githubze 
