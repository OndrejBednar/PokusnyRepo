using System;
using System.Collections.Generic;
using System.Text;

namespace TestDictionary
{
    class DictionaryItem
    {
        /* třída spravuje položky česko-anglického slovníku
         obsahuje:
         * _english = anglické slovo, je možné získat jeho hodnotu mimo třídu
         * _czech = české slovo, je možné získat jeho hodnotu mimo třídu
         * _wanted = počet, kolikrát bylo slovo vyhledáno, mimo třídu je možné získat jeho hodnotu, nastavit ji a zvýšit ji o jedna
         
         * parametrický konstruktor, který nastavuje "_wanted" na 0
         * třídu je možné vypsat přes Console.Writeline
         * je také možné získat rozdíl délek mezi českým a anglickým výrazem (ve výpisu se pak objevuje "cs", "_en" nebo "=" podle toho, co je kratší)
        */
        public string _en;
        public string _cz;
        public int _wanted;

        public DictionaryItem(string _cz, string _en, int _wanted = 0)
        {
            this._cz = _cz;
            this._en = _en;
            this._wanted = _wanted;
        }

        public string GetCzech()
        {
            return _cz;
        }
        public string GetEnglish()
        {
            return _en;
        }
        public int IncreaseWanted()
        {
            _wanted += 1;
            return _wanted;
        }

        private string GetShorter()
        {
            int a = _en.Length;
            int b = _cz.Length;
            if (a > b)
            {
                return "_cz";
            }
            if (b > a)
            {
                return "_en";
            }
                return "=";
        }

        public override string ToString()
        {
            return _cz + " = " + _en + " (" + _wanted + "×, " + GetShorter() + ")";
        }
    }
}
