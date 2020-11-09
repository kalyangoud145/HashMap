using HashTable;
using System;

namespace HashMap
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Function function = new Function();
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            //Split converts paragraph  into array of sub strings
            string[] para = paragraph.Split(" ");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(para.Length);
            int key = 0;
            //Loop iterates on paragraph and adds key and value of each substing
            //To hash
            foreach (string word in para)
            {
                hash.Add(key, word);
                key++;
            }
            //Calls Frequency of word method to print word count
            function.FrequencyOfWord(hash);
        }
    }
}
