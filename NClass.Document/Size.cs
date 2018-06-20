using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NClass.Document
{
    public struct Size
    {
       public readonly int width;
        public readonly int height;

        public Size(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}