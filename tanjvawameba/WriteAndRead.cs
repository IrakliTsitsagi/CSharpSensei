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
                sw.Write(encryptedText);
            }
        }

        public static string Read(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }

            return "";
        }

        public WriteAndRead(string path)
        {
            Path = path;
        }

        public static string LoadCodeFromFile()
        {
            string codeFilePath = @"C:\Users\Irakli\OneDrive\Desktop\C#\test\code.txt";

            if (File.Exists(codeFilePath))
            {
                return File.ReadAllText(codeFilePath);
            }

            return "";
        }

        public static void SaveCodeToFile(string code)
        {
            string codeFilePath = @"C:\Users\Irakli\OneDrive\Desktop\C#\test\code.txt";
            File.WriteAllText(codeFilePath, code);
        }
    }
}


