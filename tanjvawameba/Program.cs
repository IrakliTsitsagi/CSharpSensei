using System.Security.Cryptography;
using System.Text;

namespace CryptografiaWameba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encryption encrypt = new Encryption();
            Decryption decrypt = new Decryption();
            string fileDirectory = @"C:\Users\Irakli\OneDrive\Desktop\C#\test\kriptoo.txt";
            WriteAndRead write = new WriteAndRead(fileDirectory);
          
            Console.WriteLine("Enter code word:");
            string code = Console.ReadLine();
            Console.WriteLine("enter your message");
            string message = Console.ReadLine();

            int shift = 3; 
            string encryptedText = Encryption.Encrypt(message, shift);
            string decryptedText = Decryption.Decrypt(encryptedText, shift);

            string filePath = @"C:\Users\Irakli\OneDrive\Desktop\C#\test\kriptoo.txt"; 

            WriteAndRead.Write(filePath, encryptedText);

            Console.WriteLine("Enter code word to read");
            string codeAgain = Console.ReadLine();

            if (codeAgain == code)
            {
                WriteAndRead.Read(filePath, decryptedText);
                Console.WriteLine("decrypted text is " + decryptedText);
            }
            else 
            {
                WriteAndRead.Read(filePath, encryptedText);
                Console.WriteLine("code was wrong, decryption failed, so here is the text " + encryptedText);
            }


        }
    }
}