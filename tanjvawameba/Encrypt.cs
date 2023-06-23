using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptografiaWameba
{
    class Encryption
    {
        public static string Encrypt(string message, int shift)
        {
            char[] plainArray = message.ToLower().ToCharArray();

            for (int i = 0; i < plainArray.Length; i++)
            {
                char letter = plainArray[i];

                if (letter != ' ')
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    plainArray[i] = letter;
                }
            }
            return new string(plainArray);
        }
    }
}
