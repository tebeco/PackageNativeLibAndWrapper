using System.Runtime.InteropServices;

namespace MyDotNetLib
{
    internal static class MyDotNetLibWrapper
    {

#if DEBUG
        [DllImport(@"..\..\..\..\..\lib\Debug\x64\MYNATIVELIB.dll", EntryPoint = "getPointerSize", CallingConvention = CallingConvention.StdCall)]
#else
        [DllImport(@"MYNATIVELIB.dll", EntryPoint = "getPointerSize", CallingConvention = CallingConvention.StdCall)]
#endif
        public static extern int GetPointerSize();
    }
}
