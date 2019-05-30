using System.Runtime.InteropServices;

namespace MyDotNetLib
{
    internal static class MyDotNetLibWrapper
    {
        [DllImport(@"MYNATIVELIB.dll", EntryPoint = "getPointerSize", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPointerSize();
    }
}
