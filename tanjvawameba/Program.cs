using System.Security.Cryptography;
using System.Text;

namespace CryptografiaWameba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Irakli\OneDrive\Desktop\C#\test\kriptoo.txt";
            string codeFilePath = @"C:\Users\Irakli\OneDrive\Desktop\C#\test\code.txt";

            WriteAndRead writeOrRead = new WriteAndRead(filePath, codeFilePath);

            int shift = 3;
            int choice = -1;
            string code = "";
            string message = "";

            while (choice != 0)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Read");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter code word: ");
                        code = Console.ReadLine();
                        Console.Write("Enter your message: ");
                        message = Console.ReadLine();

                        string encryptedText = CryptographyHelper.Encrypt(message, shift);


                        writeOrRead.Write(encryptedText);
                        Console.WriteLine("Message encrypted and written to the file.");
                        writeOrRead.SaveCodeToFile(code);
                        break;

                    case 2:
                        Console.WriteLine("Enter code word to read: ");
                        string codeAgain = Console.ReadLine();
                        code = writeOrRead.LoadCodeFromFile();

                        if (codeAgain == code)
                        {
                            string encryptedMessage = writeOrRead.Read();
                            string decryptedMessage = CryptographyHelper.Decrypt(encryptedMessage, shift);

                            Console.WriteLine("Decrypted message: " + decryptedMessage);
                        }
                        else
                        {
                            Console.WriteLine("Code was wrong, decryption failed.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Exiting the program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
