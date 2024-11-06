using System;
using System.Runtime.InteropServices;

namespace WinApi.Kernel32.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct StartupInfoA
    {
        public uint  cb;
        [MarshalAs(UnmanagedType.LPStr)]
        public string  reserved;
        [MarshalAs(UnmanagedType.LPStr)]
        public string  desktop;
        [MarshalAs(UnmanagedType.LPStr)]
        public string title;
        public uint x;
        public uint y;
        public uint xSize;
        public uint ySize;
        public uint xCountChars;
        public uint yCountChars;
        public uint fillAttribute;
        public uint flags;
        public ushort showWindow;
        public ushort cbReserved2;
        public byte[] lpReserved2;
        public IntPtr stdInput;
        public IntPtr stdOutput;
        public IntPtr stdError;
    }
}