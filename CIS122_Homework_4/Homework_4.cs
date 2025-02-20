/*
    Hayden Hartmann
    2/16/2025
    Homework Assignment 4
*/


public class MyMain
{
    public static void Main(string[] args)
    {

        //Console.WriteLine(ReturnStringCount("hello my name is, jeff"));
        //Console.WriteLine(ReturnSwap("abC"));
        //Console.WriteLine(TestString("1234"));
        //Console.WriteLine(TestString("xyzz"));
        //Console.WriteLine(TestString("55234"));
        //Console.WriteLine(ReturnVowels("sharpening skills", 3));
        //Console.WriteLine(ReturnVowels("major league", 5));
        //Console.WriteLine(ReturnVowels("hostess", 5));
        Console.WriteLine(UpdateLetters("abc"));

        Console.ReadKey();
    }

    // 1.) takes a string and returns the word count
    public static int ReturnStringCount(string word)
    {
        int wordCount = 0;
        string[] words = word.Split(" ");
        foreach(string _word in words)
        {
            wordCount++;
        }
        return wordCount;
    }

    // 2.) Flips first and last charecters in a string unless length < 2 or first and last letter are ==
    public static string ReturnSwap(string word)
    {
        string newWord = "";
        char firstLetter = word[0];
        char lastLetter = word[word.Length - 1];

        // checks two params before looping
        if (word.Length < 2)
        {
            return "Incompatable";
        }
        else if (word[0] == word[word.Length - 1])
        {
            return "Two's a Pair";
        }
        
        // loops through word and swaps first and last letters inside of newWord
        for (int i = 0; i <= word.Length - 1; i++)
        {
            if (i == 0)
            {
                newWord += lastLetter;
            }
            else if (i == word.Length - 1)
            {
                newWord += firstLetter;
            }
            else
            {
                newWord += word[i];
            }
        }

        return newWord;
    }

    // 3.) tests if string is in acending format using ASCII charecter numbers
    public static bool TestString(string myString)
    {
        bool myBool = false;

        // loops through myString
        for (int i = 0; i <= myString.Length - 1; i++)
        {
            // makes sure that i != last index otherwise will get outOfBounds error with next condition check
            if (i != myString.Length - 1)
            {
                // checks if ASCII value is <= next ASCII value
                if (Convert.ToInt32(myString[i]) <= Convert.ToInt32(myString[i + 1]))
                {
                    myBool = true;
                }
                else
                {
                    return false;
                }
            }
        }

        return myBool;
    }

    // 4.) this method returns a  # of vowels from the given string
    public static string ReturnVowels(string myString, int num)
    {
        // declares variables
        string vowels = "aeiou";
        int vowelsInMyString = 0;
        string vowelsFound = "";

        // loops through both given string and known vowels to find vowels inside of given string
        for (int i = 0; i <= myString.Length - 1; i++)
        {
            for (int j = 0; j <= vowels.Length - 1; j++)
            {
                // if the char is a vowel then add it to variable and add 1 to count
                if (myString[i] == vowels[j])
                {
                    vowelsInMyString++;
                    vowelsFound += myString[i];
                }
            }
        }

        // if count < amount then return Invalid
        if (vowelsInMyString < num)
        {
            return "Invalid";
        }
        else
        {
            // declares new string and assignes it to a modified version of vowelsFound to give # of vowels back that was asked for
            string newString = "";
            for (int i = 0; i <= vowelsFound.Length - 1; i++)
            {
                if (i < num)
                {
                    newString += vowelsFound[i];
                }
            }
            return newString;
        }
    }

    // this method returns the given string but ACII values +1 for each char in the string
    public static string UpdateLetters(string myString)
    {
        string updatedLetters = "";

        // loops through myString
        for (int i = 0; i <= myString.Length - 1; i++)
        {
            // finds char at position i in string, then finds the ASCII value of the char with Convert,
            // then adds 1, then converts the number back to a Char with another Convert
            updatedLetters += Convert.ToChar((Convert.ToInt32(myString[i]) + 1));
        }

        return updatedLetters;
    }
}






