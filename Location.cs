using System;
using System.Collections.Generic;
using System.Text;

namespace _01
{
    struct Location
    {
        public int RIndex { get; set; }
        public int CIndex { get; set; }
        public Location(int rIndex, int cIndex):this()
        {
            this.RIndex = rIndex;
            this.CIndex = cIndex;
        }
    }
}
