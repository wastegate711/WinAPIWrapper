using System;
using System.ComponentModel;

namespace WinApi.Kernel32.Enums
{
    public enum ShareMode : uint
    {
        ZERO=0,
        FILE_SHARE_DELETE=0x00000004,
        FILE_SHARE_READ=0x00000001,
        FILE_SHARE_WRITE=0x00000002
    }
}