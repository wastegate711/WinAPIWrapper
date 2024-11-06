using System;

namespace WinApi.User32.Structs
{
    /// <summary>
    /// Содержит сведения о событии имитации клавиатуры.
    /// </summary>
    public struct KeyBoardInput
    {
        /// <summary>
        /// Код должен быть значением в диапазоне от 1 до 254. Если элемент dwFlags указывает
        /// KEYEVENTF_UNICODE, wVk должен иметь значение 0.
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