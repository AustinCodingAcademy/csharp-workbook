using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here

            // leave this command at the end so your program does not close automatically
            Console.WriteLine("enter a sentence");
            string input = Console.ReadLine();
            Console.WriteLine(TranslateSentence(input));

            

            // string translatedWord = TranslateWord(input);
            // Console.WriteLine(translatedWord);
        }

        public static string TranslateWord(string word)
        {
            word = word.ToLower();
            int firstVowelIndex = word.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u', 'y' });

            // Console.WriteLine(firstVowelIndex.ToString());

            if (firstVowelIndex <= 0) 
            {
                return word + "yay";
            }
            else
            {
                string firstPart = word.Substring(0, firstVowelIndex);
                string secondPart = word.Substring(firstVowelIndex);

                return secondPart + firstPart + "ay";
            }
        }

        public static string TranslateSentence(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = TranslateWord(words[i]);
            }

            return String.Join(' ', words);
        }
    }
}
