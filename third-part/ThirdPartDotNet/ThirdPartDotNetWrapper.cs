using System.Runtime.InteropServices;

namespace ThirdPartDotNet
{
    internal static class ThirdPartDotNetWrapper
    {
        [DllImport(@"THIRDPARTNATIVE.dll", EntryPoint = "getPointerSize", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPointerSize();
    }
}
