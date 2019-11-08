using System;
using System.Collections.Generic;
using System.Text;

namespace random1
{
    class GradeAvgList : ICustomList
    {
        private GradeAvg[] _gt;
        private readonly int maxcnt;

        public GradeAvgList(int maxcnt)
        {
            _gt = new GradeAvg[maxcnt];
            this.maxcnt = maxcnt;
        }

        public int Count
        {
            get
            {
                for (int i = 0; i < _gt.Length; i++)
                {
                    if (_gt[i] is null) return i;
                }
                return _gt.Length;
            }
        }

        public int Length
        {
            get
            {
                return _gt.Length;
            }
        }

        /// <summary>
        ///   Metoda přidá novou známku do souhrnu známek
        /// </summary>
        /// <param name="g">známka</param>
        public void Add(Grade g)
        {
            // 1)  zjistíme, zda předmět je již v _gt (a získáme index)
            // 2)  pokud ne, vytvoříme nový pomocí Add(GradeAvg) (a získáme index)
            // 3)  přes Get() získáme referenci na souhrnnou známku a aktualizujeme ji pomocí "g"
            int index = IndexOf(g.Subject); 
            if (index == -1)
            {
                int a = Add(new GradeAvg(g.Subject));
                GradeAvg _gt = Get(a);
                _gt.AddGrade(g);
            }
            else
            {
                GradeAvg _gt = Get(index);
                _gt.AddGrade(g);
            }

        }

        /// <summary>
        ///   Vloží nové souhrnné hodnocení, nebo doplní (přepíše?) stávající
        /// </summary>
        /// <param name="g">souhrnná známka</param>
        /// <returns>index nově vložené známky</returns>
        private int Add(GradeAvg g)
        {
            if (_gt.Length == Count)
                ResizeArray(ref _gt, _gt.Length + maxcnt);
            _gt[Count] = g;
            return IndexOf(g.Subject);
        }

        public bool Delete(GradeAvg g)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int position)
        {
            throw new NotImplementedException();
        }

        public GradeAvg Get(int position)
        {
            return _gt[position];
        }

        public bool Insert(GradeAvg g, int position)
        {
            int a = new GradeAvg(g.Subject);
            for (int i = position; _gt.Lenght > i; i--)
            {
                if (_gt.Lenght == Count)
                {
                    ResizeArray(ref _gt, _gt.Length + maxcnt);
                }
                a = IndexOf(position);

            }
        }

        public GradeAvg[] GetAll()
        {
            var result = new GradeAvg[Count];
            for (int i = 0; i < Count; i++)
            {
                result[i] = _gt[i];
            }
            return result;
        }

        public int IndexOf(GradeAvg g)
        {
            return IndexOf(g.Subject);
        }

        public int IndexOf(string subject)
        {
            for (int i = 0; i < Count; i++)
            { 
                if (subject == _gt[i].Subject)
                {
                    return i;
                }
            }
            return -1;
        }
        private static void ResizeArray(ref GradeAvg[] oldArray, int growUp)
        {
            if (growUp < 0) throw new ArgumentOutOfRangeException("growUp", "Parametr musí být kladné číslo.");

            GradeAvg[] newGradeAvgs = new GradeAvg[oldArray.Length + growUp];
            for (int i = 0; i < oldArray.Length; i++)
            {
                newGradeAvgs[i] = oldArray[i];
            }
            oldArray = newGradeAvgs;
        }
    }
}