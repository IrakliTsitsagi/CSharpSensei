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
        public string PathForCode { get; private set; }

        public WriteAndRead(string path, string pathForCode)
        {
            Path = path;
            PathForCode = pathForCode;
        }

        public void Write(string encryptedText)
        {
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.Write(encryptedText);
            }
        }

        public string Read()
        {
            if (File.Exists(Path))
            {
                return File.ReadAllText(Path);
            }

            return "";
        }

        public string LoadCodeFromFile()
        {
            if (File.Exists(PathForCode))
            {
                return File.ReadAllText(PathForCode);
            }

            return "";
        }

        public void SaveCodeToFile(string code)
        {
            File.WriteAllText(PathForCode, code);
        }
    }
}


