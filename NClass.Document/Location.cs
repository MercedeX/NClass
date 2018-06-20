using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NClass.Document
{
    public struct Location
    {
        public readonly int x;
        public readonly int y;

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}