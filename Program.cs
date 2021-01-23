using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Ahmet");
            myDictionary.Add("Engin");
            myDictionary.Add("Seçkin");
            Console.WriteLine(myDictionary);
        }
    }
}
