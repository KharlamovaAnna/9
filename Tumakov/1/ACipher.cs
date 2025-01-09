using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov._1
{
    internal class ACipher : ICipher
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
                    char encodedChar = character;
                    if ((character >= 'А' && character <= 'я') || character == 'ё' || character == 'Ё')
                    {   //для кириллицы
                        if (character == 'ё' || character == 'Ё')
                        {
                            encodedChar = (character == 'ё') ? 'ж' : 'Ж';
                        }
                        else if (character == 'е' || character == 'Е')
                        {
                            encodedChar = (character == 'е') ? 'ё' : 'Ё';
                        }
                        else
                        {
                            int baseCharCode = (char.IsLower(character)) ? 'а' : 'А';
                            encodedChar = (char)((character - baseCharCode + 1) % 32 + baseCharCode);
                        }
                    }
                    else //для латиницы 
                    {
                        char baseChar = char.IsLower(character) ? 'a' : 'A';
                        encodedChar = (char)((character - baseChar + 1) % 26 + baseChar);
                    }
                    encoded.Append(encodedChar);
                }
                else
                {
                    encoded.Append(character);
                }
            }
            return encoded.ToString();
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
                    if ((character >= 'А' && character <= 'я') || character == 'ё' || character == 'Ё')
                    {
                        if (character == 'ё' || character == 'Ё')
                        {
                            decodedChar = (character == 'ё') ? 'е' : 'Е';
                        }
                        if (character == 'ж' || character == 'Ж')
                        {
                            decodedChar = (character == 'ж') ? 'ё' : 'Ё';
                        }
                        else
                        {
                            int baseCharCode = char.IsLower(character) ? 'а' : 'А';
                            decodedChar = (char)((character - baseCharCode - 1 + 32) % 32 + baseCharCode);
                        }
                    }
                    else
                    {
                        char baseChar = char.IsLower(character) ? 'a' : 'A';
                        decodedChar = (char)((character - baseChar - 1 + 26) % 26 + baseChar);
                    }
                    decoded.Append(decodedChar);
                }
                else
                {
                    decoded.Append(character);
                }
            }
            return decoded.ToString();
        }
    }
}
