using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What's the word?");
        string word = Console.ReadLine();
        Console.WriteLine(TranslateWord(word));
        Console.ReadLine();
    }
    
    public static string TranslateWord(string word)
    {
        //1 - Translate simple word
        //string firstLetter = word.Substring(0, 1);
        //string restOfWord = word.Substring(1);
        //return restOfWord + firstLetter + "ay";

        // 2 - Translate a more complex word

        int indexOfFirstVowel = -1;

        if ((word.IndexOf('a') > -1 && word.IndexOf('a') < indexOfFirstVowel) 
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('a');
        }

        if ((word.IndexOf('e') > -1 && word.IndexOf('e') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('e');
        }

        if ((word.IndexOf('i') > -1 && word.IndexOf('i') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('i');
        }

        if ((word.IndexOf('o') > -1 && word.IndexOf('o') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('o');
        }

        if ((word.IndexOf('u') > -1 && word.IndexOf('u') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('u');
        }

        if ((word.IndexOf('y') > -1 && word.IndexOf('y') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('y');
        }

        string restOfWord = word.Substring(indexOfFirstVowel);
        string firstPart = word.Substring(0, indexOfFirstVowel);


        // 3 - Words that begin with a vowel 
        //should just add on yay to the end

        if (indexOfFirstVowel == 0)
            return word + "yay";

        //4 - Must be lowercase

        return restOfWord + firstPart + "ay";
    }
}
