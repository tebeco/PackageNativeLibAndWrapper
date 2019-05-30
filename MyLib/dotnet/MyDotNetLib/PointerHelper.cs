using System;
using System.Collections.Generic;
using System.Text;

namespace MyDotNetLib
{
    public static class PointerHelper
    {
        public static int GetPointSize()
        {
            return MyDotNetLibWrapper.GetPointerSize();
        }
    }
}
