using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordApp
{
    internal class DataHandler
    {
        string[] Words = new string[] {"kite", "byte", "halo" ,"random","wrong", "ball", "phone","jelly" };
        List<int> usedWords = new List<int>();
        int Checkindex = 0;
        public string getScrambledWord( string word) {
            char[] chars = new char[word.Length];
            Random rand = new Random(10000);

            int index = 0;

            while (word.Length > 0)
            {
                // Get a random number between 0 and the length of the word.
                int next = rand.Next(0, word.Length - 1);

                // Take the character from the random position and add to our char array.
                chars[index] = word[next];

                // Remove the character from the word.
                word = word.Substring(0, next) + word.Substring(next + 1);

                ++index;
            }

            return new String(chars);
        }

        public string selectRandomWord() {
            Random rand = new Random();
            if (usedWords.Count==8)
            {
                return "words are finished! Well Done!";

            }

            int index = 0;
            do {
                index = rand.Next(0, 8);
            }
            while (usedWords.Contains(index));

            string scrambled = getScrambledWord(Words[index]);

            Checkindex = index;
            usedWords.Add(index);

            return scrambled;




        }

        public string clearList() {
        usedWords.Clear();
            return "Play again";
        }


        

        public bool compareWords(string UserWord) {
            
          return UserWord.ToLower().Equals(Words[Checkindex].ToLower());

        }
    }
}
