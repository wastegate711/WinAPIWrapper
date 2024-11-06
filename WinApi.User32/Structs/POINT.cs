using System.Runtime.InteropServices;

namespace WinApi.User32.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;
    }
}