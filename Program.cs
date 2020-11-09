using HashTable;
using System;

namespace HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            //hash takes int and string as parameters of size 6
            MyMapNode<int,string> hash = new MyMapNode<int, string>(6);
            //Adds details to hash
            hash.Add(0, "To");
            hash.Add(1, "be");
            hash.Add(2, "or");
            hash.Add(3, "not");
            hash.Add(4, "to");
            hash.Add(5, "be");
            Function function = new Function();
            //Calls frequencyOfWord method 
            function.FrequencyOfWord(hash);
        }
    }
}
