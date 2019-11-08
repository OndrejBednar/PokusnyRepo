using System;

namespace TestDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            WordDictionary slovnik = new WordDictionary();
            slovnik.Add(new DictionaryItem("kočka", "cat"));
            slovnik.Add(new DictionaryItem("krysa", "rat"));
            slovnik.Add(new DictionaryItem("medvěd", "bear"));
            slovnik.Add(new DictionaryItem("myš", "mouse"));
            slovnik.Add(new DictionaryItem("pes","dog"));
            Console.WriteLine("Pozice slova rat:" + slovnik.FindEnglish("rat"));
            Console.WriteLine("Pozice slova myš:" + slovnik.FindCzech("myš"));
            Console.WriteLine(slovnik.FindInsertCzechPosition("zebra"));
            slovnik.Insert(new DictionaryItem("kočka", "cat"));
            slovnik.Insert(new DictionaryItem("kočka", "kitty"));
            slovnik.Insert(new DictionaryItem("kočička", "kitty"));
            slovnik.Insert(new DictionaryItem("slon", "elephant"));
            slovnik.Insert(new DictionaryItem("zebra", "zebra"));
            slovnik.Insert(new DictionaryItem("antilopa", "antelope"));
            slovnik.Insert(new DictionaryItem("žirafa", "giraffe"));
            slovnik.Insert(new DictionaryItem("kráva", "cow"));
            slovnik.RemoveEnglish("rat");
            slovnik.RemoveEnglish("wasp");
            Console.WriteLine(slovnik);
        }
    }
}
