using System.Runtime.InteropServices;

namespace WinApi.User32.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Input
    {
        public long type;
        public MouseInput mouseInput;
        public KeyBoardInput keyBoardInput;
    }
}