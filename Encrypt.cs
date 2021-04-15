using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarFont
{
    public class Encrypt
    {
        protected string _message;
        protected string _encryptedMessage;
        protected string _keyWord;
        protected int _key;
        protected Alphabets alphabets;

        public Encrypt(string message, string keyWord, int key)
        {
            this._message = message.ToLower();
            this._encryptedMessage = "";
            this._keyWord = keyWord;
            this._key = key;

            this.alphabets = new Alphabets(_keyWord, _key);

            if (Array.Exists(this.alphabets.alphabetRus, element => element == _keyWord[0]) == true)
            {
                EncryptMessageRus();
            }
            else
            {
                EncryptMessageEng();
            }
        }

        protected Encrypt()
        {
            this._message = default;
            this._encryptedMessage = default;
            this._keyWord = default;
            this._key = default;
        }

        private void EncryptMessageRus()
        {
            for (int i = 0; i < _message.Length; i++)
            {
                if (_message[i] == ' ')
                {
                    _encryptedMessage += " ";
                }
                else if (_message[i] == ':')
                {
                    _encryptedMessage += ":";
                }
                else if (_message[i] == '.')
                {
                    _encryptedMessage += ".";
                }
                else if (_message[i] == ',')
                {
                    _encryptedMessage += ",";
                }
                else if (_message[i] == '!')
                {
                    _encryptedMessage += "!";
                }
                else if (_message[i] == '?')
                {
                    _encryptedMessage += "?";
                }
                else if (Array.Exists(alphabets.alphabetRus, element => element == _message[i]) == true)
                {
                    _encryptedMessage += alphabets.encryptedAlphabetRus[Array.FindIndex(alphabets.alphabetRus, element => element == _message[i])];
                }
                else
                {
                    _encryptedMessage += _message[i];
                }
            }
            Console.WriteLine(_encryptedMessage);
        }

        private void EncryptMessageEng()
        {
            for (int i = 0; i < _message.Length; i++)
            {
                if (_message[i] == ' ')
                {
                    _encryptedMessage += " ";
                }
                else if (_message[i] == ':')
                {
                    _encryptedMessage += ":";
                }
                else if (_message[i] == '.')
                {
                    _encryptedMessage += ".";
                }
                else if (_message[i] == ',')
                {
                    _encryptedMessage += ",";
                }
                else if (_message[i] == '!')
                {
                    _encryptedMessage += "!";
                }
                else if (_message[i] == '?')
                {
                    _encryptedMessage += "?";
                }
                else if (Array.Exists(alphabets.alphabetEng, element => element == _message[i]) == true)
                {
                    _encryptedMessage += alphabets.encryptedAlphabetEng[Array.FindIndex(alphabets.alphabetEng, element => element == _message[i])];
                }
                else
                {
                    _encryptedMessage += _message[i];
                }
            }
            Console.WriteLine(_encryptedMessage);
        }
    }
}
