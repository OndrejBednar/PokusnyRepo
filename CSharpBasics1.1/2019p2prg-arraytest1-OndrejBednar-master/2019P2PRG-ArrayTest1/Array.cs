using System;
using System.Collections;

namespace ArrayTest1
{
    class Array: IArray, IEnumerable
    {
        private object[] _array;
        private const int GROW = 5;

        public Array()
        {
            _array = new object[GROW];
        }

        /// <summary>
        ///   Posune prvky od zadané pozice v poli dále. 
        ///   Na konci operace bude Get(indexFrom)==null
        ///   V případě potřeby dojde k zvětšení pole o GROW
        /// </summary>
        /// <param name="indexFrom">index na kterém potřebujeme null</param>
        public void ShiftItems(int indexFrom)
        {
            //bylo by vodné posouvat jen nejnutnější počet prvků a vyhnout se posunu prvků, kde to není nutné...
            //viz index 5 a 15 v ukázce

            throw new NotImplementedException();
        }

        /// <summary>
        ///   Vloží prvek do pole na zadanou pozici (index)
        /// </summary>
        /// <param name="value">vkládaná hodnota (reference)</param>
        /// <param name="position">index/pozice</param>
        public void Insert(object value, int position)
        {
            //pole je "nekonečné", ale nemá záporné indexy
            if (position < 0) throw new ArgumentOutOfRangeException("position", "Parametr musí být kladné číslo.");

            //hodnotu můžeme vložit na libovolnou pozici; malé pole přdtím zvětšíme
            if (position >= Length) ResizeArray(ref _array, position + GROW);

            //když není na dané pozici místo, musíme jej udělat (existujicí data nepřemažeme!)
            if (Get(position) != null) ShiftItems(position);

            //teď už můžeme klidne vložit novou hodnotu na zadanou pozici
            _array[position] = value;
        }

        /// <summary>
        ///   Zvětší nebo zmenší pole prvků
        /// </summary>
        /// <param name="oldArray">pole, které bude zvětšeno nebo zmenšeno</param>
        /// <param name="newSize">velikost pole po zvětšení / zmenšení</param>
        private static void ResizeArray(ref object[] oldArray, int newSize)
        {
            if (newSize <= 0) throw new ArgumentOutOfRangeException("newSize", "Parametr musí být kladné číslo.");

            object[] newArr = new object[newSize];
            for (int i = 0; i < Math.Min(oldArray.Length, newArr.Length); i++)
            {
                newArr[i] = oldArray[i];
            }
            oldArray = newArr;
        }

        public int Count
        {
            get
            {
                int count = 0;
                foreach (var item in _array)
                {
                    if (!(item is null)) count++;
                }
                return count;
            }
        }

        public int Length => _array.Length;

        private static int GetFirstIndexOfNull(object[] array, int fromIndex = 0)
        {
            for (int i = fromIndex; i < array.Length; i++)
            {
                if (array[i] is null) return i;
            }
            return -1;
        }

        public object Get(int position)
        {
            //if (position < 0 || position >= Length) return null; efficiency issue
            return _array[position];
        }

        public object[] GetAll()
        {
            object[] result = new object[Count];
            int i = 0;
            foreach (var item in this)
            {
                result[i++] = item;
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _array)
            {
                //if (!(item is null)) yield return item;
                yield return item;
            }
        }

        public void Add(object value)
        {
            int insertPosition = GetFirstIndexOfNull(_array);
            if (insertPosition == -1) insertPosition = Length;
            Insert(value, insertPosition);
        }

        public bool Delete(object value)
        {
            bool result = false;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(value))
                {
                    result = true;
                    _array[i] = null;
                }
            }

            return result;
        }

        public void Delete(int position)
        {
            if (position < 0 || position >= Length) return;

            _array[position] = null;
        }
    }
}
