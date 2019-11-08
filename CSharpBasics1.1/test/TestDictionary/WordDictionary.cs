using System;
using System.Collections.Generic;
using System.Text;

namespace TestDictionary
{
    class WordDictionary
    {
        protected DictionaryItem[] _data;

        public WordDictionary()
        {
            _data = new DictionaryItem[0];
        }

        public int GetLength()
        {
            return _data.Length;
        }

        public override string ToString()
        {
            string result = "";
            foreach (DictionaryItem item in _data)
            {
                result += item + "\n";
            }
            result += "(" + GetLength() + ")\n";
            return result;
        }

        public int FindCzech(string word)
        {
            for (int i = 0; i < GetLength(); i++)
            {
                if (_data[i].GetCzech() == word)
                {
                    _data[i].IncreaseWanted();
                    return i;
                }
            }
            return -1;
        }

        public int FindEnglish(string word)
        {
            for (int i = 0; i < GetLength(); i++)
            {
                if (_data[i].GetEnglish() == word)
                {
                    _data[i].IncreaseWanted();
                    return i;
                }
            }
            return -1;
        }

        public void Add(DictionaryItem item)
        {
            DictionaryItem[] newData = new DictionaryItem[GetLength() + 1];
            for (int i = 0; i < GetLength(); i++) { newData[i] = _data[i]; };
            newData[GetLength()] = item;
            _data = newData;
        }

        public void RemoveAt(int index)
        {
            if (index < GetLength())
            {
                DictionaryItem[] newData = new DictionaryItem[GetLength()-1];
                for (int i = 0; i < index; i++) { newData[i] = _data[i]; }
                for (int i = index; i < GetLength() - 1; i++) { newData[i] = _data[i+1]; }
                _data = newData;
            }
        }

        public bool RemoveEnglish(string word)
        {
            int location = FindEnglish(word);
            if (location != -1) 
            {
                RemoveAt(location);
                return true;
            }
            return false;
        }

        public int FindInsertCzechPosition(string word)
        {
            return 0;
        }

        public void Insert(DictionaryItem item)
        {
            
        }
        public static int GetCount(DictionaryItem[] array)
        {
            int count = 0;
            /*for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    return count;
                }
                count += 1;
            }*/
            foreach (var item in array)
            {
                if (item == null)
                {
                    return count;
                }
                count += 1;
            }

            return count;
        }
        public static int FindInsertPosition(DictionaryItem[] array, string word)
        {
            //v compare Result < 0 -- word je nad array
            //v compare Result = 0 -- word je rovno array
            //v compare Result > 0 -- word je pod array
            for (int i = 0; i < GetCount(array); i++)
            {
                if (string.Compare(word, array[0].GetCzech()) >= 0) return i;
            }
            return GetCount(array);
        }

    }
}
