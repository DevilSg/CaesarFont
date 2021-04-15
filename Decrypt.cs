using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarFont
{
    class Decrypt : Encrypt
    {
        public Decrypt(string message, string keyWord, int key)
        {
            this._message = "";
            this._encryptedMessage = message.ToLower();
            this._keyWord = keyWord;
            this._key = key;

            this.alphabets = new Alphabets(_keyWord, _key);

            if (Array.Exists(this.alphabets.alphabetRus, element => element == _keyWord[0]) == true)
            {
                DecryptMessageRus();
            }
            else
            {
                DecryptMessageEng();
            }
        }

        private void DecryptMessageRus()
        {
            for (int i = 0; i < _encryptedMessage.Length; i++)
            {
                if (_encryptedMessage[i] == ' ')
                {
                    _message += " ";
                }
                else if (_encryptedMessage[i] == ':')
                {
                    _message += ":";
                }
                else if (_encryptedMessage[i] == '.')
                {
                    _message += ".";
                }
                else if (_encryptedMessage[i] == ',')
                {
                    _message += ",";
                }
                else if (_encryptedMessage[i] == '!')
                {
                    _message += "!";
                }
                else if (_encryptedMessage[i] == '?')
                {
                    _message += "?";
                }
                else if (Array.Exists(alphabets.encryptedAlphabetRus, element => element == _encryptedMessage[i]) == true)
                {
                    _message += alphabets.alphabetRus[Array.FindIndex(alphabets.encryptedAlphabetRus, element => element == _encryptedMessage[i])];
                }
                else
                {
                    _message += _encryptedMessage[i];
                }
            }
            Console.WriteLine(_message);
        }

        private void DecryptMessageEng()
        {
            for (int i = 0; i < _encryptedMessage.Length; i++)
            {
                if (_encryptedMessage[i] == ' ')
                {
                    _message += " ";
                }
                else if (_encryptedMessage[i] == ':')
                {
                    _message += ":";
                }
                else if (_encryptedMessage[i] == '.')
                {
                    _message += ".";
                }
                else if (_encryptedMessage[i] == ',')
                {
                    _message += ",";
                }
                else if (_encryptedMessage[i] == '!')
                {
                    _message += "!";
                }
                else if (_encryptedMessage[i] == '?')
                {
                    _message += "?";
                }
                else if (Array.Exists(alphabets.encryptedAlphabetEng, element => element == _encryptedMessage[i]) == true)
                {
                    _message += alphabets.alphabetEng[Array.FindIndex(alphabets.encryptedAlphabetEng, element => element == _encryptedMessage[i])];
                }
                else
                {
                    _message += _encryptedMessage[i];
                }
            }
            Console.WriteLine(_message);
        }
    }
}
