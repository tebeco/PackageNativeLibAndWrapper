using System.Runtime.InteropServices;

namespace ThirdPartDotNet
{
    internal static class ThirdPartDotNetWrapper
    {

#if DEBUG
        [DllImport(@"..\..\..\..\..\..\lib\Debug\x64\THIRDPARTNATIVE.dll", EntryPoint = "getPointerSize", CallingConvention = CallingConvention.StdCall)]
        //[DllImport(@"..\..\..\..\..\..\lib\Debug\Win32\THIRDPARTNATIVE.dll", EntryPoint = "getPointerSize", CallingConvention = CallingConvention.StdCall)]
#else
        [DllImport(@"THIRDPARTNATIVE.dll", EntryPoint = "getPointerSize", CallingConvention = CallingConvention.StdCall)]
#endif
        public static extern int GetPointerSize();
    }
}
