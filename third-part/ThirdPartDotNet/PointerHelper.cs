using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdPartDotNet
{
    public static class PointerHelper
    {
        public static int GetPointSize()
        {
            return ThirdPartDotNetWrapper.GetPointerSize();
        }
    }
}
