using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    interface IDynamicArray
    {
        object Get(int position);
        void Insert(object value, uint position);
        void ShiftItems(uint idexFrom);
        int Count { get; }
        int Length { get; }
    }
}