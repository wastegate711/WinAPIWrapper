using System;
using System.Runtime.InteropServices;

namespace WinApi.Kernel32.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Overlapped
    {
        public uint Internal;
        public uint InternalHigh;
        public uint Offset;
        public uint OffsetHigh;
        public IntPtr Pointer;
        public IntPtr hEvent;
    }
}