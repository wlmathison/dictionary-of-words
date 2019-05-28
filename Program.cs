using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("void", "specifies that the method doesn't return a value.");
            wordsAndDefinitions.Add("namespace", "used to declare a scope that contains a set of related objects");
            wordsAndDefinitions.Add("throw", "signals the occurrence of an exception during program execution.");

            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */

            Console.WriteLine(wordsAndDefinitions["void"]);
            Console.WriteLine(wordsAndDefinitions["namespace"]);

            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }
    }
}
