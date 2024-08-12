/*Task: Translate from English to Pig Latin

What will the application do?
1 Point: The application prompts the user for a word.
1 Point: The application translates the text to Pig Latin and displays it on the console.
1 Point: The application asks the user if he or she wants to translate another word.

Build Specifications:
1 Point: Convert each word to a lowercase before translating.
1 Point: If a word starts with a vowel, just add “way” onto the ending.
2 Point: if a word starts with a consonant, move all of the consonants that appear before the first vowel to the end of the word, then add “ay” to the end of the word. 

Additional Requirements:
1 Point: For answering Lab Summary when submitting to the LMS
-2 Points: if there are any syntax errors or if the program does not run (for example, in a Main method).

Extended Exercises (2 points maximum):
1 Point: Keep the case of the word, whether its uppercase (WORD), title case (Word), or lowercase (word).
1 Point: Allow punctuation in the input string.
1 Point: Translate words with contractions. Ex: can’t become an’tcay
1 Point: Don’t translate words that have numbers or symbols. Ex: 189 should be left as 189 and hello@grandcircus.co should be left as hello@grandcircus.co.
1 Point: Check that the user has actually entered text before translating.
1 Point: Make the application take a line instead of a single word, and then find the Pig Latin for each word in the line.

Hints:
Treat “y” as a consonant.
*/

using System.Net.NetworkInformation;
//Welcoming User
Console.WriteLine("Welcome to igPay Translator! Make your words chase their tail.");
Console.WriteLine("What is your name?");
string nameof = Console.ReadLine();
//Input for translation
Console.WriteLine($"Hi {nameof}! Please enter a word to translate.");
string pg = Console.ReadLine().ToLower();
//string input = Console.ReadLine();
string[] frac = pg.Split("");

//finds vowel in word and reshapes word accordingly

    for (int i = 0; i < pg.Length; i++)
    {
        char fl = pg[i];
        //char pp = pg.isPunctuation(fl);
        if (fl == 'a' || fl == 'e' || fl == 'i' || fl == 'o' || fl == 'u')
        {
            if (i == 0)
            {
                Console.WriteLine(pg + "way");
                //string combo = combineWords(input);
                break;
            }
            else
            {
                string fv = pg.Substring(i) + pg.Substring(0, i);
                Console.WriteLine(fv + "ay");
                break;
            }

        }
        //static char isPunctuation(char fl)
        //{
        //    if (fl == '')
        //    {

        //    }
        //}
    }

