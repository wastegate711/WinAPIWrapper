using System;

namespace WinApi.User32.Structs
{
    /// <summary>
    /// 
    /// </summary>
    public struct KeyBoardInput
    {
        /// <summary>
        /// 
        /// </summary>
        public ushort wVk;

        /// <summary>
        /// 
        /// </summary>
        public ushort wScan;

        /// <summary>
        /// 
        /// </summary>
        public uint dwFlags;

        /// <summary>
        /// 
        /// </summary>
        public uint time;

        /// <summary>
        /// 
        /// </summary>
        public IntPtr dwExtraInfo;
    }
}