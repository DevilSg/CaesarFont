using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarFont
{
    public class Alphabets
    {
        private char[] _alphabetRus;
        private char[] _alphabetEng;
        private char[] _encryptedAlphabetRus;
        private char[] _encryptedAlphabetEng;
        private string _keyWord;
        private int _k;

        public char[] alphabetRus { get { return _alphabetRus; } }
        public char[] alphabetEng { get { return _alphabetEng; } }
        public char[] encryptedAlphabetRus { get { return _encryptedAlphabetRus; } }
        public char[] encryptedAlphabetEng { get { return _encryptedAlphabetEng; } }

        public Alphabets(string keyWord, int k)
        {
            this._alphabetRus = new char[32];
            this._alphabetEng = new char[26];
            this._encryptedAlphabetRus = new char[32];
            this._encryptedAlphabetEng = new char[26];
            this._keyWord = keyWord;
            this._k = k;

            FillAlphabetRus();
            FillAlphabetEng();
            if (Array.Exists(_alphabetRus, element => element == _keyWord[0]) == true)
            {
                CheckKRus();
                FillEncryptedAlphabetRus();
            }
            else
            {
                CheckKEng();
                FillEncryptedAlphabetEng();
            }
        }

        Alphabets()
        {
            this._alphabetRus = new char[0];
            this._alphabetEng = new char[0];
            this._encryptedAlphabetRus = new char[0];
            this._encryptedAlphabetEng = new char[0];
            this._keyWord = default;
            this._k = default;
        }

        private void FillAlphabetRus()
        {
            for (int i = 0; i < _alphabetRus.Length; i++)
            {
                _alphabetRus[i] = (char)('а' + i);
            }
        }

        private void FillAlphabetEng()
        {
            for (int i = 0; i < _alphabetEng.Length; i++)
            {
                _alphabetEng[i] = (char)('a' + i);
            }
        }

        private void CheckKRus()
        {
            if (_k > _alphabetRus.Length)
            {
                _k = _k % _alphabetRus.Length;
            }
            else if (_k < 0 && Math.Abs(_k) > _alphabetRus.Length)
            {
                _k = _alphabetRus.Length - (Math.Abs(_k) % _alphabetRus.Length);
            }
            else if (_k < 0)
            {
                _k = _alphabetRus.Length - Math.Abs(_k);
            }
        }

        private void CheckKEng()
        {
            if (_k > _alphabetEng.Length)
            {
                _k = _k % _alphabetEng.Length;
            }
            else if (_k < 0 && Math.Abs(_k) > _alphabetEng.Length)
            {
                _k = _alphabetEng.Length - (Math.Abs(_k) % _alphabetEng.Length);
            }
            else if (_k < 0)
            {
                _k = _alphabetEng.Length - Math.Abs(_k);
            }
        }

        private void FillEncryptedAlphabetRus()
        {
            int index = 0;  //key's index

            for (int i = _k; i < _encryptedAlphabetRus.Length; i++)
            {
                if (index != _keyWord.Length)
                {
                    if (Array.Exists(_encryptedAlphabetRus, element => element == _keyWord[index]) == false)
                    {
                        _encryptedAlphabetRus[i] = _keyWord[index];
                    }
                    index++;
                }
                else
                {
                    for (int j = 0; j < _alphabetRus.Length; j++)
                    {
                        if (Array.Exists(_encryptedAlphabetRus, element => element == _alphabetRus[j]) == false)
                        {
                            _encryptedAlphabetRus[i] = _alphabetRus[j];
                            break;
                        }
                    }
                }
                if (i + 1 == _encryptedAlphabetRus.Length)
                {
                    i = -1;
                }
                if (_encryptedAlphabetRus[i + 1] == _keyWord[0])
                {
                    break;
                }
            }
            Console.WriteLine(_encryptedAlphabetRus);
        }

        private void FillEncryptedAlphabetEng()
        {
            int index = 0;  //key's index

            for (int i = _k; i < _encryptedAlphabetEng.Length; i++)
            {
                if (index != _keyWord.Length)
                {
                    if (Array.Exists(_encryptedAlphabetEng, element => element == _keyWord[index]) == false)
                    {
                        _encryptedAlphabetEng[i] = _keyWord[index];
                    }
                    index++;
                }
                else
                {
                    for (int j = 0; j < _alphabetEng.Length; j++)
                    {
                        if (Array.Exists(_encryptedAlphabetEng, element => element == _alphabetEng[j]) == false)
                        {
                            _encryptedAlphabetEng[i] = _alphabetEng[j];
                            break;
                        }
                    }
                }
                if (i + 1 == _encryptedAlphabetEng.Length)
                {
                    i = -1;
                }
                if (_encryptedAlphabetEng[i + 1] == _keyWord[0])
                {
                    break;
                }
            }
            Console.WriteLine(_encryptedAlphabetEng);
        }
    }
}
