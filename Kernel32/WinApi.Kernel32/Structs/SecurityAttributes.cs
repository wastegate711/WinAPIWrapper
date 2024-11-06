using System;
using System.Runtime.InteropServices;

namespace WinApi.Kernel32.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SecurityAttributes
    {
        public uint length;
        public IntPtr securityDescriptor;
        [MarshalAs(UnmanagedType.Bool)]
        public bool bInheritHandle;
    }
}