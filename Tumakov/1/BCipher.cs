using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov._1
{
    internal class BCipher : ICipher
    {
        public string encode(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder encoded = new StringBuilder();

            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    char encodedChar;

                    int baseCharCode = (char.IsLower(character)) ? 'a' : 'A';
                    encodedChar = (char)(baseCharCode + 25 - (character - baseCharCode));

                    encoded.Append(encodedChar);
                }
                else
                {
                    encoded.Append(character);
                }
            }
            return encoded.ToString();
            //юникод фу
        }
        public string decode(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder decoded = new StringBuilder();

            foreach (char character in input)
            {
                char decodedChar;
                if (char.IsLetter(character))
                {
                    int baseCharCode = (char.IsLower(character)) ? 'a' : 'A';
                    decodedChar = (char)(baseCharCode + 25 - (character - baseCharCode));
                }
                else
                {
                    decodedChar = character;
                }
                decoded.Append(decodedChar);
            }
            return decoded.ToString();

        }
    }
}
