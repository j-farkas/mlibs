using System;
using System.Collections;
using System.Collections.Generic;

namespace FriendLetter.Models
{
    public class LetterVariable
    {
        private string[] _words;
        private static int _countSet = 0;
        private static int _countGet = 0;
        private static Random rnd = new Random();

        public LetterVariable(int length)
        {
          _words = new string[length];
        }

        public void SetWord(string newWord)
        {
          _words[_countSet] = newWord;
          _countSet++;
        }

        public string GetWord()
        {
          _countGet++;
          return _words[_countGet-1];
        }

        public int GetNext()
        {
          _countSet = 0;
          _countGet = 0;
          return rnd.Next(0,5);
        }
    }
}
