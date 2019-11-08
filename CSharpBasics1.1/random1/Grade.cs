using System;
using System.Collections.Generic;
using System.Text;

namespace random1
{
    class Grade
    {
        public string Subject;
        public double Score;

        public override string ToString()
        {
            return $"{Subject} = {Score}";
        }
    }
}
