using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CryptografiaWameba
{
    public class WriteAndRead
    {

       
        public string Path { get; set; }

        public static void Write(string path, string encryptedText)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(encryptedText);
            }
        }

        public static void Read(string path, string encryptedtext)
        {
            StreamReader sr = new StreamReader(path);

            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }

        public WriteAndRead(string path)
        {
            Path = path;
        }
    }
}

